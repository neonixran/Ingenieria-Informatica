/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prytrabajo;

/**
 *
 * @author iryde
 */
public class Jumpin {

    private int energiaActual;
    private int posicionActual = 0;

    public Jumpin(int energiaInicial) {
        if (energiaInicial < 1 || energiaInicial > 100) {
            throw new IllegalArgumentException("La energia actual no esta en el rango permitido (1-100");
        }

        this.energiaActual = energiaInicial;
    }

    public int getEnergiaActual() {
        return this.energiaActual;
    }

    public boolean saltar(int piedra) {
        int distancia = piedra - this.posicionActual;

        if (distancia > this.energiaActual) {
            return false;
        }

        if (distancia == this.energiaActual) {
            this.energiaActual--;
        }
        
        this.posicionActual = piedra;

        return true;
    }
}
