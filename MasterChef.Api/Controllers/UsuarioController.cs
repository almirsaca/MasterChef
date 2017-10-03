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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService UsuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            UsuarioService = usuarioService;

        }

        [HttpGet]
        public IPaginatedList<Usuario> Get(int page = 1, int size = 20)
        {
            return UsuarioService.GetPaginated(page, size);
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return UsuarioService.GetById(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody]UsuarioViewModel viewModel)
        {
            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            UsuarioService.Salvar(domain);

            return Ok(domain);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]UsuarioViewModel viewModel)
        {
            if (UsuarioService.GetById(id) is null)
            {
                return NotFound();
            }

            var domain = viewModel.ToDomain();

            if (!domain.IsValid())
            {
                return BadRequest("Erro na validação da entidade");
            }

            UsuarioService.Salvar(domain);

            return Ok(domain);
        }
    }
}
