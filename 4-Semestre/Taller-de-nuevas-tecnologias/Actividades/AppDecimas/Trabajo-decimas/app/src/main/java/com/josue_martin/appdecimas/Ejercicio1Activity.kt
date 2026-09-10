package com.josue_martin.appdecimas

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
import java.text.NumberFormat

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

        val minutos = findViewById<EditText>(R.id.txtEj1Minutos)

        val calcular = findViewById<Button>(R.id.btnEj1Calcular)
        val limpiar = findViewById<Button>(R.id.btnEj1Limpiar)

        val parquimetro = findViewById<TextView>(R.id.txtEj1Parquimetro)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
        }

        calcular.setOnClickListener {
            if (minutos.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar los minutos", Toast.LENGTH_SHORT).show()
            } else {
                val min = minutos.text.toString().toLong()
                val valorParquimetro = 2850

                if (min <= 25) {
                    parquimetro.text = NumberFormat.getCurrencyInstance().format(valorParquimetro)
                } else {
                    parquimetro.text = NumberFormat.getCurrencyInstance().format(valorParquimetro + ((min - 25) * 28))
                }
            }
        }

        limpiar.setOnClickListener {
            minutos.text.clear()
            parquimetro.text = ""
        }
    }
}