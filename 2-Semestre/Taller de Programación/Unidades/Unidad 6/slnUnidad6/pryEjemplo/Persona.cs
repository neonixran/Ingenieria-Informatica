using System;
using System.Collections.Generic;
using System.Text;

namespace pryEjemplo
{
    internal class Persona
    {
        // Estos son atributos de la clase Persona, se usa get para obtener los datos y set para modificar datos.
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public int Edad { get; set; }

        // Método?
        public bool esMayor()
        {
            return (Edad >= 18);
        }
    }
}
