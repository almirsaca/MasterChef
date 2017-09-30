using MasterChef.Domain;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using MasterChef.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository
{
    public class ReceitaCategoriaRepository : GenericRepository<ReceitaCategoria, int>, IReceitaCategoriaRepository
    {
        public ReceitaCategoriaRepository(DbContext context) : base(context)
        {

        }

    }
}
