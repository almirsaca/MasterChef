using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Application
{
    public interface IUsuarioService
    {
        Usuario GetById(int id);
        Usuario GeUsuarioByEmailAndSenha(string email, string senha);
    }
}
