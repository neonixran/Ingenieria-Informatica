package com.josue_bravo.ejercicios

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val ejercicio1 = findViewById<Button>(R.id.btnEjercicio1)
        val ejercicio2 = findViewById<Button>(R.id.btnEjercicio2)
        val ejercicio3 = findViewById<Button>(R.id.btnEjercicio3)
        val ejercicio4 = findViewById<Button>(R.id.btnEjercicio4)
        val ejercicio5 = findViewById<Button>(R.id.btnEjercicio5)
        val ejercicio6 = findViewById<Button>(R.id.btnEjercicio6)
        val ejercicio7 = findViewById<Button>(R.id.btnEjercicio7)
        val ejercicio8 = findViewById<Button>(R.id.btnEjercicio8)
        val ejercicio9 = findViewById<Button>(R.id.btnEjercicio9)

        ejercicio1.setOnClickListener {
            startActivity(Intent(this, Ejercicio1Activity::class.java))
            finish()
        }

        ejercicio2.setOnClickListener {
            startActivity(Intent(this, Ejercicio2Activity::class.java))
            finish()
        }

        ejercicio3.setOnClickListener {
            startActivity(Intent(this, Ejercicio3Activity::class.java))
            finish()
        }

        ejercicio4.setOnClickListener {
            startActivity(Intent(this, Ejercicio4Activity::class.java))
            finish()
        }

        ejercicio5.setOnClickListener {
            startActivity(Intent(this, Ejercicio5Activity::class.java))
            finish()
        }

        ejercicio6.setOnClickListener {
            startActivity(Intent(this, Ejercicio6Activity::class.java))
            finish()
        }

        ejercicio7.setOnClickListener {
            startActivity(Intent(this, Ejercicio7Activity::class.java))
            finish()
        }

        ejercicio8.setOnClickListener {
            startActivity(Intent(this, Ejercicio8Activity::class.java))
            finish()
        }

        ejercicio9.setOnClickListener {
            startActivity(Intent(this, Ejercicio9Activity::class.java))
            finish()
        }
    }
}