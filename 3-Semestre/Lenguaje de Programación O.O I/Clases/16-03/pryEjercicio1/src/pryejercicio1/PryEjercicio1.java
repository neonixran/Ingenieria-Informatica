/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pryejercicio1;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class PryEjercicio1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("Ingrese el primer numero: ");
        double a = entrada.nextDouble();
       
        System.out.println("Ingrese el segundo numero: ");
        double b = entrada.nextDouble();
        
        double suma = a + b;
        double resta = a - b;
        double multiplicacion = a * b;
        double division = a / b;
        
        System.out.println("El resultado de la suma es: " + suma);
        System.out.println("El resultado de la resta es: " + resta);
        System.out.println("El resultado de la multiplicacion es: " + multiplicacion);
        System.out.println("El resultado de la division es: " + division);
        
    }
    
}
