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
    public class ReceitaAutorRepository : GenericRepository<ReceitaAutor, int>, IReceitaAutorRepository
    {
        public ReceitaAutorRepository(DbContext context) : base(context)
        {

        }

    }
}
