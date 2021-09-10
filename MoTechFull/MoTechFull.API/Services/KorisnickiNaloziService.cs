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
    public class KorisnickiNaloziService : IKorisnickiNaloziService
    {

        public MoTechContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KorisnickiNaloziService(MoTechContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IList<KorisnickiNalozi> Get(KorisnickiNaloziSearchObject search = null)
        {

            //var query = Context.KorisnickiNalogs.AsQueryable();

            //if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            //{
            //    query = query.Where(x => x.KorisnickoIme == search.KorisnickoIme);
            //}

            //if (!string.IsNullOrWhiteSpace(search?.Tip.ToString()))
            //{
            //    query = query.Where(x => x.Tip == search.Tip);
            //}

            //var entities = query.ToList();

            //var result = _mapper.Map<IList<Model.KorisnickiNalozi>>(entities);


            //return result;




            var entity = Context.Set<Database.KorisnickiNalog>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                entity = entity.Where(x => x.KorisnickoIme.Contains(search.KorisnickoIme));
            }

            if (search?.Tip != null && search?.Tip != 0)
            {
                entity = entity.Where(x => x.Tip.Equals(search.Tip));
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.KorisnickiNalozi>>(list);
        }

        public KorisnickiNalozi GetById(int id)
        {
            var entity = Context.KorisnickiNalogs.Find(id);

            return _mapper.Map<Model.KorisnickiNalozi>(entity);
        }

        public Model.KorisnickiNalozi Insert(KorisnickiNaloziInsertUpdateRequest request)
        {
            var entity = _mapper.Map<Database.KorisnickiNalog>(request);

            Context.Add(entity);

            Context.SaveChanges();

            return _mapper.Map<Model.KorisnickiNalozi>(entity);
        }

        public KorisnickiNalozi Update(int id, KorisnickiNaloziInsertUpdateRequest request)
        {
            var entity = Context.KorisnickiNalogs.Find(id);
            _mapper.Map(request, entity);

            Context.SaveChanges();
            return _mapper.Map<Model.KorisnickiNalozi>(entity);
        }

        public async Task<Model.KorisnickiNalozi> Login(string username,string password) 
        {
            var entity = await Context.KorisnickiNalogs.FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null) 
            {
                throw new UserException("Pogresan username ili password");
            }

            if (entity.Lozinka != password) 
            {
                throw new UserException("Pogresan username ili password");
            }

            return _mapper.Map<Model.KorisnickiNalozi>(entity);
        }
        
    }
}
