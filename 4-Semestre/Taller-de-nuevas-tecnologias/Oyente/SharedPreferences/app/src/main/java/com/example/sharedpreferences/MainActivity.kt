package com.example.sharedpreferences

import android.content.Context
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)

        val sharedPref = getSharedPreferences(
            "Pref1",
            Context.MODE_PRIVATE
        )

        val btnGuardar: Button = findViewById(R.id.btnGuardar)
        val txtSaludo: TextView = findViewById(R.id.txtSaludo)
        val txtNombre: EditText = findViewById(R.id.txtNombre)

        val nombre = sharedPref.getString("nombre", "nn")
        txtSaludo.text = if (nombre == "nn") "No hay datos" else "Hola, $nombre"

        btnGuardar.setOnClickListener {
            val nuevoNombre = txtNombre.text.toString()

            with(sharedPref.edit()) {
                putString("nombre", nuevoNombre)
                apply()
            }

            txtSaludo.text = "Hola, $nuevoNombre"
            Toast.makeText(this, "Se guardó el nuevo nombre", Toast.LENGTH_SHORT).show()
        }
    }
}