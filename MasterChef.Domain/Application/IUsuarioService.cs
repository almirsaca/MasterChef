using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Application
{
    public interface IUsuarioService
    {
        IPaginatedList<Usuario> GetPaginated(int pageIndex, int pageSize);
        Usuario GetById(int id);
        Usuario GeUsuarioByEmailAndSenha(string email, string senha);
        Usuario Salvar(Usuario usuario);
    }
}
