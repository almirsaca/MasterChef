using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MasterChef.Repository.Repository
{
    public class IngredienteRepository : GenericRepository<Ingrediente, int>, IIngredienteRepository
    {
        public IngredienteRepository(DbContext context) : base(context)
        {
        }
    }
}
