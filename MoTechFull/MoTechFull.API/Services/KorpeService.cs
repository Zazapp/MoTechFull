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
    public class KorpeService : BaseCRUDService<Model.Korpe, Database.Korpa, KorpeSearchObject, KorpeInsertUpdateRequest, KorpeInsertUpdateRequest>, IKorpeService
    {
        public KorpeService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.Korpe> Get(KorpeSearchObject search = null)
        {
            var entity = Context.Set<Database.Korpa>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();


            var list = entity.ToList();

            return _mapper.Map<List<Model.Korpe>>(list);
        }
    }
}
