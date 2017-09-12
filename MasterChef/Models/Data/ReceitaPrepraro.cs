using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class ReceitaPrepraro
    {
        [Key]
        public int ReceitaPrepraroID { get; set; }
        public int ReceitaID { get; set; }
        public string ModoPreparo { get; set; }
    }
}
