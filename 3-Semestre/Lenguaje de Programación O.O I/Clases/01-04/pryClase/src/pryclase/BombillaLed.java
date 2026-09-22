/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

/**
 *
 * @author iryde
 */
public class BombillaLed extends Bombilla {
    private int consumoWatts;

    public BombillaLed(int consumoWatts, boolean estado, int tipo, String serie) {
        super(estado, tipo, serie);
        this.consumoWatts = consumoWatts;
    }    
    
    public void getConsumo() {
        System.out.printf("El consumo es de {consumoWatts} watts");
    }
}
