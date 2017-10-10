using MasterChef.Domain.Entities;

namespace MasterChef.Domain.Application
{
    public interface IIngredienteService
    {
        IPaginatedList<Ingrediente> GetPaginated(int pageIndex, int pageSize);
        Ingrediente GetById(int id);
        Ingrediente Salvar(Ingrediente ingrediente);
    }
}
