/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase.Ejercicio_1;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class Ejercicio_1_Yo {

    public static void main(String[] args) {
        int[] arr = new int[5];

        Scanner entrada = new Scanner(System.in);

        for (int i = 0; i < arr.length; i++) {
            System.out.printf("Ingrese %dº: ", i+1);
            int n = entrada.nextInt();
            
            arr[i] = n;
        }
        
        int suma = 0;
        
        for (int i = 0; i < arr.length; i++) {
            suma+= arr[i];
        }
        
        System.out.println(suma);
    }
}
