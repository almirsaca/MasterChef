using MasterChef.Domain;
using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using System.Linq;

namespace MasterChef.Application
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteRepository Repository;
        private readonly IUnitOfWork UnitOfWork;

        public IngredienteService(IIngredienteRepository repository,
                              IUnitOfWork unitOfWork)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
        }

        public IPaginatedList<Ingrediente> GetPaginated(int pageIndex, int pageSize)
        {
            var filtro = Repository.GetAll().Where(p => p.Ativo);

            return Repository.GetPaginated(filtro, pageIndex, pageSize);
        }

        public Ingrediente GetById(int id)
        {
            return Repository.GetByID(id);
        }

        public Ingrediente Salvar(Ingrediente ingrediente)
        {
            if (ingrediente.IngredienteID == 0)
            {
                Repository.Add(ingrediente);
            }
            else
            {
                Repository.Update(ingrediente);
            }

            UnitOfWork.Commit();

            return ingrediente;
        }

    }
}
