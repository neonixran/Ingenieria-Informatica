package com.example.appalogin

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Menu : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_menu)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var btnUsuarios = findViewById<Button>(R.id.btnMenuUsuarios);
        var btnEjercicio1 = findViewById<Button>(R.id.btnMenuEj1);
        var btnEjercicio2 = findViewById<Button>(R.id.btnMenuEj2);
        var btnSalir = findViewById<Button>(R.id.btnMenuSalir)

        var bienvenida = findViewById<TextView>(R.id.lblMenuBienvenida)

        bienvenida.text = "Bienvenido, ${usuario_login}"

        btnUsuarios.setOnClickListener {
            startActivity(Intent(this, Usuarios::class.java));
            finish();
        }

        btnEjercicio1.setOnClickListener {
            startActivity(Intent(this, Ejercicio1::class.java));
            finish();
        }

        btnEjercicio2.setOnClickListener {
            startActivity(Intent(this, Ejercicio2::class.java));
            finish();
        }

        btnSalir.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java));
            finish();
        }
    }
}