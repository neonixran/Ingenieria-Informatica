using Actividad_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Actividad_1.Controllers
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

        public IActionResult Calcular(int? num1, int? num2, int? num3)
        {
            Datos datos = new Datos()
            {
                num1_ = num1.ToString(),
                num2_ = num2.ToString(),
                num3_ = num3.ToString(),
            };

            if (num1 == null && num2 == null && num3 == null)
            {
                // Si los tres campos se encuentran vacíos, deberá enviar un mensaje que diga "Los tres campos no pueden estar vacíos"

                ViewBag.respuesta = "Los tres campos no pueden estar vacíos.";

                // Si alguno de los campos no fue ingresado, el campo en la grilla se muestra vació.

                datos.operacion_ = "";
                datos.resultado_ = 0; // Relleno con estos para poder mostrar los campos de la tabla vacios.
            } else if (num1 != null && num2 == null && num3 == null)
            {
                // Si solo el primer campo no está vacío, se deberá multiplicar ese valor por dos.

                datos.operacion_ = String.Format("{0} * 2", num1);
                datos.resultado_ = num1 * 2;
            } else if (num2 != null && num1 == null && num3 == null)
            {
                // Si solo el segundo campo no está vacío, deberá restarle el número 10.

                datos.operacion_ = String.Format("{0} - 10", num2);
                datos.resultado_ = num2 - 10;
            } else if (num3 != null && num1 == null && num2 == null) {
                // Si solo el tercer campo no está vacío, deberá dividir el campo por tres.

                datos.operacion_ = String.Format("{0} / 3", num3);
                datos.resultado_ = num3 / 3;
            } else if (num3 == null && num1 != null && num2 != null)
            {
                // Si el tercer campo es el único vacío, el primer valor con el segundo se deberán multiplicar.

                datos.operacion_ = String.Format("{0} * {1}", num1, num2);
                datos.resultado_ = num1 * num2;
            } else if (num2 == null && num1 != null && num3 != null)
            {
                // Si solo el segundo campo está vacío, el primer valor con el tercer valor se deberán dividir.

                datos.operacion_ = String.Format("{0} / {1}", num1, num3);
                datos.resultado_ = num1 / num3;
            } else if (num1 == null && num2 != null && num3 != null)
            {
                // Si solo el primer campo está vacío, el segundo valor con el tercer valor deberán restarse.

                datos.operacion_ = String.Format("{0} - {1}", num2, num3);
                datos.resultado_ = num2 - num3;
            } else
            {
                // Si ninguno se encuentra vacío, deberá sumar el primero con el segundo luego multiplicarlo por dos y dividir ese resultado por el tercero.

                datos.operacion_ = String.Format("(({0} + {1}) * 2) / {2}", num1, num2, num3);
                datos.resultado_ = ((num1 + num2) * 2) / num3;
            }

            listado.Add(datos);

            ViewBag.listado = listado;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
