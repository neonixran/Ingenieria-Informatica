/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package proyectoPractico;
/**
 *
 * @author iryde
 */
public class Alumno extends Persona {
    private double promedioFinal;
    private String estado;

    public Alumno(String nombre, String rut, double promedioFinal, String estado) {
        super(nombre, rut);
        
        this.promedioFinal = promedioFinal;
        this.estado = estado;
    }

    public double getPromedioFinal() {
        return promedioFinal;
    }

    public void setPromedioFinal(double promedioFinal) {
        this.promedioFinal = promedioFinal;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }
}
