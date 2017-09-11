namespace MasterChef.Models.Data
{
    public class ReceitaIngredientes
    {
        public int ReceitaIngredientesID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }
    }
}
