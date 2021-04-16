using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(ProdutoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var produto = model;
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
