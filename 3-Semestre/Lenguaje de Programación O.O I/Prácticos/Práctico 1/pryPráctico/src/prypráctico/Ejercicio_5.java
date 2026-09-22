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
public class Ejercicio_5 {
    public static boolean esPrimo(int n) {
        if (n <= 1) return false;
        
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }
        
        return true;
    }
    
    public static void main(String[] args) {
        for (int i = 1; i <= 1000; i++) {
            if (esPrimo(i)) {
                System.out.println("El numero " + i + " es primo");
            }
        }
    }
}
