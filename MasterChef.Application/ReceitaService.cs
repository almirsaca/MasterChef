using MasterChef.Application.Interfaces;
using MasterChef.Domain;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using MasterChef.Domains;
using System;
using System.Linq;

namespace MasterChef.Application
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepository Repository;
        private readonly IUnitOfWork UnitOfWork;

        public ReceitaService(IReceitaRepository repository,
                              IUnitOfWork unitOfWork)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
        }

        public IPaginatedList<Receita> GetPaginated(int pageIndex, int pageSize)
        {
            var filtro = Repository.GetAll().Where(p => p.Ativo);

            return Repository.GetPaginated(filtro, pageIndex, pageSize);
        }

        public Receita GetById(int id)
        {
            return Repository.GetByID(id);
        }

        public Receita Salvar(Receita receita)
        {
            if (receita.ReceitaID == 0)
            {
                Repository.Add(receita);
            }
            else
            {
                Repository.Update(receita);
            }

            UnitOfWork.Commit();

            return receita;
        }

    }
}
