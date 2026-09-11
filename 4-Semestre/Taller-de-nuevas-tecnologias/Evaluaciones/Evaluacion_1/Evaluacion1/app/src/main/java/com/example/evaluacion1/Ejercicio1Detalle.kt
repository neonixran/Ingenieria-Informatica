package com.example.evaluacion1

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Ejercicio1Detalle : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio1_detalle)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val nombre = findViewById<TextView>(R.id.txvNombre)
        val edad = findViewById<TextView>(R.id.txvEdad)
        val area = findViewById<TextView>(R.id.txvArea)

        val volver = findViewById<Button>(R.id.btnVolver)

        val nombre_ = intent.getStringExtra("NOMBRE")
        val edad_ = intent.getStringExtra("EDAD")
        val area_ = intent.getStringExtra("AREA")

        nombre.text = "Nombre: ${nombre_}"
        edad.text = "Edad: ${edad_}"

        if (area_.equals("")) {
            area.text = "Área: SIN ÁREA"
        } else {
            area.text = "Área: ${area_}"
        }

        volver.setOnClickListener {
            startActivity(Intent(this, Ejercicio1::class.java))
            finish()
        }
    }
}