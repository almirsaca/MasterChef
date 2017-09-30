using MasterChef.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Domain.Application
{
    public interface IReceitaService
    {
        IPaginatedList<Receita> GetPaginated(int pageIndex, int pageSize);
        Receita GetById(int id);
        Receita Salvar(Receita receita);
    }
}
