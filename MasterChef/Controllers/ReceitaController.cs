using Microsoft.AspNetCore.Mvc;
using MasterChef.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterChef.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly IReceitaServices _receitaServices;

        public ReceitaController(IReceitaServices receitaServices)
        {
            _receitaServices = receitaServices;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var retorno = _receitaServices.Listar();
            return View(retorno);
        }

        public IActionResult Details(int id = 0)
        {
            var retorno = _receitaServices.Pesquisar(id);
            return View(retorno);
        }
    }
}
