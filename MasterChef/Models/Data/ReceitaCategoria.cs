using System;
using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class ReceitaCategoria
    {
        public int ReceitaCategoriaID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
