using Evaluacion1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace Evaluacion1.Controllers
{
    public class HomeController : Controller
    {
        static List<Productos> productos = new List<Productos>(); // Lista de productos, se mostrará en la pantalla de productos
        static List<Ventas> ventas = new List<Ventas>(); // Lista de ventas, se mostrará en la pantalla de ventas

        // Ingreso
        public IActionResult Ingreso() // Hace de función "cargarProductos"
        {
            ViewBag.listadoProd = productos; // Al cargar la página (vista) de "Ingreso", carga la lista de productos.
            return View(); // Carga la página (vista) de Ingreso.
        }

        public IActionResult IngresoProducto(int txtCodigo, string txtNombre, int txtPrecio, int txtStock) // Trae los campos desde el formulario.
        {
            if (txtCodigo.ToString() != "" && txtNombre != "" && txtPrecio.ToString() != "" && txtStock.ToString() != "") // Validar si los campos no están vacíos.
            {
                var productoExistente = productos.Find(x => x.codigo == txtCodigo); // Validar si en la lista de productos hay algún producto con el código ingresado.

                if (productoExistente == null) // Si no hay ningún producto con el código ingresado, se agrega a la lista de productos.
                {
                    productos.Add(new Productos()
                    {
                        codigo = txtCodigo,
                        nombre = txtNombre,
                        precio = txtPrecio,
                        stock = txtStock
                    }); // guarda en la lista de productos el nuevo producto.
                }
            }

            ViewBag.listadoProd = productos; // Con un ViewBag se guarda la lista de productos.

            return View("Ingreso"); // recarga la página (vista) de "Ingreso", esto para mostrar los cambios.
        }

        // Venta
        public IActionResult Venta() // Hace de función "cargarVentas"
        {
            ViewBag.listadoVentas = ventas; // Al cargar la página (vista) de "Ventas", carga la lista de ventas.
            return View(); // Carga la página (vista) de Venta.
        }

        private int idVenta = 1; // Variable para almacenar el id de venta.
        public IActionResult IngresoVenta(int txtCodigo, int txtCantidad) // Trae los campos desde el formulario.
        {
            if (txtCodigo.ToString() != "" && txtCantidad.ToString() != "") // Validar si los campos no están vacíos.
            {
                var productoSeleccionado = productos.Find(x => x.codigo == txtCodigo); // Validar si en la lista de productos hay algún producto con el código ingresado.

                if (productoSeleccionado != null) // Si el producto existe....
                {
                    if (txtCantidad > 0) // Si la cantidad ingresada es mayor a 0.
                    {
                        if (txtCantidad <= productoSeleccionado.stock) // Si la cantidad ingresada es menor o igual al stock disponible.
                        {
                            ventas.Add(new Ventas()
                            {
                                id = idVenta, // ID generado automáticamente usando idVenta.
                                codigoProd = productoSeleccionado.codigo,
                                nombreProd = productoSeleccionado.nombre,
                                cantidad = txtCantidad,
                                total = productoSeleccionado.precio * txtCantidad, // Multiplica el precio del producto seleccionado por la cantidad ingresada.
                                fecha = DateTime.Now.ToString() // Obtiene automáticamente la fecha y hora actuales.
                            }); // Guarda en la lista de ventas la nueva venta.

                            idVenta++; // Va sumando 1 cada vez que se crea una nueva venta.
                        }
                    }
                }
            }
            
            ViewBag.listadoVentas = ventas; // Con un ViewBag se guarda la lista de ventas.

            return View("Venta"); // Recarga la página (vista) de "Venta", esto para mostrar los cambios nuevos.
        }

        // Stock
        public IActionResult Stock(string txtEditarCodigo, string txtEditarNombre, string txtEditarStock) // Trae los campos desde el formulario, estos se guardan en etiquetas input de tipo "hidden". 
        {
            // Guarda los datos del formulario en ViewBags.
            ViewBag.codigoProd = txtEditarCodigo;
            ViewBag.nombreProd = txtEditarNombre;
            ViewBag.stockProd = txtEditarStock;

            return View(); // Carga la página (vista) de Stock.
        }

        public IActionResult IngresoStock(int txtCodigo, string txtNombre, int txtStock) // Trae los campos desde el formulario.
        {
            var productoSeleccionado = productos.Find(x => x.codigo == txtCodigo); // Verificar si en la lista de productos existe un producto con el código ingresado.

            if (txtStock < 1) // Verifica si el stock es menor a 1.
            {
                ViewBag.codigoProd = txtCodigo.ToString();
                ViewBag.nombreProd = txtNombre;
                ViewBag.stockProd = txtStock.ToString();

                return View("Stock"); // Recarga la página de Stock mostrando los mismos datos para no perderlos.
            }

            productoSeleccionado?.stock = txtStock; // Edita el stock del producto seleccionado con el nuevo stock ingresado.

            ViewBag.listadoProd = productos; // Con un ViewBag se guarda la lista de productos.

            return View("Ingreso"); // Retorna a la página de "Ingreso", mostrando el nuevo stock actualizado.
        }
    }
}
