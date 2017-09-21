using MasterChef.Data.Context;
using MasterChef.Models.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace MasterChef.Models
{
    public class ReceitaServices : IReceitaServices
    {
        private readonly ReceitaContext db = new ReceitaContext("conn");

        public IEnumerable<Receita> Listar()
        {
            return db.Receita.Include(a => a.ReceitaAutorID).Include(c => c.ReceitaCategoriaID);
        }

        public Receita Pesquisar(int id)
        {
            return null;
        }
    }
}
