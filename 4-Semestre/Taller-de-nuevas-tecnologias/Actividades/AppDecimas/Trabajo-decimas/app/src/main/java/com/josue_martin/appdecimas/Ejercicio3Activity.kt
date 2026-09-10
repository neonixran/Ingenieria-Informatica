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

        val num1 = findViewById<EditText>(R.id.txtEj3Num1)

        val calcular = findViewById<Button>(R.id.btnEj3Calcular)
        val limpiar = findViewById<Button>(R.id.btnEj3Clear)

        val resultado = findViewById<TextView>(R.id.txvEj3Result)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
        }

        calcular.setOnClickListener {
            if(num1.text.isEmpty())
            {
                Mensaje("El campo no puede estar vacío")
            }
            else if(converFloat(num1) < 50)
            {
                resultado.text = "${String.format("%.2f", converFloat(num1) * 3)}"
            }
            else
            {
                resultado.text = "${String.format("%.2f", converFloat(num1) / 4)}"
            }
        }

        limpiar.setOnClickListener {
            num1.text.clear()
            resultado.text = ""
        }
    }

    fun Mensaje(msj:String)
    {
        return Toast.makeText(this, msj, Toast.LENGTH_SHORT).show()
    }

    fun converFloat(ent: EditText): Float
    {
        return ent.text.toString().toFloat()
    }
}