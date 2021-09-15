using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using MoTechFull.Database;
using MoTechFull.Filters;
using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public class ArtikliService : BaseCRUDService<Model.Artikli, Database.Artikal,Model.ArtikliSearchObject,ArtikliInsertRequest,ArtikliUpdateRequest>, IArtikliService
    {
        public ArtikliService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Artikli> Get(ArtikliSearchObject search = null)
        {
            var entity = Context.Set<Database.Artikal>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.KategorijaId.HasValue && search.KategorijaId!=0)
            {
                entity = entity.Where(x => x.KategorijaId == search.KategorijaId);
            }

            if (search.ProizvodjacId.HasValue && search.KategorijaId != 0)
            {
                entity = entity.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }

            if (search?.IncludeListKategorija == true)
            {
                entity = entity.Include(x => x.Kategorija);
            }

            if (search?.IncludeListProizvodjac == true)
            {
                entity = entity.Include(x => x.Proizvodjac);
            }



            var list = entity.ToList();

            return _mapper.Map<List<Model.Artikli>>(list);
        }

        private static MLContext mlContext = null;
        private static ITransformer model=null;
        public List<Model.Artikli> Recommend(int id) 
        {
            if (mlContext == null) 
            {
                mlContext = new MLContext();

                var tmpData = Context.Racuns.Include("NarudzbaStavkes").ToList();
                var data = new List<ProductEntry>();

                foreach(var x in tmpData) 
                {
                    if (x.NarudzbaStavkes.Count > 1) 
                    {
                        var distinctItemId = x.NarudzbaStavkes.Select(y => y.ArtikalId).ToList();
                        distinctItemId.ForEach(y =>
                        {
                            var relatedItems = x.NarudzbaStavkes.Where(z => z.ArtikalId != y);

                            foreach(var z in relatedItems) 
                            {
                                data.Add(new ProductEntry()
                                {
                                    ProductID=(uint)y,
                                    CoPurchaseProductID=(uint)z.ArtikalId
                                });

                            }
                        });
                    }
                }
               
                var traindata = mlContext.Data.LoadFromEnumerable(data);
       


                //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
                //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                // For better results use the following parameters
                options.NumberOfIterations = 100;
                options.C = 0.00001;

                //Step 4: Call the MatrixFactorization trainer by passing options.
                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                model = est.Fit(traindata);

            }

            var allItems = Context.Artikals.Where(x => x.ArtikalId != id);

            var predictionResult = new List<Tuple<Database.Artikal, float>>();

            foreach(var item in allItems) 
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);

                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    ProductID=(uint)id,
                    CoPurchaseProductID=(uint)item.ArtikalId
                });
                predictionResult.Add(new Tuple<Database.Artikal, float>(item, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1).Take(3).ToList();

            return _mapper.Map<List<Model.Artikli>>(finalResult);
        }
    }

    public class Copurchase_prediction 
    {
        public float Score { get; set;}
    }

    public class ProductEntry 
    {
        [KeyType(count:10)]
        public uint ProductID { get; set; }

        [KeyType(count: 10)]
        public uint CoPurchaseProductID { get; set; }

        public float Label { get; set; }
    }

}
