using Microsoft.AspNetCore.Mvc;
using pryEvaluacion2.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryEvaluacion2.Controllers
{
    public class HomeController : Controller
    {
        static List<Conductor> listaConductores = new List<Conductor>();

        List<Conductor> conductoresFiltrados = new List<Conductor>();

        static List<Camion> listaCamiones = new List<Camion>();

        static List<Salida> listaSalidas = new List<Salida>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Conductor
        public IActionResult Conductor() // Pantalla "Conductores"
        {
            return View();
        }

        public bool guardarConductor(string Nombre, int Id, string TipoCamion) // Función para guardar a un conductor.
        {
            var buscarConductor = listaConductores.Find(x => x.id == Id); // Buscar si hay un conductor con la id que se ingreso.
            
            if (buscarConductor != null)
            {
                return false;
            }

            listaConductores.Add(new Conductor
            {
                id = Id,
                nombre = Nombre,
                tipoCamion = TipoCamion
            });

            cargarConductores();

            return true;
        }

        public List<Conductor> cargarConductores() // Función para retornar la lista de conductores.
        {
            return listaConductores;
        }

        // Camión
        public IActionResult Camion() // Pantalla "Camiones"
        {
            return View();
        }

        public bool guardarCamion(string Patente, string TipoCamion) // Función para guardar un camión
        {
            string patenteFormateada = Patente.ToUpper(); // Formatear la patente para usarla con mayúsculas.
            var buscarPatente = listaCamiones.Find(x => x.patente == patenteFormateada); // Buscar si hay una patente con la patente ingresada.

            if (buscarPatente != null)
            {
                return false;
            }

            listaCamiones.Add(new Camion
            {
                patente = patenteFormateada,
                tipoCamion = TipoCamion
            });

            cargarConductores();

            return true;
        }

        public List<Camion> cargarCamiones() // Función para retornar la lista de camiones.
        {
            return listaCamiones;
        }

        // Salida
        public IActionResult Salida() // Pantalla "Salidas"
        {
            return View();
        }

        static int contadorId = 1; // Contador para asignar la id automaticamente.
        public void guardarSalida(string Patente, string Conductor, int ConductorId, string TipoCarga, string FechaHora) // Función para guardar las salidas.
        {
            listaSalidas.Add(new Salida
            {
                id = contadorId,
                patenteCamion = Patente,
                nombreConductor = Conductor,
                idConductor = ConductorId,
                tipoCarga = TipoCarga,
                fechaHora = DateTime.Parse(FechaHora).ToString("dd-MM-yyyy HH:mm"), // Formatear fecha
                estado = "En ruta",
            });

            cargarSalidas();

            contadorId++;
        }

        public List<Salida> cargarSalidas() // Función para retornar la lista de salidas.
        {
            return listaSalidas;
        }

        public List<Conductor> cargarConductoresFiltrados(string TipoCamion) // Función para retornar los conductores filtrados, según su tipo de camión y los que no están en ruta.
        {
            var conductoresEnRuta = listaSalidas.Where(s => s.estado == "En ruta").Select(s => s.idConductor); // Buscar y seleccionar solo los conductores que estén en ruta.
            var datos = listaConductores.Where(r => r.tipoCamion == TipoCamion && !conductoresEnRuta.Contains(r.id));

            foreach (var item in datos)
            {
                conductoresFiltrados.Add(new Conductor
                {
                    id = item.id,
                    nombre = item.nombre,
                    tipoCamion = TipoCamion
                });
            }

            return conductoresFiltrados;
        }

        public IActionResult cambiarEstado(string txtId) // Función para cambiar el estado del camión
        {
            var datos = listaSalidas.Find(s => s.id.ToString() == txtId);

            if (datos != null)
            {
                datos.estado = "Retorno";
            }

            return View("Salida");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
