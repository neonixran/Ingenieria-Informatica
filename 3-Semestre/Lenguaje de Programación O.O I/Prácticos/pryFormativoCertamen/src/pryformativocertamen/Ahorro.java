/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryformativocertamen;

/**
 *
 * @author iryde
 */
public class Ahorro {

    private double montoMensual;
    private double metaTotal;
    private int numeroMeses;

    public Ahorro(double montoMensual, double metaTotal, int numeroMeses) {
        if (montoMensual <= 0) {
            throw new ArithmeticException("El monto mensual no puede ser menor a 0");
        }

        if (metaTotal <= 0) {
            throw new ArithmeticException("La meta de ahorro no puede ser menor a 0");
        }

        if (numeroMeses <= 0) {
            throw new ArithmeticException("El número de meses no puede ser menor a 0");
        }

        this.montoMensual = montoMensual;
        this.metaTotal = metaTotal;
        this.numeroMeses = numeroMeses;
    }
    
    public double obtenerDiferencia() {
        double ahorro_estimado = this.montoMensual * this.numeroMeses;
        return ahorro_estimado - this.metaTotal;
    }
    
    public double obtenerExcedente() {
        double ahorro_estimado = this.montoMensual * this.numeroMeses;
        return ahorro_estimado - this.metaTotal;
    }
    
    public double obtenerNuevoMonto(int meses) {
        if (meses < 0) {
            throw new ArithmeticException("El número de meses no puede ser menor a 0"); 
        }
        
        return this.metaTotal / meses;
    }
}
