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

class Ejercicio1Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio1)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj1Menu)

        val num1 = findViewById<EditText>(R.id.txtEj1Num1)
        val num2 = findViewById<EditText>(R.id.txtEj1Num2)
        val calcular = findViewById<Button>(R.id.btnEj1Calcular)

        val tituloResultado = findViewById<TextView>(R.id.lblEj1Resultado)
        val textoResultado = findViewById<TextView>(R.id.txtEj1Resultado)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        calcular.setOnClickListener {
            if (num1.text.isEmpty() || num2.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar ambos números para calcular", Toast.LENGTH_SHORT).show()
            } else {
                tituloResultado.visibility = View.VISIBLE
                textoResultado.text = (num1.text.toString().toInt() + num2.text.toString().toInt()).toString()
            }
        }
    }
}