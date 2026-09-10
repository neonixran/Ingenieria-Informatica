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
public class Ejercicio_3 {

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        double nota;

        double sumaNotas = 0;
        int cantidadNotas = 0;

        while (true) {
            System.out.println("Ingrese nota (-1 para terminar):");
            nota = entrada.nextDouble();

            if (nota == -1) {
                break;
            }

            if (nota < 1 || nota > 7) {
                System.out.println("Nota invalida. Ingrese una nota entre 1.0 y 7.0");
                continue;
            }

            sumaNotas += nota;
            cantidadNotas++;
        }

        if (cantidadNotas > 0) {
            double promedio = (sumaNotas) / (cantidadNotas);

            System.out.println("El promedio de notas es " + promedio + ", de un total de " + cantidadNotas + " notas.");
        } else {
            System.out.println("No hay notas que promediar!");
        }
    }
}
