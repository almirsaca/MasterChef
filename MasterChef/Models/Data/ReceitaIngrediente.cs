using System.ComponentModel.DataAnnotations;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaIngrediente
    {
        public int ReceitaIngredienteID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
