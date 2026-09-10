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
import java.text.NumberFormat

class Ejercicio9Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio9)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj9Menu)

        val venta1 = findViewById<EditText>(R.id.txtEj9Venta1)
        val venta2 = findViewById<EditText>(R.id.txtEj9Venta2)
        val venta3 = findViewById<EditText>(R.id.txtEj9Venta3)

        val calcular = findViewById<Button>(R.id.btnEj9Calcular)
        val sueldo = findViewById<TextView>(R.id.txtEj9Sueldo)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }

        calcular.setOnClickListener {
            if (venta1.text.isEmpty() || venta2.text.isEmpty() || venta3.text.isEmpty()) {
                Toast.makeText(this, "Debe ingresar las ventas", Toast.LENGTH_SHORT).show()
            } else {
                val sueldoBase = 300000
                val porcentajeVenta1 = venta1.text.toString().toDouble() * 0.12
                val porcentajeVenta2 = venta2.text.toString().toDouble() * 0.12
                val porcentajeVenta3 = venta3.text.toString().toDouble() * 0.12
                val sueldoNeto = sueldoBase + porcentajeVenta1 + porcentajeVenta2 + porcentajeVenta3

                val monedaFormateada = NumberFormat.getCurrencyInstance().format(sueldoNeto)

                sueldo.text = "Su sueldo neto es de ${monedaFormateada}"
            }
        }
    }
}