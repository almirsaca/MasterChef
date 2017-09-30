using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MasterChef.Domain.Entities
{
    public class ReceitaAutor : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaAutorID { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Receita> Receitas { get; set; }


        protected ReceitaAutor()
        {

        }
    }
}
