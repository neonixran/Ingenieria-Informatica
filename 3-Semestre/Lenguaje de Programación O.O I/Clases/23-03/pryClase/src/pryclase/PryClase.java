/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pryclase;

import java.util.Scanner;
import java.util.InputMismatchException;

/**
 *
 * @author iryde
 */
public class PryClase {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            Scanner entrada = new Scanner(System.in);

            System.out.println("Ingrese el numero que quiere obtener el Factorial:  ");

            int n = entrada.nextInt();
            
            if (n == 0) {
                throw new ArithmeticException();
            }
            
            double factorial = 1;

            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }

            System.out.println("El factorial de " + n + " es igual a " + factorial);
        } catch (InputMismatchException e) {
            System.out.println("Ingresaste un dato invalido!");
        } catch (ArithmeticException e) {
            System.out.println("No puede usarse el cero!");
        }
    }

}
