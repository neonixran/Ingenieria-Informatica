/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prypráctico;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class Ejercicio_4 {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        System.out.println("Ingrese saldo inicial:");
        double dinero = entrada.nextDouble();

        double saldo = dinero;

        while (true) {
            System.out.println("\nOpciones:\n\t1. Consultar saldo\n\t2. Depositar dinero\n\t3. Girar dinero\n\t4. Salir\nSeleccione una opcion:");
            int opcion = entrada.nextInt();

            switch (opcion) {
                case 1 -> {
                    System.out.println("\nSu saldo actual es de " + saldo + " pesos.");
                }
                case 2 -> {
                    System.out.println("Ingrese cantidad a depositar:");
                    dinero = entrada.nextInt();

                    if (dinero < 0) {
                        System.out.println("No depositar saldo negativo");
                        continue;
                    }

                    saldo += dinero;
                    System.out.println("Monto depositado");
                }
                case 3 -> {
                    while (true) {
                        System.out.println("Ingrese cantidad a girar (0 para cancelar):");
                        dinero = entrada.nextInt();

                        if (dinero == 0) {
                            break;
                        }
                        
                        if (dinero < 0) {
                            System.out.println("No puede girar saldo negativo");
                            continue;
                        }

                        if (dinero > saldo) {
                            System.out.println("El monto a girar es mayor al saldo disponible!");
                            continue;
                        }

                        saldo -= dinero;
                        System.out.println("Monto girado de su cuenta");
                        break;
                    }
                }
                case 4 -> {
                    break;
                }
            }
        }
    }
}
