/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase.Ejercicio_1;

/**
 *
 * @author iryde
 */
public class Ejercicio_1_Profe {
    public static void main(String[] args) {
        Arreglo arr = new Arreglo();
        
        arr.ingresar_numero();
        
        int suma = arr.suma_arreglo();
        
        System.out.printf("La suma de todos los elementos del arreglo es %d\n", suma);
    }
}
