using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MasterChef.Data.Context;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterChef.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly ReceitaContext db = new ReceitaContext("conn");

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Receita.ToList());
        }

        public IActionResult Details(int id = 0)
        {
            var receita = db.Receita.Find(id);
            return View(receita);
        }
    }
}
