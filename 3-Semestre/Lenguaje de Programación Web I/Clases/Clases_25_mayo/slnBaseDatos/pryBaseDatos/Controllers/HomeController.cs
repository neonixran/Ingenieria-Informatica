using Microsoft.AspNetCore.Mvc;
using pryBaseDatos.Models;
using System.Diagnostics;

namespace pryBaseDatos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            insertarUsuario();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private void insertarUsuario()
        {
            try
            {
                using (EjercicioContext bd = new EjercicioContext())
                {
                    bd.Usuarios.Add(new Usuario()
                    {
                        NomUsuario = "ADMIN",
                        Password = "ADMIN"
                    });
                    bd.SaveChanges();

                    bd.Usuarios.Where(p => p.NomUsuario == "ADMIN");
                    bd.Usuarios.Remove(new Usuario()
                    {
                        
                    });
                    bd.SaveChanges();
                }
            } catch(Exception ex)
            {

            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
