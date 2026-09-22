/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package prytrabajo;

/**
 *
 * @author iryde
 */
public class Rio {
    private int[] piedras;
    private int orillaFinal;

    public Rio(int[] piedras) {
        this.piedras = piedras;

        this.orillaFinal = this.piedras[this.piedras.length - 1];
    }
    
    public boolean cruzar(Jumpin jumpin) {
        for (int i = 0; i < piedras.length; i++) {
            if (!jumpin.saltar(piedras[i])) {
                return false;
            }
        }
        
        return true;
    }
}
