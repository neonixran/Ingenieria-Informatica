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
public class Arreglo {
    private int longitud = 5;
    private int[] arreglo = new int[longitud];
    
    public void ingresar_numero() {
       Scanner entrada = new Scanner(System.in);
       
        for (int i = 0; i < arreglo.length; i++) {
            System.out.printf("Ingresa %dº numero: ", i + 1);
            arreglo[i] = entrada.nextInt();
        }
    }
    
    public int suma_arreglo() {
        int suma = 0;
     
        for (int i = 0; i < arreglo.length; i++) {
            suma+= arreglo[i];
        }
        
        return suma;
    }
}
