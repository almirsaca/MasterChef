using System.Collections.Generic;

namespace MasterChef.Domain.Entities
{
    public class Ingrediente : EntityBase
    {
        public int IngredienteID { get; set; }
        public string Nome { get; set; }
        public IEnumerable<ReceitaIngrediente> Ingredientes { get; set; }
    }
}
