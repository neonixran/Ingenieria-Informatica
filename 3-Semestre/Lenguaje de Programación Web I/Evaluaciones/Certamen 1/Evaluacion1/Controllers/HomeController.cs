using Evaluacion1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evaluacion1.Controllers
{
    public class HomeController : Controller
    {
        static List<Datos> listado = new List<Datos>();

        public IActionResult Ingreso()
        {
            ViewBag.respuesta = listado;
            return View();
        }

        public IActionResult IngresoAlumno(string txtNombres, string txtApellidos, string txtRut, string txtId, string txtFecha) {
            var alumno = listado.Find(x => String.Format("{0}-{1}", x.rut, x.rutId) == String.Format("{0}-{1}", txtRut, txtId));
         
            if (alumno == null) // El RUT de un alumno no puede repetirse.
            {
                listado.Add(new Datos()
                {
                    rut = txtRut,
                    rutId = txtId,
                    nombre = String.Format("{0} {1}", txtNombres, txtApellidos), // En la columna Nombre completo deberá aparecer Nombres y Apellidos concatenados.
                    fechaNacimiento = txtFecha
                });
            }

            ViewBag.respuesta = listado;

            return View("Ingreso");
        }

        public IActionResult Notas(string txtEditarNombre, string txtEditarRut, string txtEditatRutId, string txtEditarNota)
        {
            ViewBag.nombreCompleto = txtEditarNombre;
            ViewBag.rut = txtEditarRut;
            ViewBag.rutId = txtEditatRutId;
            ViewBag.notaFinal = txtEditarNota;
            return View();
        }

        public IActionResult IngresoNotas(string txtRutNota, string txtNombreNota, string txtIdNota, string txtNota) {
            var editaNota = listado.Find(x => String.Format("{0}-{1}", x.rut, x.rutId) == String.Format("{0}-{1}", txtRutNota, txtIdNota));
            editaNota.notaFinal = txtNota;

            double notaEditada = Convert.ToDouble(txtNota);

            if (notaEditada < 1.0 || notaEditada > 7.0)
            {
                ViewBag.mensaje = "Nota fuera de rango";

                ViewBag.nombreCompleto = txtNombreNota;
                ViewBag.rut = txtRutNota;
                ViewBag.rutId = txtIdNota;
                ViewBag.notaFinal = txtNota;

                return View("Notas");
            }

            editaNota.estado = notaEditada < 4.0 ? "REPROBADO" : "APROBADO"; // En la columna Estado debe aparecer si el alumno está REPROBADO (Nota inferior a 4.0) o APROBADO(Nota igual o superior a 4.0), en caso de no poseer nota no debe aparecer nada.

            ViewBag.respuesta = listado;

            return View("Ingreso");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
