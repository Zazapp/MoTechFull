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
    public class RacuniService : BaseCRUDService<Model.Racuni, Database.Racun, RacuniSearchObject, RacuniInsertRequest, RacuniUpdateRequest>, IRacuniService
    {
        public RacuniService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Racuni> Get(RacuniSearchObject search = null)
        {
            var entity = Context.Set<Database.Racun>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();

            if (search.KorisnickiNalogId.HasValue)
            {
                entity = entity.Where(x => x.KorisnickiNalogId == search.KorisnickiNalogId);
            }


            if (search.Iznos.HasValue)
            {
                entity = entity.Where(x => x.Iznos == search.Iznos);
            }


            var list = entity.ToList();

            return _mapper.Map<List<Model.Racuni>>(list);
        }

        public override Model.Racuni Update(int id,RacuniUpdateRequest request) 
        {
            //var set = Context.Set<TDb>();
            //var entity = set.Find(id);
            //_mapper.Map(request, entity);
            //Context.SaveChanges();

            //return _mapper.Map<T>(entity);

            var set = Context.Set<Racun>();
            var entity = set.Find(id);
            entity.Iznos = request.Iznos;
            Context.SaveChanges();

            return _mapper.Map<Model.Racuni>(entity);
        }
    }
}
