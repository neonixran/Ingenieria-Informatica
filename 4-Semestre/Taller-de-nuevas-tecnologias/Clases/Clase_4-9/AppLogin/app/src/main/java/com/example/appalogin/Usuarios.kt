package com.example.appalogin

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Usuarios : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_usuarios)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var menu = findViewById<Button>(R.id.btnUsrMenu)
        var limpiar = findViewById<Button>(R.id.btnUsrLimpiar)
        var guardar = findViewById<Button>(R.id.btnUsrGuardar)

        var usuario = findViewById<EditText>(R.id.txtUsrUsuario)
        var contrasena = findViewById<EditText>(R.id.txtUsrContrasena)
        var repetirContrasena = findViewById<EditText>(R.id.txtUsrRepetirContrasena)

        menu.setOnClickListener {
            startActivity(Intent(this, Menu::class.java))
            finish()
        }

        limpiar.setOnClickListener {
            limpiarDatos(usuario, contrasena, repetirContrasena)
        }

        guardar.setOnClickListener {
            var mensaje : String

            if (usuario.text.isEmpty() && contrasena.text.isEmpty() && repetirContrasena.text.isEmpty()) {
                mensaje = "Debe ingresar todos los campos"
            } else if (!usuario.text.isEmpty() && contrasena.text.isEmpty() && repetirContrasena.text.isEmpty()) {
                mensaje = "Debe ingresar contraseña"
            } else if (usuario.text.isEmpty() && !contrasena.text.isEmpty() && repetirContrasena.text.isEmpty()) {
                mensaje = "Debe ingresar usuario y repetir contraseña"
            } else if (usuario.text.isEmpty() && contrasena.text.isEmpty() && !repetirContrasena.text.isEmpty()) {
                mensaje = "Debe ingresar usuario y contraseña"
            } else if (usuario.text.isEmpty() && !contrasena.text.isEmpty() && !repetirContrasena.text.isEmpty()) {
                mensaje = "Debe ingresar usuario"
            } else if (!usuario.text.isEmpty() && !contrasena.text.isEmpty() && repetirContrasena.text.isEmpty()) {
                 mensaje = "Debe repetir contraseña"
            } else if (!usuario.text.isEmpty() && contrasena.text.isEmpty() && !repetirContrasena.text.isEmpty()) {
                 mensaje = "Debe ingresar contraseña"
            } else {
                if (contrasena.text.toString() == repetirContrasena.text.toString()) {
                    try {
                        var contador = 0
                        for (item in listadoFinal) {
                            if (item.getUsr() == usuario.text.toString()) {
                                contador++
                            }
                        }

                        if (contador == 0) {
                            listadoFinal.add(Datos(usuario.text.toString(), contrasena.text.toString()))
                            mensaje = "Usuario ingresado exitosamente"
                        } else {
                            mensaje = "El usuario ingresado ya existe"
                        }
                    } catch (ex: Exception) {
                        mensaje = ex.toString()
                    }
                } else {
                    mensaje = "Las contraseñas deben coincidir"
                }
            }

            if (mensaje.isNotEmpty()) {
                Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show()
            }
        }
    }

    fun limpiarDatos(usuario: EditText, contrasena: EditText, repetirContrasena: EditText) {
        usuario.text.clear()
        contrasena.text.clear()
        repetirContrasena.text.clear()

    }
}