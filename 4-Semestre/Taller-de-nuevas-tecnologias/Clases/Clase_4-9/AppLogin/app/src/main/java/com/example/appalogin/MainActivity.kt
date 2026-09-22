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

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var usuario = findViewById<EditText>(R.id.txtMainUsuario)
        var contrasena = findViewById<EditText>(R.id.txtMainContrasena)
        var btnIngreso = findViewById<Button>(R.id.btnMainIngresar)

        inicial() // Para crear el usuario

        btnIngreso.setOnClickListener {
            if (usuario.text.isEmpty() && contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su usuario y contraseña", Toast.LENGTH_SHORT).show()
            } else if (usuario.text.isEmpty() && !contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su usuario", Toast.LENGTH_SHORT).show()
            } else if (!usuario.text.isEmpty() && contrasena.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su contraseña", Toast.LENGTH_SHORT).show()
            } else {
                validar(usuario, contrasena)
            }
        }
    }

    fun inicial() {
        if (listadoFinal.isEmpty()) {
            listadoFinal.add(Datos("ADMIN", "ADMIN"))
        }
    }

    fun validar(usuario: EditText, contrasena: EditText) {
        var respuesta = "Usuario no se encuentra en el sistema"

        try {
            for (item in listadoFinal) {
                if (item.getUsr() == usuario.text.toString()) {
                    if (item.getPass() == contrasena.text.toString()) {
                        var menu = Intent(this, Menu::class.java)
                        usuario_login = usuario.text.toString()
                        startActivity(menu)
                        finish()

                        respuesta = "Hola ${usuario.text}"
                    } else {
                        respuesta = "Contraseña incorrecta"
                    }
                }
            }
        } catch (ex: Exception) {
            respuesta = ex.toString()
        }

        Toast.makeText(this, respuesta, Toast.LENGTH_SHORT).show()
    }
}