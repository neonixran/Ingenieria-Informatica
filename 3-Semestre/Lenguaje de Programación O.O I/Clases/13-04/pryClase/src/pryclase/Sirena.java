/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

/**
 *
 * @author iryde
 */
public class Sirena implements Sonoro {

    @Override
    public void sonar(int volumen) {
        System.out.printf("Wiu wiu wiuuu con un volumen de %d\n", volumen);
    }
    
}
