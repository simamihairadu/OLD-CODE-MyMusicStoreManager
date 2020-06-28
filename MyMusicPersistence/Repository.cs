using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity :class
    {
        protected readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }
        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
    }
}
