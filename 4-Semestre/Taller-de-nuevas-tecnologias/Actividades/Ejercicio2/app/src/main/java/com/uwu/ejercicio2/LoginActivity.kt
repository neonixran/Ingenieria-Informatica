package com.uwu.ejercicio2

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class LoginActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_login)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val listadoUsuarios = Sesion.listadoUsuarios

        val usuario_ = findViewById<EditText>(R.id.txtLoginUsuario)
        val contrasena_ = findViewById<EditText>(R.id.txtLoginContrasena)

        val ingreso = findViewById<Button>(R.id.btnIngresar)

        listadoUsuarios.add(Usuarios("administrador", "admin", "admin"))

        ingreso.setOnClickListener {
            val usuario = usuario_.text.toString()
            val contrasena = contrasena_.text.toString()

            if (usuario.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su usuario", Toast.LENGTH_SHORT).show()
            } else if (contrasena.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su contraseña", Toast.LENGTH_SHORT).show()
            } else {
                val loginExitoso: Usuarios? = listadoUsuarios.find {
                    it.getUsuario() == usuario && it.getContrasena() == contrasena
                }

                if (loginExitoso != null) {
                    Sesion.usuarioActual = loginExitoso
                    Toast.makeText(this, "Bienvenido, ${Sesion.usuarioActual?.getNombre()}", Toast.LENGTH_SHORT).show()
                    startActivity(Intent(this, RegistroActivity::class.java))
                    finish()
                } else {
                    Toast.makeText(this, "Usuario o contraseña incorrectos", Toast.LENGTH_SHORT).show()
                }
            }
        }
    }
}