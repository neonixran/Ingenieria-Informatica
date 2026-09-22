package com.uwu.ejercicio2

class Historico(private var creador: String?, private var fechaHora: String, private var usuario: String) {
    fun getCreador(): String? {
        return this.creador
    }

    fun getFechaHora(): String {
        return this.fechaHora
    }

    fun getUsuario(): String {
        return this.usuario
    }
}