package com.example.appalogin

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.CheckBox
import android.widget.EditText
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Ejercicio1 : AppCompatActivity() {
    private lateinit var nombre: EditText
    private lateinit var edad: EditText
    private lateinit var estado: CheckBox

    private lateinit var nombre_final: TextView
    private lateinit var edad_final: TextView
    private lateinit var estado_final: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio1)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var menu = findViewById<Button>(R.id.btnEj1Menu)
        var limpiar = findViewById<Button>(R.id.btnEj1Limpiar)
        var guardar = findViewById<Button>(R.id.btnEj1Guardar)

        nombre = findViewById(R.id.txtEj1Nombre)
        edad = findViewById(R.id.txtEj1Edad)
        estado = findViewById(R.id.chkEj1Estado)

        nombre_final = findViewById(R.id.lblEj1Nombre)
        edad_final = findViewById(R.id.lblEj1Edad)
        estado_final = findViewById(R.id.lblEj1Estado)

        inicializar()

        menu.setOnClickListener {
            startActivity(Intent(this, Menu::class.java))
            finish()
        }

        limpiar.setOnClickListener {
            inicializar()
        }

        guardar.setOnClickListener {
            nombre_final.text = "Nombre: " + nombre.text
            edad_final.text = "Edad: ${edad.text}"

            if (estado.isChecked) {
                estado_final.text = "Estado: habilitado"
            } else {
                estado_final.text = "Estado: deshabilitado"
            }

        }
    }

    fun inicializar() {
        nombre.text.clear()
        edad.text.clear()
        estado.isChecked = false

        nombre_final.text = "Nombre:"
        edad_final.text = "Edad:"
        estado_final.text = "Estado:"
    }
}