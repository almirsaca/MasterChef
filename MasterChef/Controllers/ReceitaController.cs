using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MasterChef.Data.Context;
using MasterChef.Models.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MasterChef.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly ReceitaContext db = new ReceitaContext("conn");

        // GET: /<controller>/
        public IActionResult Index()
        {
            var retorno = new List<Receita>();
            for (int i = 0; i < 10; i++)
            {
                var m = new Receita { ReceitaID = i, Titulo  = $"Titulo {i}" };
                retorno.Add(m);
            }
            // return View(db.Receita.ToList());
            return View(retorno);
        }

        public IActionResult Details(int id = 0)
        {
            var receita = db.Receita.Find(id);
            return View(receita);
        }
    }
}
