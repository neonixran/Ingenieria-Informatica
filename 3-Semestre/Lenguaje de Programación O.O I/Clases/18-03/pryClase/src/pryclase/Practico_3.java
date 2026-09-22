/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

import java.util.Scanner; // Scanner para entradas de usuario.
import java.util.Random; // Random para generar números random

/**
 *
 * @author iryde
 */
public class Practico_3 {

    public static void main(String args[]) {
        Scanner entrada = new Scanner(System.in);

        Random rand = new Random();
        int numRand = rand.nextInt(100);
        
        int sel = 1;
        int intentos = 0;

        do {
            if (sel == 1) {
                System.out.println("Ingrese un número: ");

                int num = entrada.nextInt();

                if (numRand > num) {
                    System.out.println("El numero es mayor al ingresado");

                    System.out.println("Quiere volver a intentar? (0=no, 1=si)");
                    sel = entrada.nextInt();
                    
                    intentos++;
                } else if (numRand < num) {
                    System.out.println("El numero es menor al ingresado");

                    System.out.println("Quiere volver a intentar? (0=no, 1=si)");
                    sel = entrada.nextInt();
                    
                    intentos++;
                } else if (numRand == num) {
                    System.out.println("Felicidades, ganaste en " + intentos + " intentos.");
                    break;
                }
            } else {
                System.out.println("Adiós!");
                break;
            }
        } while (true);
    }
}
