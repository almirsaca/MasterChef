using MasterChef.Domain.Entities;

namespace MasterChef.Api.ViewModel
{
    public class CategoriaViewModel
    {
        public int ReceitaCategoriaID { get; set; }
        public string Descricao { get; set; }

        public ReceitaCategoria ToDomain()
        {
            return new ReceitaCategoria(ReceitaCategoriaID, Descricao);
        }
    }
}
