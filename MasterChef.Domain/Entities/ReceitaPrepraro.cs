using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MasterChef.Domain.Entities
{
    public class ReceitaPrepraro : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaPrepraroID { get; set; }
        [ForeignKey("Receita")]
        public int ReceitaID { get; set; }
        public string ModoPreparo { get; set; }

        public ReceitaPrepraro() { }

    }
}
