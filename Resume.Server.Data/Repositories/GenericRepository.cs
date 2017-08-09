using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;

namespace Resume.Server.Data.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private Entities context;
        private DbSet<TEntity> dbSet;


        public GenericRepository(Entities context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }


        #region generic methods
        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        // get based on condition
        public virtual IEnumerable<TEntity> Get(Func<TEntity, bool> condition)
        {
            IQueryable<TEntity> query = dbSet;

            return dbSet.Where(condition).ToList();
        }

        // get based on condition including referenced entity
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> condition, params string[] include)
        {
            IQueryable<TEntity> query = this.dbSet;

            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(condition);
        }

        public virtual TEntity Get(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void InsertOrUpdate(TEntity entity)
        {
            dbSet.AddOrUpdate(entity);
            Save();
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            Save();
        }
        #endregion


        public void Save()
        {
            context.SaveChanges();
        }

    }
}