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
    public class KorpeService : BaseCRUDService<Model.Korpe, Database.Korpa, KorpeSearchObject, KorpeInsertRequest, KorpeUpdateRequest>, IKorpeService
    {
        public KorpeService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Korpe> Get(KorpeSearchObject search = null)
        {
            var entity = Context.Set<Database.Korpa>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();

            if (search.KorisnickiNalogId.HasValue)
            {
                entity = entity.Where(x => x.KorisnickiNalogId == search.KorisnickiNalogId);
            }

            if (search.KorpaId.HasValue)
            {
                entity = entity.Where(x => x.KorpaId == search.KorpaId);
            }

            if (search?.IncludeListKorisnickiNalog == true)
            {
                entity = entity.Include(x => x.KorisnickiNalog);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Korpe>>(list);
        }
    }
}
