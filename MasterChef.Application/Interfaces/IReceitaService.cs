using MasterChef.Domain.Entities;
using MasterChef.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Application.Interfaces
{
    public interface IReceitaService
    {
        IPaginatedList<Receita> GetPaginated(int pageIndex, int pageSize);
        Receita GetById(int id);
        Receita Salvar(Receita receita);
    }
}
