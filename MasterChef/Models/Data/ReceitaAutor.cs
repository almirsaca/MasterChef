using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class ReceitaAutor
    {
        [Key]
        public int ReceitaAutorID { get; set; }
        public string Nome { get; set; }
    }
}
