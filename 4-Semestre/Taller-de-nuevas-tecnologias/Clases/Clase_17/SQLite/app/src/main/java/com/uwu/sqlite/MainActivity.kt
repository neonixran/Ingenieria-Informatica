package com.uwu.sqlite

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

        val botonInsertar = findViewById<Button>(R.id.btnMenuInsertar)
        val botonConsultar = findViewById<Button>(R.id.btnMenuConsultar)

        botonInsertar.setOnClickListener {
            startActivity(Intent(this, InsertarActivity::class.java))
        }

        botonConsultar.setOnClickListener {
            startActivity(Intent(this, ConsultarActivity::class.java))
        }
    }
}