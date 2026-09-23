package com.uwu.sqlite

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class InsertarActivity : AppCompatActivity() {
    lateinit var personasDBHelper: miSQLiteHelper

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_insertar)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        personasDBHelper = miSQLiteHelper(this)

        val botonVolver = findViewById<Button>(R.id.btnInsertarVolver)

        val textoNombres = findViewById<EditText>(R.id.txtInsertarNombre)
        val textoApellidos = findViewById<EditText>(R.id.txtInsertarApellido)
        val textoEdad = findViewById<EditText>(R.id.txtInsertarEdad)

        val botonGuardar = findViewById<Button>(R.id.btnGuardar)

        botonVolver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        botonGuardar.setOnClickListener {
            val nombres = textoNombres.text.toString()
            val apellidos = textoApellidos.text.toString()
            val edad = textoEdad.text.toString()

            var mensaje : String

            if (nombres.isEmpty()) {
                mensaje = "Debe ingresar sus nombres"
            } else if (apellidos.isEmpty()) {
                mensaje = "Debe ingresar sus apellidos"
            } else if (edad.isEmpty()) {
                mensaje = "Debe ingresar la edad"
            } else {
                personasDBHelper.anyadirDato(
                    textoNombres.text.toString(),
                    textoApellidos.text.toString(),
                    textoEdad.text.toString().toInt()
                )

                mensaje = "Guardado correctamente"
            }

            Toast.makeText(
                this,
                mensaje,
                Toast.LENGTH_SHORT
            ).show()
        }
    }
}