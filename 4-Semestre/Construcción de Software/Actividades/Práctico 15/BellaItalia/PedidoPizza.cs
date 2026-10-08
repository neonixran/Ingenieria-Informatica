using System;
using System.Collections.Generic;
using System.Text;

namespace BellaItalia
{
    public class PedidoPizza
    {
        // Propiedades auto-implementadas de Entidad ({ get; set; })
        public string Cliente { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Tamano { get; set; } = "Mediana";
        public string TipoMasa { get; set; } = "Tradicional";

        // Adicionales
        public bool QuesoExtra { get; set; }
        public bool Pepperoni { get; set; }
        public bool Champinones { get; set; }
        public bool Aceitunas { get; set; }
        public bool Tocino { get; set; }

        // Opciones de Entrega y Beneficio
        public bool EsDelivery { get; set; }
        public bool AplicaConvenioEstudiante { get; set; }

        // Constantes de Precios de Negocio
        private const double PRECIO_PERSONAL = 5000.0;
        private const double PRECIO_MEDIANA = 8500.0;
        private const double PRECIO_FAMILIAR = 12000.0;
        private const double PRECIO_BORDE_QUESO = 1500.0;
        private const double PRECIO_INGREDIENTE_EXTRA = 800.0;
        private const double RECARGO_DELIVERY = 2000.0;
        private const double TASA_DESCUENTO = 0.10; // 10%
        private const double TASA_IVA = 0.19; // 19%

        // CONSTRUCTOR
        public PedidoPizza(string cliente, string telefono, string tamano, string tipoMasa, bool quesoExtra, bool pepperoni, bool champinones, bool aceitunas, bool tocino, bool esDelivery, bool aplicaDescuento)
        {
            Cliente = cliente;
            Telefono = telefono;
            Tamano = tamano;
            TipoMasa = tipoMasa;
            QuesoExtra = quesoExtra;
            Pepperoni = pepperoni;
            Champinones = champinones;
            Aceitunas = aceitunas;
            Tocino = tocino;
            EsDelivery = esDelivery;
            AplicaConvenioEstudiante = aplicaDescuento;
        }

        // MÉTODOS PUROS DE CÁLCULO DE NEGOCIO (SRP)
        public double CalcularPrecioTamano()
        {
            switch (Tamano)
            {
                case "Personal ($5.000)" :
                    return PRECIO_PERSONAL;
                case "Mediana ($8.500)":
                    return PRECIO_MEDIANA;
                case "Familiar ($12.000)":
                    return PRECIO_FAMILIAR;

            }

            return PRECIO_MEDIANA;
        }

        public double CalcularCostoMasa()
        {
            if (TipoMasa == "Borde de Queso")
            {
                return CalcularPrecioTamano() + PRECIO_BORDE_QUESO;
            }

            return CalcularPrecioTamano();
        }

        public int ContarIngredientesExtra()
        {
            int cantidadIngredientesExtras = 0;

            if (QuesoExtra)
            {
                cantidadIngredientesExtras++;
            }
            
            if (Pepperoni)
            {
                cantidadIngredientesExtras++;
            }
            
            if (Champinones)
            {
                cantidadIngredientesExtras++;
            } 
            
            if (Aceitunas)
            {
                cantidadIngredientesExtras++;
            } 
            
            if (Tocino)
            {
                cantidadIngredientesExtras++;
            }

            return cantidadIngredientesExtras;
        }
        
        public double CalcularCostoIngredientes()
        {
            return PRECIO_INGREDIENTE_EXTRA * ContarIngredientesExtra();
        }
        
        public double CalcularSubtotalPizza()
        {
            return CalcularCostoMasa() + CalcularCostoIngredientes();
        }

        public double CalcularMontoDescuento()
        {
            return AplicaConvenioEstudiante ? CalcularSubtotalPizza() * TASA_DESCUENTO : 0;
        }

        public double CalcularCostoDelivery()
        {
            return EsDelivery ? RECARGO_DELIVERY : 0;
        }

        public double CalcularNetoAfecto()
        {
            return CalcularSubtotalPizza() + CalcularMontoDescuento() + CalcularCostoDelivery();
        }

        public double CalcularMontoIva()
        {
            return CalcularNetoAfecto() * TASA_IVA;
        }

        public double CalcularTotalPagar()
        {
            return CalcularNetoAfecto() + CalcularMontoIva();
        }
    }
}
