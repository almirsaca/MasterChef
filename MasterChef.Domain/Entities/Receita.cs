using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterChef.Domain.Entities
{
    public class Receita : EntityBase
    {
        public int ReceitaID { get; protected set; }
        public int ReceitaCategoriaID { get; protected set; }
        public int ReceitaAutorID { get; protected set; }
        public string Titulo { get; protected set; }

        public ReceitaCategoria ReceitaCategoria { get; set; }
        public ReceitaAutor ReceitaAutor { get; set; }
        public IEnumerable<ReceitaIngrediente> Ingredientes { get; set; }

        protected Receita() { }
        
        public Receita(int receitaId, int categoriaId, int autorId, string titulo)
        {
            AlterarReceitaId(receitaId);
            AlterarCategoriaId(categoriaId);
            AlterarAutor(autorId);
            AlterarTitulo(titulo);
            Ativar();
        }

        private void AlterarTitulo(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                AddException(nameof(Receita), nameof(this.Titulo), "O titulo é obrigatório.");

            this.Titulo = titulo;
        }

        private void AlterarAutor(int autorId)
        {
            this.ReceitaAutorID = autorId;
        }

        private void AlterarCategoriaId(int categoriaId)
        {
            this.ReceitaCategoriaID = categoriaId;
        }

        private void AlterarReceitaId(int receitaId)
        {
            this.ReceitaID = receitaId;
        }
    }
}
