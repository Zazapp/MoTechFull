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
    public class KantoniService : BaseCRUDService<Model.Kantoni, Database.Kanton, KantoniSearchObject, KantoniInsertUpdateRequest, KantoniInsertUpdateRequest>, IKantoniService
    {
        public KantoniService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Kantoni> Get(KantoniSearchObject search = null)
        {
            var entity = Context.Set<Database.Kanton>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }


            var list = entity.ToList();

            return _mapper.Map<List<Model.Kantoni>>(list);
        }
    }
}
