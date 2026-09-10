/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prybombilla;

/**
 *
 * @author Josué Bravo
 */
public class Bombilla {

    public boolean estado = false;
    public int tipo;
    public int serie;

    // Métodos
    public void encender() {
        estado = true;
    }

    public void apagar() {
        estado = false;
    }
    
    public void getDetalles() {
        System.out.printf("la bombilla esta %s, es de tipo \"%s\" y su numero de serie es %s.\n", estado ? "encendida" : "apagada", tipo, serie);
    }
}
