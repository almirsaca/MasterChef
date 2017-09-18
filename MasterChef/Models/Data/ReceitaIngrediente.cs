using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class ReceitaIngrediente
    {
        public int ReceitaIngredienteID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
    }
}
