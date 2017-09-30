using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MasterChef.Domain.Entities
{
    public class ReceitaCategoria : EntityBase
    {
      
        public int ReceitaCategoriaID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public IEnumerable<Receita> Receitas { get; set; }


        protected ReceitaCategoria()
        {

        }
    }
}
