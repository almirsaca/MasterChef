using MasterChef.Models.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterChef.Models
{
    public interface IReceitaServices
    {
        IEnumerable<Receita> ListaReceita();
        Task<Receita> PesquisaReceitaAsync(int id);
        Receita AdicionaReceita(SetReceita receita);
        ReceitaAutor SetReceitaAutor(ReceitaAutor receitaAutor);
        ReceitaCategoria SetReceitaCategoria(ReceitaCategoria receitaCategoria);
        ReceitaIngrediente SetReceitaIngrediente(ReceitaIngrediente receitaIngrediente);
        ReceitaPrepraro SetReceitaPrepraro(ReceitaPrepraro receitaPrepraro);
    }
}