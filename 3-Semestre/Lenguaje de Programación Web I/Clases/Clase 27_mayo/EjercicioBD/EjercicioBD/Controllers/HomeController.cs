using System.Diagnostics;
using EjercicioBD.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioBD.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        public string insertarUsuario(string USR, string PASS, string NOM, string APE, int RUT, string DV)
        {
            var respuesta = "";
            try
            {
                using (EjercicioContext bd = new EjercicioContext())
                {
                    Usuario usuario = new Usuario();
                    usuario.NomUsuario = USR;
                    usuario.Password = PASS;

                    Persona persona = new Persona();
                    persona.Rut = RUT;
                    persona.Dv = DV;
                    persona.Nombres = NOM;
                    persona.Apellidos = APE;
                    persona.NomUsuario = USR;

                    bd.Usuarios.Add(usuario);
                    bd.Personas.Add(persona);
                    bd.SaveChanges();

                    respuesta = "OK";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;

            }
            return respuesta;
        }

        public List<DATOS> cargaUsuario()
        {
            List<DATOS> listado = new List<DATOS>();

            try
            {
                using (EjercicioContext bd = new EjercicioContext())
                {
                    var query = from u in bd.Usuarios
                                join p in bd.Personas on u.NomUsuario equals p.NomUsuario
                                select new
                                {
                                    u.NomUsuario,
                                    p.Rut,
                                    p.Dv,
                                    p.Nombres,
                                    p.Apellidos
                                };

                    foreach (var item in query)
                    {
                        listado.Add(new DATOS
                        {
                            usuario_ = item.NomUsuario,
                            rut_formateado = item.Rut + "-" + item.Dv,
                            nombre_completo = item.Nombres + " " + item.Apellidos
                        });
                    }
                }
            } catch (Exception ex)
            {
               
            }

            return listado;
        }

        public string ingresar(string USR, string PASS)
        {
            string respuesta = "";
            try
            {
                using (EjercicioContext bd = new EjercicioContext())
                {
                    var resultado = bd.Usuarios.FirstOrDefault(u => u.NomUsuario == USR);

                    if (resultado == null)
                    {
                        respuesta = "Usuario no encontrado";
                    } else if (resultado.Password != PASS)
                    {
                        respuesta = "Contraseña incorrecta";
                    } else
                    {
                        respuesta = "OK";
                    }
                }
            } catch(Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
