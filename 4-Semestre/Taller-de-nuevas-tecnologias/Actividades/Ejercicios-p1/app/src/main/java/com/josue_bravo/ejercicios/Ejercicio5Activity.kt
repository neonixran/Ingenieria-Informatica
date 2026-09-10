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
import kotlin.math.pow

class Ejercicio5Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio5)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj5Menu)

        val sueldo = findViewById<EditText>(R.id.txtEj5Sueldo)
        val calcular = findViewById<Button>(R.id.btnEj5Calcular)

        val tituloAnual = findViewById<TextView>(R.id.lblEj5Anual)
        val textoAnual = findViewById<TextView>(R.id.txtEj5Anual)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        calcular.setOnClickListener {
            if (sueldo.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su sueldo", Toast.LENGTH_SHORT).show()
            } else {
                val valor = sueldo.text.toString().toDouble() * 12
                val monedaFormateada = NumberFormat.getCurrencyInstance().format(valor)

                tituloAnual.visibility = View.VISIBLE
                textoAnual.text = monedaFormateada
            }
        }
    }
}