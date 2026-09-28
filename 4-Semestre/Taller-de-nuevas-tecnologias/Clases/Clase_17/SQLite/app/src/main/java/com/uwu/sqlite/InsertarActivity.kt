package com.uwu.sqlite

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class InsertarActivity : AppCompatActivity() {
    lateinit var personasDBHelper: SQLiteHelper

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_insertar)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        personasDBHelper = SQLiteHelper(this)

        val botonVolver = findViewById<Button>(R.id.btnInsertarVolver)

        val textoNombres = findViewById<EditText>(R.id.txtInsertarNombre)
        val textoApellidos = findViewById<EditText>(R.id.txtInsertarApellido)
        val textoEdad = findViewById<EditText>(R.id.txtInsertarEdad)

        val botonGuardar = findViewById<Button>(R.id.btnGuardar)

        botonVolver.setOnClickListener {
            startActivity(Intent(this, ConsultarActivity::class.java))
        }

        botonGuardar.setOnClickListener {
            val nombres = textoNombres.text.toString()
            val apellidos = textoApellidos.text.toString()
            val edad = textoEdad.text.toString()

            val tituloMensaje = "Para poder agregar una persona, debe ingresar: \n"
            var mensaje = tituloMensaje

            if (nombres.isEmpty()) {
                mensaje += "- Sus nombres\n"
            }

            if (apellidos.isEmpty()) {
                mensaje += "- Sus apellidos\n"
            }

            if (edad.isEmpty()) {
                mensaje += "- Su edad"
            }

            if (!mensaje.matches(Regex(tituloMensaje))) {
                AlertDialog.Builder(this)
                    .setMessage(mensaje)
                    .setPositiveButton("Ok") { dialog, id ->
                        dialog.dismiss()
                    }
                    .create()
                    .show()
            } else {
                personasDBHelper.anadirRegistro(nombres, apellidos, edad.toInt())

                textoNombres.text.clear()
                textoApellidos.text.clear()
                textoEdad.text.clear()

                Toast.makeText(this, "Agregado exitosamente", Toast.LENGTH_SHORT).show()
            }
        }
    }
}