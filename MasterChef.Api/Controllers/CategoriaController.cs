using MasterChef.Api.ViewModel;
using MasterChef.Domain;
using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MasterChef.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService Service;

        public CategoriaController(ICategoriaService service)
        {
            Service = service;
        }

        [HttpGet]
        public IPaginatedList<ReceitaCategoria> Get(int page = 1, int size = 20)
        {
            return Service.GetPaginated(page, size);
        }

        [HttpGet("{id}")]
        public ReceitaCategoria Get(int id)
        {
            return Service.GetById(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody]CategoriaViewModel viewModel)
        {
            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            Service.Salvar(domain);

            return Ok(domain);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]CategoriaViewModel viewModel)
        {
            if (Service.GetById(id) is null)
            {
                return NotFound();
            }

            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            Service.Salvar(domain);

            return Ok(domain);
        }
    }
}
