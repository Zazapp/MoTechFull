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
    public class NarudzbeStavkeService : BaseCRUDService<Model.NarudzbeStavke, Database.NarudzbaStavke, NarudzbeStavkeSearchObject, NarudzbeStavkeInsertRequest, object>, INarudzbeStavkeService
    {
        public NarudzbeStavkeService(MoTechContext context, IMapper mapper) : base(context, mapper) { }

        public override IEnumerable<Model.NarudzbeStavke> Get(NarudzbeStavkeSearchObject search = null)
        {
            var entity = Context.Set<Database.NarudzbaStavke>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();

            if (search.NarudzbaStavkeId.HasValue)
            {
                entity = entity.Where(x => x.NarudzbaStavkeId == search.NarudzbaStavkeId);
            }

            if (search.KupacNarudzbeId.HasValue)
            {
                entity = entity.Where(x => x.KupacNarudzbeId == search.KupacNarudzbeId);
            }

            if (search.ArtikalId.HasValue)
            {
                entity = entity.Where(x => x.ArtikalId == search.ArtikalId);
            }

            if (search?.IncludeListKupacNarudzbe == true)
            {
                entity = entity.Include(x => x.KupacNarudzbe);
            }

            if (search?.IncludeListArtikal == true)
            {
                entity = entity.Include(x => x.Artikal);
            }

            if (search?.IncludeListRacun == true)
            {
                entity = entity.Include(x => x.Racun);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.NarudzbeStavke>>(list);
        }
    }
}
