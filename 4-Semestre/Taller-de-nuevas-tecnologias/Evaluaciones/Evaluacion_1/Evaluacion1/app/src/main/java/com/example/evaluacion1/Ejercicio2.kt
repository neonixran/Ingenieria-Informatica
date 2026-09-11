package com.example.evaluacion1

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

class Ejercicio2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio2)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val sueldoBruto = findViewById<EditText>(R.id.txtSueldo)

        val sueldo = findViewById<TextView>(R.id.txvSueldo)
        val afp = findViewById<TextView>(R.id.txtAFP)
        val salud = findViewById<TextView>(R.id.txvSalud)

        val calcular = findViewById<Button>(R.id.btnCalcular)
        val volver = findViewById<Button>(R.id.btnVolver)

        volver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        calcular.setOnClickListener {
            val sueldoBruto_ = sueldoBruto.text.toString()

            if (sueldoBruto_.isEmpty()) {
                Toast.makeText(this, "Debe ingresar su sueldo bruto", Toast.LENGTH_SHORT).show()
            } else {
                val sueldoAnual = sueldoBruto_.toInt() * 12

                val afp_ = sueldoAnual * 0.07
                val salud_ = sueldoAnual * 0.1
                val sueldoLiquido_ =  sueldoAnual - (afp_ + salud_)

                sueldo.text = "Sueldo anual: ${sueldoLiquido_}"
                afp.text = "AFP anual (7%): ${afp_}"
                salud.text = "Salud anual (10%): ${salud_}"
            }
        }
    }
}