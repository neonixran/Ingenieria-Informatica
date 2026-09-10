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

        public IActionResult calcularTarifa(String minutos)
        {
            if (minutos != null)
            {
                int Minutos = int.Parse(minutos);

                if (Minutos < 0)
                {
                    ViewBag.mensaje = "Debe ingresar un valor positivo.";
                } else if (Minutos <= 20)
                {
                    ViewBag.mensaje = "Su tarifa es de $366 pesos";
                } else
                {
                    int minutoAdicional = Minutos - 20;
                    double tarifa = 366 + (minutoAdicional * 18.28);

                    ViewBag.mensaje = String.Format("Su tarifa es de {0:C} pesos", tarifa);
                }
            } else
            {
                ViewBag.mensaje = "Debe ingresar los minutos para poder calcular la tarifa";
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
