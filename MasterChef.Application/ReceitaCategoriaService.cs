using MasterChef.Domain;
using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using MasterChef.Domain.Repository;
using System.Linq;

namespace MasterChef.Application
{
    public class ReceitaCategoriaService : ICategoriaService
    {
        private readonly IReceitaCategoriaRepository Repository;
        private readonly IUnitOfWork UnitOfWork;

        public ReceitaCategoriaService(IReceitaCategoriaRepository repository,
                              IUnitOfWork unitOfWork)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
        }

        public ReceitaCategoria GetById(int id)
        {
            return Repository.GetByID(id);
        }

        public IPaginatedList<ReceitaCategoria> GetPaginated(int pageIndex, int pageSize)
        {
            var filtro = Repository.GetAll().Where(p => p.Ativo);

            return Repository.GetPaginated(filtro, pageIndex, pageSize);
        }

        public ReceitaCategoria Salvar(ReceitaCategoria categoria)
        {
            if (categoria.ReceitaCategoriaID == 0)
            {
                Repository.Add(categoria);
            }
            else
            {
                Repository.Update(categoria);
            }

            UnitOfWork.Commit();

            return categoria;
        }
    }
}
