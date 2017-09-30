using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain
{
    public interface IPaginatedList<TEntity> : IList<TEntity>
    {
         int PageIndex { get; set; }
         int TotalPages { get; set; }
    }
}
