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
        
        public IActionResult calcularPies(String centimetros)
       {
            try {
                double cm = Convert.ToDouble(centimetros);
                double pies = cm / 30.48;

                ViewBag.resultado = String.Format("{0} cm son {1} pies", cm, Math.Round(pies, 2));
            } catch(Exception ex)
            {
                ViewBag.resultado = ex.Message;
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
