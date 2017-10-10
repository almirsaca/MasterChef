using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository
{
    public class ReceitaRepository : GenericRepository<Receita, int>, IReceitaRepository
    {
        public ReceitaRepository(DbContext context) : base(context)
        {

        }
    }
}
