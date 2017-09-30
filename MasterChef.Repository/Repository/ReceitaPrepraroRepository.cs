using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Repository
{
    public class ReceitaPrepraroRepository : GenericRepository<ReceitaPrepraro, int>, IReceitaPrepraroRepository
    {
        public ReceitaPrepraroRepository(DbContext context) : base(context)
        {

        }
    }
}
