using Microsoft.AspNetCore.Mvc;
using pryEjercicio3.Models;
using System.Diagnostics;

namespace pryEjercicio3.Controllers
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

        public IActionResult calcularIMC(String masa, String estatura)
        {
            if (masa != null && estatura != null)
            {
                double Masa = double.Parse(masa);
                double Estatura = double.Parse(estatura);

                double imc = Masa / Math.Pow(Estatura / 100, 2);

                ViewBag.mensaje = String.Format("Su IMC es de {0}", Math.Truncate(imc * 100) / 100);
            } else
            {
                ViewBag.mensaje = "Debe ingresar la masa y altura para poder calcular el IMC.";
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
