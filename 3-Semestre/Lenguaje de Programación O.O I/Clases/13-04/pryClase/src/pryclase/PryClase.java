/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pryclase;
import java.lang.Math;

/**
 *
 * @author iryde
 */
public class PryClase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Sirena sirena = new Sirena();
        Tambor tambor = new Tambor();
        Trompeta trompeta = new Trompeta();
        
        sirena.sonar(10);
        trompeta.sonar(5);
        tambor.sonar(70);
    }
    
}
