/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package clase;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class Clase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("Ingrese el primer numero: ");
        int a = entrada.nextInt();
       
        System.out.println("Ingrese el segundo numero: ");
        int b = entrada.nextInt();
        /*int a = 5;
        int b = 4;*/
        
        int c = a + b;
        System.out.println("el resultado de " +  a + " + " + b + " es : " + c);
    }
    
}
