using Microsoft.AspNetCore.Mvc;
using pryEjercicio2.Models;
using System.Diagnostics;

namespace pryEjercicio2.Controllers
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

        public IActionResult calcularCuota(String cuota)
        {
            decimal uf = 39841.72m;

            if (cuota != null)
            {
                decimal Cuota = decimal.Parse(cuota);
                decimal valorCuota = Cuota * uf;

                ViewBag.mensaje = String.Format("El valor de su cuota es de {0:C} pesos", valorCuota);
            } else
            {
                ViewBag.mensaje = "Debe ingresar el valor de la cuota";
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
