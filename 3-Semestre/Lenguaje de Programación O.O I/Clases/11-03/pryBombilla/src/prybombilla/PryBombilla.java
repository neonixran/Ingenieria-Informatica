/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package prybombilla;

/**
 *
 * @author iryde
 */
public class PryBombilla {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Bombilla a = new Bombilla();
        a.encender();

        a.tipo = 1;
        a.serie = 03212;

        a.getDetalles();
    }

}
