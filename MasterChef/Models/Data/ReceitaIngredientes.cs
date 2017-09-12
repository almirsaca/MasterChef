using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class ReceitaIngredientes
    {
        [Key]
        public int ReceitaIngredientesID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
    }
}
