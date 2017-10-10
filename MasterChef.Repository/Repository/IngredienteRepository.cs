namespace MasterChef.Repository.Repository
{
    class IngredienteRepository : GenericRepository<Ingrediente, int>, IIngredienteRepository
    {
        public IngredienteRepository(DbContext context) : base(context)
        {
        }
    }
}
