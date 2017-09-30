using MasterChef.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MasterChef.Domains;

namespace MasterChef.Repository
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        public DbSet<TEntity> DbSet { get; set; }

        public GenericRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            DbSet = context.Set<TEntity>();
        }

        public TEntity Add(TEntity item)
        {
            DbSet.Add(item);
            return item;
        }

        public bool Delete(TEntity item)
        {
            DbSet.Attach(item);
            DbSet.Remove(item);
            return true;
        }

        public bool DeleteByID(TKey id)
        {
            var item = DbSet.Find(id);
            DbSet.Remove(item);
            return true;
        }

        public bool Update(TEntity item)
        {
            DbSet.Attach(item);
            return true;
        }

        public virtual TEntity GetByID(TKey id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, TKey>> orderBy)
        {
            return DbSet.OrderBy(orderBy);
        }

        public IPaginatedList<TEntity> GetPaginated(IQueryable<TEntity> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedList<TEntity>(items, count, pageIndex, pageSize);
        }

    }
}

