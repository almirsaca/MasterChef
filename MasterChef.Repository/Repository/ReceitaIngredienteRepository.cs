using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Repository
{
    public class ReceitaIngredienteRepository : GenericRepository<ReceitaIngrediente, int>, IReceitaIngredienteRepository
    {
        public ReceitaIngredienteRepository(DbContext context) : base(context)
        {

        }
    }
}
