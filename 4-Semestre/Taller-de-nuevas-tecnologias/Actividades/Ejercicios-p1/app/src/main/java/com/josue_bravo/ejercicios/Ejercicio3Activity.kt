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

class Ejercicio3Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio3)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj3Menu)

        val valor = findViewById<EditText>(R.id.txtEj3Valor)
        val calcular =  findViewById<Button>(R.id.btnEj3Calcular)

        val tituloCuota = findViewById<TextView>(R.id.lblEj3Cuota)
        val textoCuota = findViewById<TextView>(R.id.txtEj3Cuota)

        calcular.setOnClickListener {
            if (valor.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar el valor", Toast.LENGTH_SHORT).show()
            } else {
                val uf = 40877.73
                val valor = valor.text.toString().toDouble() * uf
                val monedaFormateada = NumberFormat.getCurrencyInstance().format(valor)

                tituloCuota.visibility = View.VISIBLE
                textoCuota.text = monedaFormateada
            }
        }

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }
}