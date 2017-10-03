using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Api.ViewModel
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


        public Usuario ToDomain()
        {
            return new Usuario(UsuarioId, Nome, Email, Senha);
        }
    }
}
