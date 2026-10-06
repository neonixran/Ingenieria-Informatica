using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorSolarPyme.GUI
{
    internal class CotizacionSolar
    {
        // Constantes
        public const double PORCENTAJE_FOMENTO = 0.15; // 15% de descuento estatal
        public const double TASA_IVA_CHILE = 0.19;    // 19% de IVA
        public const double MARGEN_FINANCIAMIENTO = 1.10; // 10% de flexibilidad presupuestaria

        // Atributos
        public string NombrePyme {  get; set; } = string.Empty;
        public string NombreComuna { get; set; } = string.Empty;
        public int CantidadPaneles {get; set; }
        public double TarifaPaneles {get; set; }
        public double CostoInversion { get; set; }
        public bool Fomento { get; set; }
        public double Presupuesto { get; set; }

        // Constructores
        public CotizacionSolar() { }

        public CotizacionSolar(string nombrePyme, string nombreComuna, int cantidadPaneles, double tarifaPaneles, double costoInversion, bool fomento, double presupuesto)
        {
            NombrePyme = nombrePyme;
            NombreComuna = nombreComuna;
            CantidadPaneles = cantidadPaneles;
            TarifaPaneles = tarifaPaneles;
            CostoInversion = costoInversion;
            Fomento = fomento;
            Presupuesto = presupuesto;
        }

        // Métodos
        public double CalcularSubtotal()
        {
            return (CantidadPaneles * TarifaPaneles) + CostoInversion;
        }

        public double CalcularMontoDescuento()
        {
            return Fomento ? CalcularSubtotal() * PORCENTAJE_FOMENTO : 0.0;
        }

        public double CalcularNetoConDescuento()
        {
            return CalcularSubtotal() - CalcularMontoDescuento();
        }

        public double CalcularMontoIva()
        {
            return CalcularNetoConDescuento() * TASA_IVA_CHILE;
        }

        public double CalcularCotizacion()
        {
            return CalcularNetoConDescuento() + CalcularMontoIva();
        }

        public bool EvaluarViabilidadEconomica()
        {
            return CalcularCotizacion() <= Presupuesto * MARGEN_FINANCIAMIENTO;
        }
    }
}
