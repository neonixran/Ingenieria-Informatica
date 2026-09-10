package com.josue_bravo.ejercicios

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

class Ejercicio7Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio7)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj7Menu)

        val opcion = findViewById<EditText>(R.id.txtEj7Opcion)
        val generar = findViewById<Button>(R.id.btnEj7Generar)

        val textoResultado = findViewById<TextView>(R.id.txtEj7Resultado)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        generar.setOnClickListener {
            textoResultado.text = ""

            if (opcion.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar una opción", Toast.LENGTH_SHORT).show()
            } else if (opcion.text.toString() != "1" && opcion.text.toString() != "2" && opcion.text.toString() != "3") {
                Toast.makeText(this, "Fuera de rango", Toast.LENGTH_SHORT).show()
            } else {
                when(opcion.text.toString()) {
                    "1" -> {
                        var contador1 = 0
                        while (contador1 <= 10) {
                            textoResultado.append("${contador1}\n")
                            contador1++
                        }
                    }
                    "2" -> {
                        for (i in 0..10) {
                            textoResultado.append("${i}\n")
                        }
                    }
                    "3" -> {
                        var contador2 = 0

                        do {
                            textoResultado.append("${contador2}\n")
                            contador2++
                        } while (contador2 <= 10)
                    }
                }
            }
        }
    }
}