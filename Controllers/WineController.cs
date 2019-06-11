using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using systemwine.app.Models;

namespace systemwine.app.Controllers
{
    public class WineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Vinho vinho = new Vinho();
            vinho.Description = "Vinho que vai bem com qualquer coisa.";
            vinho.Name = "Wayne - O vinho mais parrudo de Gotham City";
            vinho.Price = id;
            return View(vinho);
        }
    }
}
