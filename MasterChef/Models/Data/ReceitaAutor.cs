using System.ComponentModel.DataAnnotations;
using static MasterChef.Models.Enums;

namespace MasterChef.Models.Data
{
    public class ReceitaAutor
    {
        public int ReceitaAutorID { get; set; }
        public string Nome { get; set; }
        public EnumStatusItem StatusItemID { get; set; }
    }
}
