using AutoMapper;
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
    public class ProizvodjaciService : BaseCRUDService<Model.Proizvodjaci, Database.Proizvodjac, ProizvodjaciSearchObject, ProizvodjaciInsertUpdateRequest,ProizvodjaciInsertUpdateRequest>, IProizvodjaciService
    {
        public ProizvodjaciService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Proizvodjaci> Get(ProizvodjaciSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvodjac>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }


            var list = entity.ToList();

            return _mapper.Map<List<Model.Proizvodjaci>>(list);
        }
    }
}
