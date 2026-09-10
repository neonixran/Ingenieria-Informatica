using System.Diagnostics;
using EjerciciosJS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjerciciosJS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static List<Datos> listado = new List<Datos>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<Datos> validaDatos(string DATO, int DATO2)
        {
            listado.Add(new Datos {
                dato1 = DATO,
                dato2 = DATO2
            });

            return listado;
        }

        public List<Datos> recargaDatos()
        {
            return listado;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
