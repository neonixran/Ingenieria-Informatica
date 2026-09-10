/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pryclase;

/**
 *
 * @author iryde
 */
public class Bombilla {
    // Atributos
    protected boolean estado;
    protected int tipo;
    protected String serie;
    
    // Constructores
    public Bombilla() {}

    public Bombilla(boolean estado, int tipo, String serie) {
        this.estado = estado;
        this.tipo = tipo;
        this.serie = serie;
    }
    
    public Bombilla(String serie) {
        this.serie = serie;
    }
    
    // Métodos
    public void enciendeBombilla() {
        this.estado = true;
    }
    
    public void apagaBombilla() {
        this.estado = false;
    }
    
    public boolean isEstado() {
        return estado;
    }

    public int getTipo() {
        return tipo;
    }

    public String getSerie() {
        return serie;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public void setTipo(int tipo) {
        this.tipo = tipo;
    }

    public void setSerie(String serie) {
        this.serie = serie;
    }
}
