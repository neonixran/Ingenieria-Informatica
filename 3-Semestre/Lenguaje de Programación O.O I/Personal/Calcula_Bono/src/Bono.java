/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author iryde
 */
public class Bono {
    private double ventasRealizadas;
    private double metaVentas;
    private double sueldoBase;

    public Bono(double ventasRealizadas, double metaVentas, double sueldoBase) {
        this.ventasRealizadas = ventasRealizadas;
        this.metaVentas = metaVentas;
        this.sueldoBase = sueldoBase;
    }

    public void setVentasRealizadas(double ventasRealizadas) {
        this.ventasRealizadas = ventasRealizadas;
    }
    
    public double calcularDiferencia() {
        return this.ventasRealizadas - this.metaVentas;
    }
    
    public double calcularBono() {
        return this.sueldoBase * 0.15;
    }
    
    public double calcularSueldoFinal(double bono) {
        return this.sueldoBase + bono;
    }
    
    public double calcularVentasAdicionales(double ventasAdicionales) {
        return this.ventasRealizadas + ventasAdicionales;
    }
}
