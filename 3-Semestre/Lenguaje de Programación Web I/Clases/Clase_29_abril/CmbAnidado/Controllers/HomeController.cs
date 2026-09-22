using CmbAnidado.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CmbAnidado.Controllers
{
    public class HomeController : Controller
    {
        static List<PAIS> listaPais = new List<PAIS>();
        static List<REGION> listaRegion = new List<REGION>();
        List<REGION> regionFiltrada = new List<REGION>();
        static List<CIUDAD> listaCiudad = new List<CIUDAD>();
        List<CIUDAD> ciudadFiltrada = new List<CIUDAD>();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pais()
        {
            return View();
        }        
        public IActionResult Region()
        {
            return View();
        }
        public IActionResult Ciudad()
        {
            return View();
        }
        public void guardarPais(string PAIS)
        {
            int id = cargaIdPais();
            listaPais.Add(new PAIS { 
                idPais = id,
                nombrePais = PAIS            
            });
            cargaDatosPais();
        }

        public void guardarRegion(int PAIS, string REGION)
        {
            int id = cargaIdRegion();
            listaRegion.Add(new REGION
            {
                idRegion = id,
                nombreRegion = REGION,
                idPais = PAIS,
            });
        }

        public void guardarCiudad(int REGION, string CIUDAD)
        {
            int id = cargaIdCiudad();
            listaCiudad.Add(new CIUDAD
            {
                idCiudad = id,
                nombreCiudad = CIUDAD,
                idRegion = REGION
            });
        }

        public int cargaIdPais()
        {
            int id = listaPais.Max(x => (int?)x.idPais) ?? 0;
            id++;
            return id;
        }
        public int cargaIdRegion()
        {
            int id = listaRegion.Max(x => (int?)x.idRegion) ?? 0;
            id++;
            return id;
        }
        public int cargaIdCiudad()
        {
            int id = listaCiudad.Max(x => (int?)x.idCiudad) ?? 0;
            id++;
            return id;
        }
        public List<PAIS> cargaDatosPais()
        {
            return listaPais;
        }
        public List<REGION> cargaDatosRegion(int IDPAIS)
        {
            var datos = listaRegion.Where(p => p.idPais == IDPAIS);

            foreach (var item in datos)
            {
                regionFiltrada.Add(new REGION
                {
                    idRegion = item.idRegion,
                    nombreRegion = item.nombreRegion,
                    idPais = IDPAIS
                });
            }

            return regionFiltrada;
        }
        public List<CIUDAD> cargaDatosCiudad(int IDREGION)
        {
            var datos = listaCiudad.Where(r => r.idRegion == IDREGION);

            foreach (var item in datos)
            {
                ciudadFiltrada.Add(new CIUDAD
                {
                    idCiudad = item.idCiudad,
                    nombreCiudad = item.nombreCiudad,
                    idRegion = IDREGION
                });
            }

            return ciudadFiltrada;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
