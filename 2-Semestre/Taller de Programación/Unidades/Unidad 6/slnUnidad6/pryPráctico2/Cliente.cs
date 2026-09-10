using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPráctico2
{
    internal class Cliente
    {
        private string _nombre;

        public string Nombre
        {
            get
            { return _nombre; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("El nombre no puede estar vacío");
                }

                _nombre = value;
            }
        }

        private string _apellido;

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("El apellido no puede ser muy largo");
                }

                _apellido = value;
            }
        }

        public string Calle { get; set; }

        private int _número;
        public int Número
        {
            get
            { return _número; }
            set
            { _número = value; }
        }
    }
}
