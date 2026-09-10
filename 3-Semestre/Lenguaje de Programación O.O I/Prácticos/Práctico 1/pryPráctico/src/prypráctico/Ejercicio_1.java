/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package prypráctico;

import java.util.Scanner;

/**
 *
 * @author iryde
 */
public class Ejercicio_1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        System.out.println("Hora del dia");

        System.out.println("Ingrese la hora: ");
        int hora = entrada.nextInt();

        System.out.println("Ingrese los minutos:");
        int minuto = entrada.nextInt();

        if (hora == 12) {
            System.out.println("Mediodia");
        } else if (hora == 00) {
            System.out.println("Medianoche");
        } else if (hora <= 07) {
            System.out.println("Madrugada");
        } else if (hora <= 12) {
            System.out.println("Mañana");
        } else if (hora <= 21) {
            System.out.println("Tarde");
        } else if (hora <= 23 && minuto <= 59) {
            System.out.println("Noche");
        }
    }

}
