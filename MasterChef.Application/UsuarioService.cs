using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using MasterChef.Domain.Interfaces;
using MasterChef.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Usuario GetById(int id)
        {
            return Repository.GetByID(id);
        }

        public Usuario GeUsuarioByEmailAndSenha(string email, string senha)
        {
            return Repository.GeUsuarioByEmailAndSenha(email, senha);
        }
    }
}
