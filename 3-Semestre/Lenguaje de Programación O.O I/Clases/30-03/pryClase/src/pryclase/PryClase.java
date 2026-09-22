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
        Bombilla b1 = new Bombilla();
        
        b1.setEstado(true);
        System.out.println(b1.isEstado() ? "Bombilla encendida" : "Bombilla apagada");
        
        Bombilla b2 = new Bombilla(true, 3, "NT001");
  
        System.out.println(b2.isEstado() ? "Bombilla encendida" : "Bombilla apagada");
        
        Bombilla b3 = new Bombilla("NT002");
       
        System.out.println(b3.isEstado() ? "Bombilla encendida" : "Bombilla apagada");
    }
    
}
