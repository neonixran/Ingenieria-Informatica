using Microsoft.AspNetCore.Mvc;
using pryEjercicio1.Models;
using System.Diagnostics;

namespace pryEjercicio1.Controllers
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

        public IActionResult convertirMoneda(String clp, String usd)
        {
            if (clp != null || usd != null)
            {
                double op = 0.0;
                double valorCLP = 925.23;

                if (clp == null)
                {
                    // Convertir USD a CLP
                    double USD = double.Parse(usd);
                    op = valorCLP * USD;
                } else
                {
                    // Convertir CLP a USD
                    double CLP = double.Parse(clp);
                    op = CLP / valorCLP;
                }

                ViewBag.mensaje = String.Format(
                    "El valor de ${0} {1} es de ${2} {3}", // Texto
                    (clp != null ? clp : usd), // Argumento 0
                    (clp == null ? "usd" : "pesos"), // Argumento 1
                    Math.Round(op, 2), // Argumento 2
                    (clp != null ? "usd" : "pesos") // Argumento 3
                );
            } else
            {
                ViewBag.mensaje = "Debe ingresar al menos un valor en cualquier campo.";
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
