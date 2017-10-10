using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Interfaces
{
    public interface IIngredienteRepository : IGenericRepository<ReceitaIngrediente, int>
    {
    }
}
