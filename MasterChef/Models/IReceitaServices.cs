using MasterChef.Models.Data;
using System.Collections.Generic;

namespace MasterChef.Models
{
    public interface IReceitaServices
    {
        IEnumerable<Receita> Listar();
        Receita Pesquisar(int id);
    }
}