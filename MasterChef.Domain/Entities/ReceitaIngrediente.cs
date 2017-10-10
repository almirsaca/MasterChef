namespace MasterChef.Domain.Entities
{
    public class ReceitaIngrediente : EntityBase
    {
        public int ReceitaIngredienteID { get; set; }
        public int ReceitaID { get; set; }
        public int IngredienteID { get; set; }
        public int Quantidade { get; set; }

        public Receita Receita { get; set; }
        public Ingrediente Ingrediente { get; set; }

        protected ReceitaIngrediente() { }
    }
}
