using Microsoft.AspNetCore.Mvc;
using pryDecimas.Models;
using System.Diagnostics;

namespace pryDecimas.Controllers
{
    public class HomeController : Controller
    {
        // Asignatura
        public IActionResult Asignatura()
        {
            return View();
        }

        public string guardarAsignatura(string NOMBRE)
        {
            string respuesta = "";

            try
            {
                using (AlumnosContext bd = new AlumnosContext())
                {
                    var asignaturaExistente = bd.Asignaturas.FirstOrDefault(a => a.NomAsignatura.ToUpper() == NOMBRE.ToUpper()); // Convierte ambos a mayúsculas, esto para validar sin importar como se ingrese.

                    if (asignaturaExistente != null) // Validar si existe una asignatura con el nombre ingresado.
                    {
                        respuesta = "La asignatura ingresada ya existe.";
                    }
                    else // Si no existe, se agrega a la base de datos.
                    {
                        Asignatura asignatura = new Asignatura();
                        asignatura.NomAsignatura = NOMBRE;
                        // El idAsignatura no es necesario asignarlo, ya que es autoincremental y se asigna solo en la BD.

                        bd.Asignaturas.Add(asignatura);
                        bd.SaveChanges();

                        respuesta = "OK";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        public List<AsignaturaAux> cargarAsignaturas()
        {
            List<AsignaturaAux> listaAsignaturas = new List<AsignaturaAux>();

            try
            {
                using (AlumnosContext bd = new AlumnosContext())
                {
                    /* Query:
                     * SELECT a.IdAsignatura, a.NomAsignatura
                     * FROM Asignaturas a
                     */

                    var query = from a in bd.Asignaturas
                                select new
                                {
                                    a.IdAsignatura,
                                    a.NomAsignatura
                                };

                    foreach (var item in query)
                    {
                        listaAsignaturas.Add(new AsignaturaAux
                        {
                            id = item.IdAsignatura.ToString(),
                            nombre = item.NomAsignatura,
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<AsignaturaAux>
                {
                    new AsignaturaAux
                    {
                        estado = ex.Message
                    }
                };
            }

            return listaAsignaturas;
        }

        // Alumno
        public IActionResult Alumno()
        {
            return View();
        }

        public string guardarAlumno(int CODIGO, string NOMBRES, string APELLIDOS)
        {
            string respuesta = "";

            try
            {
                using (AlumnosContext bd = new AlumnosContext())
                {
                    var alumnoExistente = bd.Alumnos.FirstOrDefault(a => a.CodAlumno == CODIGO);
                    
                    if (alumnoExistente != null) // Validar si existe un alumno con el código ingresado
                    {
                        respuesta = "El código ingresado ya existe";
                    } else // Si no existe, se agrega a la base de datos
                    {
                        Alumno alumno = new Alumno();
                        alumno.CodAlumno = CODIGO;
                        alumno.Nombres = NOMBRES;
                        alumno.Apellidos = APELLIDOS;

                        bd.Alumnos.Add(alumno);
                        bd.SaveChanges();

                        respuesta = "OK";
                    }
                }
            } catch(Exception ex) {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        public List<AlumnoAux> cargarAlumnos()
        {
            List<AlumnoAux> listaAlumnos = new List<AlumnoAux>();   

            try
            {
                using (AlumnosContext bd = new AlumnosContext())
                {
                    /* Query:
                     * SELECT a.CodAlumno, a.Nombres, a.Apellidos
                     * FROM Alumnos a
                     */
                    var query = from a in bd.Alumnos
                                select new
                                {
                                    a.CodAlumno,
                                    a.Nombres,
                                    a.Apellidos
                                };

                    foreach (var item in query)
                    {
                        listaAlumnos.Add(new AlumnoAux
                        {
                            codigo = item.CodAlumno,
                            nombres = item.Nombres,
                            apellidos = item.Apellidos
                        });
                    }
                }
            } catch (Exception ex) {
                return new List<AlumnoAux>
                {
                    new AlumnoAux
                    {
                        estado = ex.Message
                    }
                };
            }

            return listaAlumnos;
        }

        // Notas
        public IActionResult Notas()
        {
            return View();
        }

        public string guardarNota(int ASIGNATURA, int ALUMNO, int TIPONOTA, decimal NOTA)
        {
            string respuesta = "";
            Console.WriteLine(NOTA);
            try
            {
                using (AlumnosContext bd = new AlumnosContext()) 
                {
                    var notaExistente = bd.Notas.FirstOrDefault(n => n.CodAlumno == ALUMNO && n.IdAsignatura == ASIGNATURA && n.NNota == TIPONOTA); // Valida si el código de alumno, la asignatura y el tipo de nota son los ingresados para poder modificar la nota en caso de que exista.
                    
                    if (notaExistente != null) // Validar si existe un alumno con el tipo de nota seleccionada. Si existe, edita la nota.
                    {
                        notaExistente.Nota1 = NOTA / 10m;
                    } else // Si la nota no existe, se agrega a la BD.
                    {
                        Nota nota = new Nota();
                        nota.IdAsignatura = ASIGNATURA;
                        nota.CodAlumno = ALUMNO;
                        nota.NNota = TIPONOTA;
                        nota.Nota1 = NOTA / 10m;

                        bd.Notas.Add(nota);
                    }

                    bd.SaveChanges();

                    respuesta = "OK";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.InnerException?.Message ?? ex.Message;
            }

            return respuesta;
        }

        public List<NotasAux> cargarNotas()
        {
            List<NotasAux> listaNotas = new List<NotasAux>();

            try
            {
                using (AlumnosContext bd = new AlumnosContext())
                {
                    /*
                     * SELECT
                     *      a.NOM_ASIGNATURA AS asignatura,
                     *      al.NOMBRES + ' ' + al.APELLIDOS AS alumno,
                     *      MAX(CASE WHEN n.N_NOTA = 1 THEN n.NOTA END) AS nota1, -- Da lo mismo el MAX, es para no incluirlo en la agrupación.
                     *      MAX(CASE WHEN n.N_NOTA = 2 THEN n.NOTA END) AS nota2,
                     *      MAX(CASE WHEN n.N_NOTA = 3 THEN n.NOTA END) AS nota3
                     * FROM NOTAS n
                     *      JOIN ASIGNATURA a ON(n.ID_ASIGNATURA = a.ID_ASIGNATURA)
                     *      JOIN ALUMNO al ON(n.COD_ALUMNO = al.COD_ALUMNO)
                     * GROUP BY n.COD_ALUMNO, n.ID_ASIGNATURA, A.NOM_ASIGNATURA, al.NOMBRES, al.APELLIDOS 
                     */
                    var query = from n in bd.Notas
                                join al in bd.Alumnos on n.CodAlumno equals al.CodAlumno
                                join a in bd.Asignaturas on n.IdAsignatura equals a.IdAsignatura
                                group new { n, al, a } by new { n.CodAlumno, n.IdAsignatura } into g
                                select new
                                {
                                    asignatura = g.First().a.NomAsignatura,
                                    alumno = g.First().al.Nombres + " " + g.First().al.Apellidos,
                                    nota1 = g.Where(x => x.n.NNota == 1).Select(x => x.n.Nota1).FirstOrDefault(),
                                    nota2 = g.Where(x => x.n.NNota == 2).Select(x => x.n.Nota1).FirstOrDefault(),
                                    nota3 = g.Where(x => x.n.NNota == 3).Select(x => x.n.Nota1).FirstOrDefault()
                                };


                    foreach (var item in query)
                    {
                        listaNotas.Add(new NotasAux
                        {
                            asignatura = item.asignatura,
                            alumno = item.alumno,
                            nota1 = (item.nota1).ToString() ?? "", // Si la nota es nula, se muestra un string vacío simplemente.
                            nota2 = (item.nota2).ToString() ?? "",
                            nota3 = (item.nota3).ToString() ?? "",
                            promedio = Math.Round(((item.nota1 ?? 0) + (item.nota2 ?? 0) + (item.nota3 ?? 0)) / 3, 2) // Redondea el promedio a 2 decimales, si es nulo lo reemplaza por un 0.
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<NotasAux>
                {
                    new NotasAux
                    {
                        estado = ex.Message
                    }
                };
            }

            return listaNotas;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
