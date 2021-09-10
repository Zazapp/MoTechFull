using AutoMapper;
using MoTechFull.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoTechFull.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T,TSearch> where T : class where TDb:class where TSearch:class
    {

        public MoTechContext Context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(MoTechContext context, IMapper mapper)
        {
            Context = context;
            _mapper=mapper;

        }

        public virtual IEnumerable<T> Get(TSearch search=null) 
        {
            var entity = Context.Set<TDb>();
            var list = entity.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }


    }
}