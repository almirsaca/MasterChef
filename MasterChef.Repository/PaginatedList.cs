using MasterChef.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository
{
    public class PaginatedList<TEntity> : List<TEntity>, IPaginatedList<TEntity>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public PaginatedList(List<TEntity> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

    }
}
