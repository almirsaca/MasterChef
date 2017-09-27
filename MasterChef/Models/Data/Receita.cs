using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaID { get; set; }
        public int ReceitaCategoriaID { get; set; }
        public int ReceitaAutorID { get; set; }
        public string Titulo { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
