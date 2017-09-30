using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MasterChef.Domain
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class
    {
        TEntity Add(TEntity item);

        bool Update(TEntity item);

        bool DeleteByID(TKey id);

        bool Delete(TEntity item);

        TEntity GetByID(TKey id);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAll(Expression<Func<TEntity, TKey>> orderBy);

        IPaginatedList<TEntity> GetPaginated(IQueryable<TEntity> source, int pageIndex, int pageSize);
    }
}
