using EjercicioCompleto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioCompleto.Controllers
{
    public class HomeController : Controller
    {
        static List<Datos> listado = new List<Datos>();
        //llamada a la vista Index (Inicio sesión)
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult validar(string txtUsuario, string txtContraseña)
        {
            if (txtUsuario != null && txtContraseña != null)
            {
                var datos = listado.Find(x => x.usuario_ == txtUsuario);
                
                if (datos == null)
                {
                    ViewBag.respuesta = "Usuario no encontrado";
                } else if (datos.contraseña_ != txtContraseña)
                {
                    ViewBag.respuesta = "Contraseña incorrecta";
                } else if (datos.habilitado_ != "on")
                {
                    ViewBag.respuesta = "Usuario no habilitado";
                } else
                {
                    ViewBag.respuesta = "usuario: " + txtUsuario;
                }
            }
            else
            {
                ViewBag.respuesta = "usuario vacio";
            }

            return View("Index");
        }
        //llamada a la vista Agregar
        public IActionResult Agregar()
        {
            ViewBag.respuesta = listado;
            return View();
        }
        //Añade un usuario nuevo a la lista
        public IActionResult Nuevo(string txtUsuarioNuevo, string txtContraseñaNuevo, string chkHabilitado)
        {
            listado.Add(new Datos()
            {
                usuario_ = txtUsuarioNuevo,
                contraseña_ = txtContraseñaNuevo,
                habilitado_ = chkHabilitado
            });

            ViewBag.respuesta = listado;
            return View("Agregar");
        }
        //Al presionar el boton Editar en la pantalla Agregar, se envian los datos que luego muestra en la pantalla,
        //el usuario cumple el rol de indentificador por lo cual no puede ser editado
        public IActionResult Editar(string txtEditarUsuario, string txtEditarContraseña, string chkEditarHabilitado)
        {
            ViewBag.UsuarioEditado = txtEditarUsuario;
            ViewBag.ContraseñaEditado = txtEditarContraseña;
            if (chkEditarHabilitado=="on")
            {
                ViewBag.HabilitadoEditado = "checked";
            }
            else
            {
                ViewBag.HabilitadoEditado = "";
            }
            
            return View();
        }
        //Al presionar el boton Editar registro, modifica los datos de la lista en base al usuario
        public IActionResult EditarDatos(string txtUsuarioNuevo, string txtContraseñaNuevo, string chkHabilitadoNuevo)
        {
            //aqui editamos
            var editaDatos = listado.Find(x => x.usuario_ == txtUsuarioNuevo);
            editaDatos.contraseña_ = txtContraseñaNuevo;
            editaDatos.habilitado_ = chkHabilitadoNuevo;

            ViewBag.respuesta = listado;
            return View("Agregar");
        }
        //llamada a la vista Eliminar
        public IActionResult Eliminar(string txtUsuarioEliminar)
        {
            ViewBag.datoUsuario = txtUsuarioEliminar;
            return View();
        }
        //si se presiona cancelar en la pantalla Eliminar vuelve a la pantalla Agregar
        public IActionResult confirmaVolver() {
            ViewBag.respuesta = listado;
            return View("Agregar");
        }
        //si se presiona confirmar en la pantalla Eliminar vuelve a la pantalla Agregar luego de eliminar el registro de la lista
        public IActionResult confirmaEliminar(string txtUsuarioDatoEliminar)
        {
            //aqui eliminamos
            var eliminaDatos = listado.Find(x => x.usuario_ == txtUsuarioDatoEliminar);
            listado.Remove(eliminaDatos);

            ViewBag.respuesta = listado;
            return View("Agregar");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
