using MasterChef.Domain.Entities;

namespace MasterChef.Domain.Application
{
    public interface ICategoriaService
    {
        IPaginatedList<ReceitaCategoria> GetPaginated(int pageIndex, int pageSize);
        ReceitaCategoria GetById(int id);
        ReceitaCategoria Salvar(ReceitaCategoria categoria);
    }
}
