using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using credito.Models;

namespace credito.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<Tarjeta> Validar(string tarjetanum)
        {
            /// Creamos una tarjeta 
            Tarjeta tarjeta = new Tarjeta(tarjetanum);
            return Ok(tarjeta);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
