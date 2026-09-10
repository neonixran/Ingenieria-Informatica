using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProblema2
{
    internal class Viaje
    {
        public string destino { get; set; }

        private double _distancia;
        public double distancia {
            get
            {
                return _distancia;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La distancia no puede ser 0.");
                }

                _distancia = value;
            }
        } // Distancia viajada
        public double costoBencina { get; set; } // Costo total de la bencina

        private double _litrosConsumidos;
        public double litrosConsumidos {
            get {
                return _litrosConsumidos;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor no puede ser 0.");
                }

                _litrosConsumidos = value;
            }
        } // Litros de bencina consumidos

        public double kmLitro()
        {
            double kilometrosPorLitro = distancia / litrosConsumidos;
            return kilometrosPorLitro;
        }

        public double costoKm()
        {
            double costo = costoBencina / distancia;
            return costo;
        }
    }
}
