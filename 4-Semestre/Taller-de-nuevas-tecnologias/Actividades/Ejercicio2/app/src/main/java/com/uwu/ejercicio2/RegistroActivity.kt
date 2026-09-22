package com.uwu.ejercicio2

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter

class RegistroActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_registro)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val nombre_ = findViewById<EditText>(R.id.txtRegistroNombre)
        val usuario_ = findViewById<EditText>(R.id.txtRegistroUsuario)
        val contrasena_ = findViewById<EditText>(R.id.txtRegistroContrasena)

        val historico = findViewById<Button>(R.id.btnRegistroHistorico)
        val cerrarSesion = findViewById<Button>(R.id.btnRegistroCerrarSesion)
        val registrar = findViewById<Button>(R.id.btnRegistrar)

        historico.setOnClickListener {
            startActivity(Intent(this, HistoricoActivity::class.java))
            finish()
        }

        cerrarSesion.setOnClickListener {
            Sesion.usuarioActual = null

            startActivity(Intent(this, LoginActivity::class.java))
            finish()
        }

        registrar.setOnClickListener {
            val nombre = nombre_.text.toString()
            val usuario = usuario_.text.toString()
            val contrasena = contrasena_.text.toString()

            if (nombre.isEmpty()) {
                Toast.makeText(this, "Debe ingresar el nombre", Toast.LENGTH_SHORT).show()
            } else if (usuario.isEmpty()) {
                Toast.makeText(this, "Debe ingresar el usuario", Toast.LENGTH_SHORT).show()
            } else if (contrasena.isEmpty()) {
                Toast.makeText(this, "Debe ingresar la contraseña", Toast.LENGTH_SHORT).show()
            } else {
                val fechaHora = LocalDateTime.now().format(DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss")).toString()

                Sesion.listadoUsuarios.add(Usuarios(nombre, usuario, contrasena))
                Sesion.listadoHistorico.add(Historico(Sesion.usuarioActual?.getUsuario(), fechaHora, usuario))

                Toast.makeText(this, "Usuario registrado", Toast.LENGTH_SHORT).show()
            }
        }
    }
}