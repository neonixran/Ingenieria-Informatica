/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class Practico_2 {
     public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
         System.out.println("Ingrese su calificacion: ");
        
        int calificacion = entrada.nextInt();
      
         if (calificacion <= 0 || calificacion > 10) {
             System.out.println("Error");
             return;
         }
        
        if (calificacion >= 9) {
            System.out.println("Sobresaliente");
        } else if (calificacion >= 7) {
            System.out.println("Notable");
        } else if (calificacion >= 5) {
             System.out.println("Aprobado");
        } else {
            System.out.println("Reprobado");
        }
    }
}
