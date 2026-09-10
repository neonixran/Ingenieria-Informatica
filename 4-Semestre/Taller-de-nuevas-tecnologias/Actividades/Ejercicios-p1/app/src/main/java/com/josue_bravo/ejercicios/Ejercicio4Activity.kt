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
import org.w3c.dom.Text
import kotlin.math.pow

class Ejercicio4Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio4)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj4Menu)

        val masa = findViewById<EditText>(R.id.txtEj4Masa)
        val estatura = findViewById<EditText>(R.id.txtEj4Estatura)
        val calcular = findViewById<Button>(R.id.btnEj4Calcular)

        val tituloImc = findViewById<TextView>(R.id.lblEj4IMC)
        val textoImc = findViewById<TextView>(R.id.txtEj4IMC)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        calcular.setOnClickListener {
            if (masa.text.isEmpty() && estatura.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar la masa y la estatura", Toast.LENGTH_SHORT).show()
            } else {
                val imc = masa.text.toString().toDouble() / (estatura.text.toString().toDouble() / 100).pow(2.0)

                tituloImc.visibility = View.VISIBLE
                textoImc.text = String.format("%.1f", imc)
            }
        }
    }
}