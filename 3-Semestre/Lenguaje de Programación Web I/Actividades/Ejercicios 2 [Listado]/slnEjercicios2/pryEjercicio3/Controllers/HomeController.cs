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

        public IActionResult calcularAsistencia(int clases)
        {
            if (clases < 1)
            {
                ViewBag.resultado = "Debe ingresar un valor para calcular";
            } else
            {
                double aFaltar = clases * 0.75;
                ViewBag.resultado = String.Format("Usted puede faltar a {0} clases de Programación Web I", Math.Round(aFaltar));
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
