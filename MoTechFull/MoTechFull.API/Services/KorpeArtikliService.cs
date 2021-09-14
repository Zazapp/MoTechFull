using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class KorpeArtikliService : BaseCRUDService<Model.KorpeArtikli, Database.KorpaArtikli, KorpeArtikliSearchObject, KorpeArtikliInsertRequest, KorpeArtikliUpdateRequest>, IKorpeArtikliService
    {
        public KorpeArtikliService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.KorpeArtikli> Get(KorpeArtikliSearchObject search = null)
        {
            var entity = Context.Set<Database.KorpaArtikli>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();

            if (search.KorpaArtikliId.HasValue)
            {
                entity = entity.Where(x => x.KorpaArtikliId == search.KorpaArtikliId);
            }

            if (search.KorpaId.HasValue)
            {
                entity = entity.Where(x => x.KorpaId == search.KorpaId);
            }

            if (search.ArtikalId.HasValue)
            {
                entity = entity.Where(x => x.ArtikalId == search.ArtikalId);
            }

            if (search?.IncludeListKorpa == true)
            {
                entity = entity.Include(x => x.Korpa);
            }

            if (search?.IncludeListArtikal == true)
            {
                entity = entity.Include(x => x.Artikal);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.KorpeArtikli>>(list);
        }

        public override Model.KorpeArtikli Insert(KorpeArtikliInsertRequest request) 
        {
            //var set = Context.Set<TDb>();
            //TDb entity = _mapper.Map<TDb>(request);
            //set.Add(entity);
            //Context.SaveChanges();

            //return _mapper.Map<T>(entity);

            var set = Context.Set<KorpaArtikli>();
            KorpaArtikli entity = _mapper.Map<KorpaArtikli>(request);
            entity.Artikal = Context.Artikals.Find(request.ArtikalId);
            entity.Korpa = Context.Korpas.Find(request.KorpaId);
            set.Add(entity);
            Context.SaveChanges();

            return _mapper.Map<KorpeArtikli>(entity);
        }

        public override Model.KorpeArtikli Update(int korpeArtikliId, KorpeArtikliUpdateRequest request)
        {
            //var set = Context.Set<TDb>();
            //var entity = set.Find(id);
            //_mapper.Map(request, entity);
            //Context.SaveChanges();

            //return _mapper.Map<T>(entity);

            var set = Context.Set<KorpaArtikli>();
            var entity = set.Find(korpeArtikliId);

            if (request.Kolicina == 0) 
            {
                set.Remove(entity);
                Context.SaveChanges();
                return _mapper.Map<Model.KorpeArtikli>(entity);
            }

            
            set.Find(korpeArtikliId).Kolicina = request.Kolicina;
            Context.SaveChanges();

            return _mapper.Map<Model.KorpeArtikli>(entity);
        }
    }
}

    

