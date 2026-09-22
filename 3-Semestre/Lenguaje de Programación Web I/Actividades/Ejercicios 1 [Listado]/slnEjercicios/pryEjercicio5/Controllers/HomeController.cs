using Microsoft.AspNetCore.Mvc;
using pryEjercicio5.Models;
using System.Diagnostics;

namespace pryEjercicio5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult calcularSueldo(String sueldo)
        {
            if (sueldo != null)
            {
                decimal Sueldo = decimal.Parse(sueldo);
                decimal sueldoAnual = Sueldo * 12;

                ViewBag.mensaje = String.Format("Su sueldo anual es de {0:C}", sueldoAnual);
            } else
            {
                ViewBag.mensaje = "Debe ingresar su sueldo para poder calcular";
            }

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
