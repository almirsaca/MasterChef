using System.ComponentModel.DataAnnotations;

namespace MasterChef.Models.Data
{
    public class Receitas
    {
        [Key]
        public int ReceitaID { get; set; }
        public int ReceitaCategoriaID { get; set; }
        public int ReceitaAutorID { get; set; }
        public string Titulo { get; set; }
    }
}
