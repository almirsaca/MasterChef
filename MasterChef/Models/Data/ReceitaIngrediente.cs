using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaIngrediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaIngredienteID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
