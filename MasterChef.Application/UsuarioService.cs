using MasterChef.Domain;
using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MasterChef.Application
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository Repository;
        private readonly IUnitOfWork UnitOfWork;

        public UsuarioService(IUsuarioRepository repository,
                              IUnitOfWork unitOfWork)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
        }


        public IPaginatedList<Usuario> GetPaginated(int pageIndex, int pageSize)
        {
            var filtro = Repository.GetAll().Where(p => p.Ativo);

            return Repository.GetPaginated(filtro, pageIndex, pageSize);
        }

        public Usuario GetById(int id)
        {
            return Repository.GetByID(id);
        }

        public Usuario GeUsuarioByEmailAndSenha(string email, string senha)
        {
            return Repository.GeUsuarioByEmailAndSenha(email, senha);
        }

        public Usuario Salvar(Usuario usuario)
        {
            if (usuario.UsuarioID == 0)
            {
                Repository.Add(usuario);
            }
            else
            {
                Repository.Update(usuario);
            }

            UnitOfWork.Commit();

            return usuario;
        }
    }
}
