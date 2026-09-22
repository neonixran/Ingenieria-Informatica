/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prytrabajo;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class pryTrabajo {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        int energiaInicial = 0;
        boolean validacion1;

        do {
            try {
                validacion1 = true;
                
                System.out.println("Ingrese la energia inicial (1-100):");
                energiaInicial = Integer.parseInt(entrada.nextLine());

                if (energiaInicial < 1 || energiaInicial > 100) {
                    System.out.println("La energia incial debe estar entre 1 y 100");
                    validacion1 = false;
                    continue;
                }
            } catch (NumberFormatException e) {
                System.out.println("la energia ingresada no es un numero valido");
                validacion1 = false;
            }
        } while (!validacion1);

        boolean validacion2;
        int cantPiedras = 0;

        do {
            try {
                validacion2 = true;
                
                System.out.println("Ingrese la cantidad de piedras (1-5000):");
                cantPiedras = Integer.parseInt(entrada.nextLine());

                if (cantPiedras < 1 || cantPiedras > 5000) {
                    System.out.println("La cantidad de piedras debe estar entre 1 y 5000");
                    validacion2 = false;
                    continue;
                }
            } catch (NumberFormatException e) {
                System.out.println("la cantidad de piedras ingresada no es un numero valido");
                validacion2 = false;
            }
        } while (!validacion2);

        int piedras[] = new int[cantPiedras];
        boolean validacion3;

        do {
            try {
                validacion3 = true;

                System.out.println("Ingrese la ubicacion de las piedras (ej. 1, 4, 3):");
                String posiciones = entrada.nextLine();

                String[] partes = posiciones.split("\\s*,\\s*"); // Split hace un arreglo con el separador de comas, dando igual si el usuario lo ingresa sin espacios o con espacios.

                if (partes.length != cantPiedras) {
                    System.out.printf("Las cantidad de piedras no coincide con las %d piedras ingresadas anteriormente\n", cantPiedras);
                    validacion3 = false;
                    continue;
                }

                for (int i = 0; i < partes.length; i++) {
                    int piedra = Integer.parseInt(partes[i]);

                    if (piedra < 1 || piedra > 1000) {
                        System.out.println("Los numeros ingresados deben estar entre 1 y 1000");
                        validacion3 = false;
                        break;
                    }

                    piedras[i] = piedra;
                }
            } catch (NumberFormatException e) {
                System.out.println("Un dato ingresado no es valido");
                validacion3 = false;
            }
        } while (!validacion3);

        entrada.close();

        Jumpin jumpin = new Jumpin(energiaInicial);
        Rio rio = new Rio(piedras);

        if (rio.cruzar(jumpin)) {
            System.out.printf("Jumpin lo logro y quedo con energia %d\n", jumpin.getEnergiaActual());
        } else {
            System.out.println("Jumpin no puede cruzar el rio\n");
        }
    }
}
