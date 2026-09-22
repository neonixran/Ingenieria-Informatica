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
public class Ejercicio_2 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        String contraseñaCorrecta = "java123";
        int intentos = 0 ;
        
        for (int i = 0; i < 3; i++) {
            System.out.println("Ingrese la contraseña:");
            String contraseña = entrada.next();
            
            if (contraseña.equals(contraseñaCorrecta)) {
                System.out.println("Acesso permitido");
                break;
            }
            
            System.out.println("Contraseña incorrecta");
            intentos++;
        }
        
        if (intentos == 3) {
            System.out.println("Usuario bloqueado. Ha superado el numero maximo de intentos.");
        }
    }
}
