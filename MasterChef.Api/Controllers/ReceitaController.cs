using MasterChef.Api.ViewModel;
using MasterChef.Domain;
using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaService ReceitaService;

        public ReceitaController(IReceitaService receitaService)
        {
            ReceitaService = receitaService;

        }




        [HttpGet]
        public IPaginatedList<Receita> Get(int page = 1, int size = 20)
        {
            return ReceitaService.GetPaginated(page, size);
        }

        [HttpGet("{id}")]
        public Receita Get(int id)
        {
            return ReceitaService.GetById(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody]ReceitaViewModel viewModel)
        {
            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            ReceitaService.Salvar(domain);

            return Ok(domain);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]ReceitaViewModel viewModel)
        {
            if (ReceitaService.GetById(id) is null)
            {
                return NotFound();
            }

            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            ReceitaService.Salvar(domain);

            return Ok(domain);
        }
    }
}
