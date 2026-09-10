using Microsoft.AspNetCore.Mvc;
using pryEjercicio2.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

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

        public IActionResult generarBucle(int opcion)
        {
            int contador = 0;

            if (opcion == 1)
            {
                ViewBag.bucle = "While";

                while (contador <= 10)
                {
                    ViewBag.resultado = contador.ToString();
                    contador++;
                }
            } else if (opcion == 2)
            {
                ViewBag.bucle = "For";
                for (int i = 0; i <= 10; i++)
                {
                    ViewBag.resultado = i.ToString();
                }
            } else if (opcion == 3)
            {
                ViewBag.bucle = "Do-While";

                do
                {
                    ViewBag.resultado = contador.ToString();
                    contador++;
                }
                while (contador <= 10);
            } else
            {
                ViewBag.resultado = "Debe ingresar un número dentro del rango";
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
