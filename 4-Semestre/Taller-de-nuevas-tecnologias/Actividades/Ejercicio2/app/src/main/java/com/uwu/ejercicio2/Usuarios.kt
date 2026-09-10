package com.uwu.ejercicio2

class Usuarios(private var nombre: String, private var usuario: String, private var contrasena: String) {
    fun setNombre(nombre: String) {
        this.nombre = nombre
    }

    fun getNombre(): String {
        return this.nombre
    }

    fun setUsuario(usuario: String) {
       this.usuario = usuario
    }

    fun getUsuario(): String {
        return this.usuario
    }

    fun setContrasena(contrasena: String) {
        this.contrasena = contrasena
    }

    fun getContrasena(): String {
        return this.contrasena
    }
}