namespace MasterChef.Models.Data
{
    public class SetReceita
    {
        public Receita Receita { get; set; }
        public ReceitaAutor ReceitaAutor { get; set; }
        public ReceitaCategoria ReceitaCategoria { get; set; }
        public ReceitaIngrediente ReceitaIngrediente { get; set; }
        public ReceitaPrepraro ReceitaPrepraro { get; set; }
    }
}
