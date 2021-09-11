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
    public class RacuniService : BaseCRUDService<Model.Racuni, Database.Racun, RacuniSearchObject, RacuniInsertRequest, object>, IRacuniService
    {
        public RacuniService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Racuni> Get(RacuniSearchObject search = null)
        {
            var entity = Context.Set<Database.Racun>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();


            var list = entity.ToList();

            return _mapper.Map<List<Model.Racuni>>(list);
        }
    }
}
