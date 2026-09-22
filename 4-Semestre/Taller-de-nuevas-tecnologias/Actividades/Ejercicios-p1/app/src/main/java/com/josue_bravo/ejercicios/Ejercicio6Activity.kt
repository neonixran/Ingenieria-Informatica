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

class Ejercicio6Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio6)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj6Menu)

        val centimetros = findViewById<EditText>(R.id.txtEj6Centimetros)
        val convertir = findViewById<Button>(R.id.btnEj6Convertir)

        val tituloPies = findViewById<TextView>(R.id.lblEj6Pies)
        val textoPies = findViewById<TextView>(R.id.txtEj6Pies)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        convertir.setOnClickListener {
            if (centimetros.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar los centímetros", Toast.LENGTH_SHORT).show()
            } else {
                tituloPies.visibility = View.VISIBLE
                textoPies.text = String.format("%.2f", centimetros.text.toString().toInt() * 30.48)
            }
        }
    }
}