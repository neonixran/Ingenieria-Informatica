/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package calcula_hipotecario_bravojosué;

/**
 *
 * @author iryde
 */
public class Hipoteca {
    private int valorPropiedad;
    private int ahorroPrevio;
    private int sueldoLiquido;
    private int plazoCredito;
    
    private int valorUF = 40240;

    public Hipoteca(int valorPropiedad, int ahorroPrevio, int sueldoLiquido, int plazoCredito) {
        this.valorPropiedad = valorPropiedad;
        this.ahorroPrevio = ahorroPrevio;
        this.sueldoLiquido = sueldoLiquido;
        this.plazoCredito = plazoCredito;
    }
    
    private double calcularMontoFinanciamiento() {
        return this.valorPropiedad - this.ahorroPrevio;
    }
    
    private double cuotaPesos() {
        return (calcularMontoFinanciamiento() / (this.plazoCredito )) * this.valorUF;
    }
    
    public boolean evaluarDirectamente() {
        return this.ahorroPrevio >= this.valorPropiedad * 0.2 && cuotaPesos() <= this.sueldoLiquido * 0.25; // [*] Invertir signo de cuotaPesos() >= a <=.
    }
    
    public boolean evaluarComplemento(int sueldoAval) {
        return cuotaPesos() <= (sueldoLiquido + sueldoAval) * 0.25;
    }
}
