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
       int[] arreglo_1 = new int[5];
       
        arreglo_1[2] = 5;
        
        int[][] matriz_1 = new int[3][3];
        
        try {
            matriz_1[3][4] = 4;
        } catch(ArrayIndexOutOfBoundsException e) {
            System.out.println("Fuera del indice.");
        }
    }
    
}
