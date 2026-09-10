/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package proyectoPractico;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author iryde
 */
public abstract class Persona {

    private String nombre;
    private String rut;

    public Persona() {
    }

    public Persona(String nombre, String rut) {
        if ("".equals(nombre)) {
            throw new IllegalArgumentException("El nombre está vacio");
        }
        
        this.nombre = nombre;
        
        rut = rut.replaceAll("[^0-9kK]", "").toUpperCase();
        
        if ("".equals(rut)) {
            throw new IllegalArgumentException("El rut está vacio");
        } else if (rut.length() < 7 || rut.length() > 9) {
            throw new IllegalArgumentException("Longitud del rut incorrecta");
        }
        
        Matcher matcher = Pattern.compile("^(\\d{1,2})(\\d{3})(\\d{3})([0-9kK])$").matcher(rut);

        if (matcher.matches()) {
            this.rut = String.format(
                    "%s.%s.%s-%s",
                    matcher.group(1),
                    matcher.group(2),
                    matcher.group(3),
                    matcher.group(4));
        } else {
            throw new IllegalArgumentException("El formato del rut es invalido");
        }
    }

    protected String getNombre() {
        return nombre;
    }

    protected void setNombre(String nombre) {
        this.nombre = nombre;
    }

    protected String getRut() {
        return rut;
    }

    protected void setRut(String rut) {
        this.rut = rut;
    }
}
