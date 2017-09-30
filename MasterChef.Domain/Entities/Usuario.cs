using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public int UsuarioID { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }

        protected Usuario()
        {

        }


        public Usuario(int usuarioId, string nome, string email, string senha)
        {
            AlterarUsuarioId(usuarioId);
            AlterarNome(nome);
            AlterarEmail(email);
            AlterarSenha(senha);
            Ativar();
        }

        private void AlterarSenha(string senha)
        {
            this.Senha = senha;
        }

        private void AlterarEmail(string email)
        {
            this.Email = email;
        }

        private void AlterarNome(string nome)
        {
            this.Nome = nome;
        }

        private void AlterarUsuarioId(int usuarioId)
        {
            this.UsuarioID = usuarioId;
        }
    }
}
