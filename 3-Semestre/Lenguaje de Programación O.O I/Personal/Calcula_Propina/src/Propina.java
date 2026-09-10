/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author iryde
 */
public class Propina {
    private double monto_cuenta;
    private double porc_propina;
    private int num_personas;

    public Propina(double monto_cuenta, double porc_propina, int num_personas) {
        this.monto_cuenta = monto_cuenta;
        this.porc_propina = porc_propina;
        this.num_personas = num_personas;
    }

    public void setNum_personas(int num_personas) {
        this.num_personas = num_personas;
    }
    
    public double calcularPropina() {
        double propina = this.monto_cuenta * (this.porc_propina / 100);
        return propina;
    }
    
    
    public double calcularTotal() {
        double total = this.monto_cuenta + calcularPropina();
        return total;
    };
    
    public double calcularPagoPorPersona() {
        double pago_por_persona = calcularTotal() / this.num_personas;
        return pago_por_persona;
    }
}