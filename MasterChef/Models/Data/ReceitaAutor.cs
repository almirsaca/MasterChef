using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaAutor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaAutorID { get; set; }
        public string Nome { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
