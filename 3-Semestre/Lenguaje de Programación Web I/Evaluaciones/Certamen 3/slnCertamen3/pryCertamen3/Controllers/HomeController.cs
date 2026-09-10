using Microsoft.AspNetCore.Mvc;
using pryCertamen3.Models;
using System.Diagnostics;

namespace pryCertamen3.Controllers
{
    public class HomeController : Controller
    {
        static Usuario? usuarioActual = null;
        // Layout?
        public string? obtenerSesion()
        {
            return usuarioActual?.NomPersona;
        }

        public string cerrarSesion()
        {
            string respuesta = "";

            if (usuarioActual != null)
            {
                usuarioActual = null;
                respuesta = "OK";
            } else
            {
                respuesta = "Ocurrió un error al cerrar sesión";
            }

            return respuesta;
        }

        // Pantalla "Inicio Sesión"
        public IActionResult InicioSesion()
        {
            return View();
        }

        public string iniciarSesion(string USUARIO, string CONTRASEÑA)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var usuario = bd.Usuarios.FirstOrDefault(u => u.Usuario1.Equals(USUARIO) && u.Password.Equals(CONTRASEÑA));

                    if (usuario == null)
                    {
                        respuesta = "Usuario no se encuentra en el sistema";
                    } else
                    {
                        if (usuario.IdEstado == 2) // [1: Habilitado; 2: Deshabilitado]
                        {
                            respuesta = "El usuario se encuentra deshabilitado";
                        } else
                        {
                            usuarioActual = usuario;
                            respuesta = "OK";
                        }
                    }
                }
            } catch(Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        // Pantalla "Usuarios"
        public IActionResult Usuarios()
        {
            if (usuarioActual != null)
            {
                return View();
            }

            return View("InicioSesion");
        }

        public string registrarUsuario(string USUARIO, string NOMBRE, int IDESTADO, string CONTRASEÑA)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var nuevoUsuario = bd.Usuarios.FirstOrDefault(u => u.Usuario1 == USUARIO);

                    if (nuevoUsuario == null)
                    {
                        Usuario usuario = new Usuario();
                        usuario.Usuario1 = USUARIO;
                        usuario.NomPersona = NOMBRE;
                        usuario.Password = CONTRASEÑA;
                        usuario.IdEstado = IDESTADO;

                        bd.Usuarios.Add(usuario);
                        bd.SaveChanges();

                        respuesta = "OK";
                    }
                    else
                    {
                        respuesta = "El usuario ingresado ya se encuentra registrado";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        public string editarUsuario(string USUARIO, string NOMBRE, int IDESTADO, string CONTRASEÑA)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var editarUsuario = bd.Usuarios.FirstOrDefault(u => u.Usuario1 == USUARIO);

                    if (editarUsuario != null)
                    {
                        editarUsuario.NomPersona = NOMBRE;
                        editarUsuario.IdEstado = IDESTADO;
                        editarUsuario.Password = CONTRASEÑA;

                        bd.Usuarios.Update(editarUsuario);
                        bd.SaveChanges();

                        respuesta = "OK";
                    } else
                    {
                        respuesta = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        public List<UsuarioAux> cargarUsuarios()
        {
            List<UsuarioAux> listaUsuarios = new List<UsuarioAux>();

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var query = from u in bd.Usuarios
                                select new
                                {
                                    u.Usuario1,
                                    u.NomPersona,
                                    u.IdEstado
                                };

                    foreach (var item in query)
                    {
                        listaUsuarios.Add(new UsuarioAux
                        {
                            usuario = item.Usuario1,
                            nombre = item.NomPersona,
                            estado = item.IdEstado
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<UsuarioAux>
                {
                    new UsuarioAux
                    {
                        respuesta = ex.Message
                    }
                };
            }

            return listaUsuarios;
        }
        
        // Pantalla "Chofer"
        public IActionResult Chofer()
        {
            if (usuarioActual != null)
            {
                return View();
            }

            return View("InicioSesion");
        }

        public string registrarChofer(string NOMBRE, int IDESTADO)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    Chofer chofer = new Chofer();
                    chofer.NomChofer = NOMBRE;
                    chofer.IdEstado = IDESTADO;

                    bd.Chofers.Add(chofer);
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

        public string editarChofer(int ID, string NOMBRE, int IDESTADO)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var editarChofer = bd.Chofers.FirstOrDefault(c => c.IdChofer == ID);

                    if (editarChofer != null)
                    {
                        editarChofer.NomChofer = NOMBRE;
                        editarChofer.IdEstado = IDESTADO;

                        bd.Chofers.Update(editarChofer);
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

        public List<ChoferAux> cargarChoferes()
        {
            List<ChoferAux> listaChoferes = new List<ChoferAux>();

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var query = from c in bd.Chofers
                                select new
                                {
                                    c.IdChofer,
                                    c.NomChofer,
                                    c.IdEstado
                                };

                    foreach (var item in query)
                    {
                        listaChoferes.Add(new ChoferAux
                        {
                            id = item.IdChofer,
                            nombre = item.NomChofer,
                            estado = item.IdEstado
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<ChoferAux>
                {
                    new ChoferAux
                    {
                        respuesta = ex.Message
                    }
                };
            }

            return listaChoferes;
        }

        // Pantalla "Camión"
        public IActionResult Camión()
        {
            if (usuarioActual != null)
            {
                return View();
            }

            return View("InicioSesion");
        }

        public string registrarCamion(string CODIGO, int PLANTA, int IDESTADO)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var camionExistente = bd.Camions.FirstOrDefault(c => c.CodCamion == CODIGO);

                    if (camionExistente == null)
                    {
                        Camion camion = new Camion();
                        camion.CodCamion = CODIGO;
                        camion.IdPlanta = PLANTA;
                        camion.IdEstado = IDESTADO;

                        bd.Camions.Add(camion);
                        bd.SaveChanges();

                        respuesta = "OK";
                    } else
                    {
                        respuesta = "Código de camión ya en uso";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        public string cambiarEstado(string CODIGO, int IDESTADO)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var editarCamion = bd.Camions.FirstOrDefault(c => c.CodCamion == CODIGO);

                    if (editarCamion != null)
                    {
                        editarCamion.IdEstado = IDESTADO;

                        bd.Camions.Update(editarCamion);
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

        public List<CamionAux> cargarCamiones()
        {
            List<CamionAux> listaCamiones = new List<CamionAux>();

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var query = from c in bd.Camions
                                join p in bd.Planta on c.IdPlanta equals p.IdPlanta
                                select new
                                {
                                    c.CodCamion,
                                    p.NomPlanta,
                                    c.IdEstado
                                };

                    foreach (var item in query)
                    {
                        listaCamiones.Add(new CamionAux
                        {
                            codigo = item.CodCamion,
                            planta = item.NomPlanta,
                            estado = item.IdEstado
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<CamionAux>
                {
                    new CamionAux
                    {
                        respuesta = ex.Message
                    }
                };
            }

            return listaCamiones;
        }

        // Pantalla "Salida"
        public ActionResult Salida()
        {
            if (usuarioActual != null)
            {
                return View();
            }

            return View("InicioSesion");
        }

        public string registrarSalida(string FECHA, int IDPLANTA, string CODCAMION, int IDCHOFER)
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    Salidum salida = new Salidum();
                    salida.FechaSalida = DateOnly.Parse(FECHA);
                    salida.IdPlanta = IDPLANTA;
                    salida.CodCamion = CODCAMION;
                    salida.IdChofer = IDCHOFER;
                    salida.IdEstadoSalida = 1; // En ruta, por defecto
                    salida.Usuario = usuarioActual?.Usuario1;

                    bd.Salida.Add(salida);
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

        public string estadoSalida(int ID, int IDESTADO) // Funciona tanto para el botón de "Retornar" y "Rechazar", ya que ambos hacen la misma función.
        {
            string respuesta = "";

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var estadoSalida = bd.Salida.FirstOrDefault(s => s.IdSalida == ID);

                    if (estadoSalida != null)
                    {
                        estadoSalida.IdEstadoSalida = IDESTADO;

                        bd.Salida.Update(estadoSalida);
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

        public List<SalidaAux> cargarSalidas()
        {
            List<SalidaAux> listaSalidas = new List<SalidaAux>();

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var query = from u in bd.Usuarios
                                join s in bd.Salida on u.Usuario1 equals s.Usuario
                                join c in bd.Camions on s.CodCamion equals c.CodCamion
                                join p in bd.Planta on c.IdPlanta equals p.IdPlanta
                                join cf in bd.Chofers on s.IdChofer equals cf.IdChofer
                                join es in bd.EstadoSalida on s.IdEstadoSalida equals es.IdEstadoSalida
                                select new
                                {
                                    s.IdSalida,
                                    s.FechaSalida,
                                    p.NomPlanta,
                                    c.CodCamion,
                                    cf.NomChofer,
                                    es.NomEstadoSalida,
                                    es.IdEstadoSalida,
                                    u.NomPersona
                                };

                    foreach (var item in query)
                    {
                        listaSalidas.Add(new SalidaAux
                        {
                            id = item.IdSalida,
                            fecha = item.FechaSalida,
                            planta = item.NomPlanta,
                            codCamion = item.CodCamion,
                            chofer = item.NomChofer,
                            estado = item.NomEstadoSalida,
                            idEstado = item.IdEstadoSalida,
                            usuario = item.NomPersona
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<SalidaAux>
                {
                    new SalidaAux
                    {
                        respuesta = ex.Message
                    }
                };
            }   

            return listaSalidas;
        }

        public List<CamionAux> filtrarCamiones(string PLANTA)
        {
            List<CamionAux> listaCamiones = cargarCamiones();

            var camionesFiltrados = listaCamiones.Where(c => c.planta == PLANTA && c.estado == 1);

            return camionesFiltrados.ToList();
        }
        public List<ChoferAux> filtrarChoferes()
        {
            List<ChoferAux> listaChoferes = cargarChoferes();

            var choferesFiltrados = listaChoferes.Where(cf => cf.estado == 1);

            return choferesFiltrados.ToList();
        }

        // Funciones generales
        public List<PlantaAux> cargarPlantas() // carga desde la base de datos las plantas que haya.
        {
            List<PlantaAux> listaPlantas = new List<PlantaAux>();

            try
            {
                using (EvaluacionWeb691Context bd = new EvaluacionWeb691Context())
                {
                    var query = from p in bd.Planta
                                select new
                                {
                                    p.IdPlanta,
                                    p.NomPlanta
                                };

                    foreach (var item in query)
                    {
                        listaPlantas.Add(new PlantaAux
                        {
                            id = item.IdPlanta,
                            nombre = item.NomPlanta
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<PlantaAux>
                {
                    new PlantaAux
                    {
                        respuesta = ex.Message
                    }
                };
            }

            return listaPlantas;
        }

        // Error?
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
