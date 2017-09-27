using MasterChef.Data.Context;
using MasterChef.Models.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MasterChef.Models
{
    public class ReceitaServices : IReceitaServices
    {
        private readonly ReceitaContext db = new ReceitaContext("conn");

        public IEnumerable<Receita> ListaReceita()
        {
            return db.Receita.Include(a => a.ReceitaAutorID).Include(c => c.ReceitaCategoriaID);
        }

        public async Task<Receita> PesquisaReceitaAsync(int id)
        {
            return await db.Receita.Include(a => a.ReceitaAutorID).Include(c => c.ReceitaCategoriaID).FirstAsync(r => r.ReceitaID == id);
        }

        public Receita AdicionaReceita(SetReceita receita)
        {
            var receitaAutorID = SetReceitaAutor(receita.ReceitaAutor);
            var receitaCategoriaID = SetReceitaCategoria(receita.ReceitaCategoria);
            var receitaIngredienteID = SetReceitaIngrediente(receita.ReceitaIngrediente);
            var receitaPrepraroID = SetReceitaPrepraro(receita.ReceitaPrepraro);

            var novaReceita = new Receita
            {
                ReceitaAutorID = receitaAutorID.ReceitaAutorID,
                ReceitaCategoriaID = receitaCategoriaID.ReceitaCategoriaID,
                Titulo = receita.Receita.Titulo,
                StatusItemID = receita.Receita.StatusItemID
            };
            db.Add(novaReceita);
            db.SaveChanges();
            return novaReceita;
        }

        public ReceitaAutor SetReceitaAutor(ReceitaAutor receitaAutor)
        {
            db.Add(receitaAutor);
            db.SaveChanges();
            return receitaAutor;
        }

        public ReceitaCategoria SetReceitaCategoria(ReceitaCategoria receitaCategoria)
        {
            db.Add(receitaCategoria);
            db.SaveChanges();
            return receitaCategoria;
        }

        public ReceitaIngrediente SetReceitaIngrediente(ReceitaIngrediente receitaIngrediente)
        {
            db.Add(receitaIngrediente);
            db.SaveChanges();
            return receitaIngrediente;
        }

        public ReceitaPrepraro SetReceitaPrepraro(ReceitaPrepraro receitaPrepraro)
        {
            db.Add(receitaPrepraro);
            db.SaveChanges();
            return receitaPrepraro;
        }
    }
}
