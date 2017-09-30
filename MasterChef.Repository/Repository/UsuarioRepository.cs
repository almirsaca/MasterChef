using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MasterChef.Domain.Repository;

namespace MasterChef.Repository.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario, int>, IUsuarioRepository
    {
        public UsuarioRepository(DbContext context) : base(context)
        {

        }

        public Usuario GeUsuarioByEmailAndSenha(string email, string senha)
        {
            return DbSet.FirstOrDefault(p => p.Email == email && p.Senha == senha);
        }
    }
}
