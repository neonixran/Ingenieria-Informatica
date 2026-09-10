/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pryclase;

/**
 *
 * @author iryde
 */
public class PryClase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Bombilla bl = new BombillaLed(800, false, 1, "NF-21320");
        bl.enciendeBombilla();
        
        Bombilla bs = new BombillaSmart("Rojo", "Alexa", false, 2, "NT-3213");
        bl.enciendeBombilla();
        
    }
    
}
