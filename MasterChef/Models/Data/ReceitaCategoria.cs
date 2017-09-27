using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaCategoriaID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
