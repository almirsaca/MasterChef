using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Repository
{
    public interface IUsuarioRepository : IGenericRepository<Usuario, int>
    {
        Usuario GeUsuarioByEmailAndSenha(string email, string senha);
    }
}
