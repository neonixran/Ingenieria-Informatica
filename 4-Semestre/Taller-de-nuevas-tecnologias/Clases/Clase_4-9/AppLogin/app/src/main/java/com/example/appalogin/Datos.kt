package com.example.appalogin

class Datos(private var usr: String, private var pass: String) {
    fun getUsr(): String {
        return usr
    }

    fun setUsr(usuario: String) {
        this.usr = usuario
    }

    fun getPass(): String {
        return pass
    }

    fun setPass(password: String) {
        this.pass = password
    }
}

var listadoFinal: ArrayList<Datos> = ArrayList()
var usuario_login : String = ""