using System.ComponentModel.DataAnnotations;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaPrepraro
    {
        public int ReceitaPrepraroID { get; set; }
        public int ReceitaID { get; set; }
        public string ModoPreparo { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
