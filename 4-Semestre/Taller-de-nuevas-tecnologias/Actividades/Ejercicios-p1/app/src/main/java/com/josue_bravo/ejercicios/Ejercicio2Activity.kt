package com.josue_bravo.ejercicios

import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import java.text.NumberFormat

class Ejercicio2Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio2)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj2Menu)

        val clp = findViewById<EditText>(R.id.txtEj2Clp)
        val convertir = findViewById<Button>(R.id.btnEj2Convertir)

        val tituloUsd = findViewById<TextView>(R.id.lblEj2Usd)
        val textoUsd = findViewById<TextView>(R.id.txtEj2Usd)

        convertir.setOnClickListener {
            if (clp.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar el valor para convertir", Toast.LENGTH_SHORT).show()
            } else {
                val valor = clp.text.toString().toDouble() * 0.001066
                val monedaFormateada = NumberFormat.getCurrencyInstance().format(valor)

                tituloUsd.visibility = View.VISIBLE
                textoUsd.text = monedaFormateada
            }
        }

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }
}