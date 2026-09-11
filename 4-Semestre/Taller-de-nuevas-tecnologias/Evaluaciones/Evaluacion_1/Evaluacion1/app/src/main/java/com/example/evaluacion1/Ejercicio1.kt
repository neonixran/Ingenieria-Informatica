package com.example.evaluacion1

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Ejercicio1 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio1)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val nombre = findViewById<EditText>(R.id.txtNombre)
        val edad = findViewById<EditText>(R.id.txtEdad)
        val area = findViewById<EditText>(R.id.txtArea)

        val limpiar = findViewById<Button>(R.id.btnLimpiarRegistro)
        val enviar = findViewById<Button>(R.id.btnEnviar)
        val volver = findViewById<Button>(R.id.btnEj1Volver)

        limpiar.setOnClickListener {
            nombre.text.clear()
            edad.text.clear()
            area.text.clear()
        }

        enviar.setOnClickListener {
            val nombre_ = nombre.text.toString()
            val edad_ = edad.text.toString()
            val area_ = area.text.toString()

            if (nombre_.isEmpty()) {
                Toast.makeText(this, "Debe ingresar el nombre", Toast.LENGTH_SHORT).show()
            } else if (edad_.isEmpty()) {
                Toast.makeText(this, "Debe ingresar la edad", Toast.LENGTH_SHORT).show()
            } else if (edad_.toInt() < 18) {
                Toast.makeText(this, "La edad ingresada no cumple los requisitos", Toast.LENGTH_SHORT).show()
            } else {
                val actividad = Intent(this, Ejercicio1Detalle::class.java)
                actividad.putExtra("NOMBRE", nombre_)
                actividad.putExtra("EDAD", edad_)
                actividad.putExtra("AREA", area_)

                startActivity(actividad)
                finish()
            }
        }

        volver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }
}