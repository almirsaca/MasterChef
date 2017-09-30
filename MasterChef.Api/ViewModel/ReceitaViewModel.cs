using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Api.ViewModel
{
    public class ReceitaViewModel
    {
        public int ReceitaID { get; set; }
        public int ReceitaCategoriaID { get; set; }
        public int ReceitaAutorID { get; set; }
        public string Titulo { get; set; }


        public Receita ToDomain()
        {
            return new Receita(ReceitaID, ReceitaCategoriaID, ReceitaAutorID, Titulo);
        }
    }


}
