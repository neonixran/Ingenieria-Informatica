using Microsoft.AspNetCore.Mvc;
using pryTrabajo.Models;
using System.Diagnostics;

namespace pryTrabajo.Controllers
{
    public class HomeController : Controller
    {
        static List<Datos> listado = new List<Datos>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Ejercicio 1
        public IActionResult Ejercicio1()
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
                }
                else if (Minutos <= 25)
                {
                    ViewBag.mensaje = "Su tarifa es de $1850 pesos";
                }
                else
                {
                    int minutoAdicional = Minutos - 25;
                    double tarifa = 1850 + (minutoAdicional * 23);

                    ViewBag.mensaje = String.Format("Su tarifa es de {0:C} pesos", tarifa);
                }
            }
            else
            {
                ViewBag.mensaje = "Debe ingresar los minutos para poder calcular la tarifa";
            }

            return View("Ejercicio1");
        }

        // Ejercicio 2
        public IActionResult Ejercicio2()
        {
            return View();
        }

        public IActionResult calcularVelocidad(String distancia, String tiempo)
        {
            if (distancia != null || tiempo != null)
            {
                decimal Km = decimal.Parse(distancia) / 1000;
                decimal Horas = decimal.Parse(tiempo) / 3600;

                ViewBag.mensaje = String.Format("La velocidad promedio es de {0} km/h", Math.Round(Km / Horas, 2));

            } else {
                ViewBag.mensaje = "Debe ingresar los datos requeridos para poder calcular la velocidad";
            }

            return View("Ejercicio2");
        }

        // Ejercicio 3
        public IActionResult Ejercicio3()
        {
            return View();
        }

        public IActionResult calcularNumero(int numero)
        {
            if (numero != null)
            {
                listado.Add(new Datos()
                {
                    numero_ = numero,
                    resultado_ = numero < 50 ? numero * 3 : numero / 4
                });

                ViewBag.listado = listado;
            }

            return View("Ejercicio3");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
