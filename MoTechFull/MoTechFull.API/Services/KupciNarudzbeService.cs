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
    public class KupciNarudzbeService : BaseCRUDService<Model.KupciNarudzbe, Database.KupacNarudzbe, KupciNarudzbeSearchObject, KupciNarudzbeInsertRequest, object>, IKupciNarudzbeService
    {
        public KupciNarudzbeService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.KupciNarudzbe> Get(KupciNarudzbeSearchObject search = null)
        {
            var entity = Context.Set<Database.KupacNarudzbe>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();

            if (search.KupacNarudzbeId.HasValue)
            {
                entity = entity.Where(x => x.KupacNarudzbeId == search.KupacNarudzbeId);
            }

            if (search.KorisnickiNalogId.HasValue)
            {
                entity = entity.Where(x => x.KorisnickiNalogId == search.KorisnickiNalogId);
            }

            if (search.GradId.HasValue)
            {
                entity = entity.Where(x => x.GradId == search.GradId);
            }

            if (search.IsIsporucena.HasValue)
            {
                entity = entity.Where(x => x.IsIsporucena == search.IsIsporucena);
            }

            if (search?.IncludeListKorisnickiNalog == true)
            {
                entity = entity.Include(x => x.KorisnickiNalog);
            }

            if (search?.IncludeListGrad == true)
            {
                entity = entity.Include(x => x.Grad);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.KupciNarudzbe>>(list);
        }
    }
}
