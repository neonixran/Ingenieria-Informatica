/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

/**
 *
 * @author iryde
 */
public class BombillaSmart extends Bombilla {
    private String color;
    private String APVoice;

    public BombillaSmart(String color, String APVoice, boolean estado, int tipo, String serie) {
        super(estado, tipo, serie);
        this.color = color;
        this.APVoice = APVoice;
    }
    
    
    @Override
    public void enciendeBombilla() {
        System.out.println("Movimiento detectado");
        this.setEstado(true);
    }
    
    public void cambiarColor(String color) {
        this.color = color;
    }
}
