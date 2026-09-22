using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPráctico4
{
    internal class Fracción
    {
        public int Numerador { get; set; }

        private int _denominador;
        public int Denominador
        {
            get { return _denominador; }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El denominador no puede ser cero.");
                }

                _denominador = value;
            }
        }

        private int calcularMCD(int a, int b)
        {
            int resto;

            do
            {
                resto = a % b;

                if (resto != 0)
                {
                    a = b;
                    b = resto;
                }
            } while (resto > 0);

            return b;
        }

        public void Simplificar()
        {
            int mcd = calcularMCD(Numerador, Denominador);
            Numerador /= mcd;
            Denominador /= mcd;
        }

        public Fracción() { }
        public Fracción(int a, int b)
        {
            Numerador = a;
            Denominador = b;
        }
    }
}
