using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MasterChef.Domain.Entities
{
    public class ReceitaIngrediente : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaIngredienteID { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public string Item { get; set; }

    }
}
