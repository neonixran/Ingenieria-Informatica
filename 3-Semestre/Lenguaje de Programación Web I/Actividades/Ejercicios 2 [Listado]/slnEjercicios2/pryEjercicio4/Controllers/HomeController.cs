using Microsoft.AspNetCore.Mvc;
using pryEjercicio4.Models;
using System.Diagnostics;

namespace pryEjercicio4.Controllers
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

        public IActionResult calcularSueldo(int venta1, int venta2, int venta3)
        {
            if (venta1 < 1 && venta2 < 1 && venta3 < 1)
            {
                ViewBag.resultado = "Debe ingresar valores";
            } else
            {
                int sueldoBase = 300000;
                double comisionVentas = 0.12 * (venta1 + venta2 + venta3);
                double sueldoNeto = sueldoBase + comisionVentas;

                ViewBag.resultado = String.Format("Su sueldo neto es de {0:C}", sueldoNeto);
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
