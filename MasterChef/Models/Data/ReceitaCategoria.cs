using System;
using System.ComponentModel.DataAnnotations;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaCategoria
    {
        public int ReceitaCategoriaID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
