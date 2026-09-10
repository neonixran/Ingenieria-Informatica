using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPloblema1
{
    internal class Fecha
    {
        private int _día;
        public int día {
            get
            {
                return _día;
            }
            set {
                if (value < 1 || value > 31)
                {
                    throw new ArgumentException("Debe ingresar un día válido (entre 1 y 31)");
                }

                _día = value;
            }
        }

        private int _mes;

        public int mes {
            get
            {
                return _mes;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Debe ingresar un mes válido (entre 1 y 12)");
                }

                _mes = value;
            }
        }

        private int _año;

        public int año {
            get
            {
                return _año;
            }
            set
            {
                if (value < 1925 || value > 2125)
                {
                    throw new ArgumentException("Debe ingresar un año válido (entre 1925 y 2125)");
                }

                _año = value;
            }
        }

        public string mostrarFecha()
        {
            string fechaCompleta = String.Format("{0}/{1}/{2}", día, mes, año);
            return fechaCompleta;
        }

        public string mostrarFecha2()
        {
            string nombreMes = "";

            if (mes == 1)
            {
                nombreMes = "Enero";
            }
            else if (mes == 2)
            {
                nombreMes = "Febrero";
            }
            else if (mes == 3)
            {
                nombreMes = "Marzo";
            }
            else if (mes == 4)
            {
                nombreMes = "Abril";
            }
            else if (mes == 5)
            {
                nombreMes = "Mayo";
            }
            else if (mes == 6)
            {
                nombreMes = "Junio";
            }
            else if (mes == 7)
            {
                nombreMes = "Julio";
            }
            else if (mes == 8)
            {
                nombreMes = "Agosto";
            }
            else if (mes == 9)
            {
                nombreMes = "Septiembre";
            }
            else if (mes == 10)
            {
                nombreMes = "Octubre";
            }
            else if (mes == 11)
            {
                nombreMes = "Noviembre";
            }
            else if (mes == 12)
            {
                nombreMes = "Diciembre";
            }

            string fechaCompleta = String.Format("Fecha: {0}-{1}-{2}\nMes: {3}", día, mes, año, nombreMes);
            return fechaCompleta;
        }
    }
}
