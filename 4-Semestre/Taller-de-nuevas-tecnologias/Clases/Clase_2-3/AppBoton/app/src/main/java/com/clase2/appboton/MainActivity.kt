package com.clase2.appboton

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
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

        var boton = findViewById<Button>(R.id.btnClick) // solo la llamada al elementop
        var texto = findViewById<EditText>(R.id.txtTexto)

        var siguiente = findViewById<Button>(R.id.btnSiguiente)

        // evento click
        boton.setOnClickListener {
            carga(texto.text.toString())
            texto.text.clear()
        }

        siguiente.setOnClickListener {
            var pantalla2 = Intent(this, Pantalla2::class.java)

            // Enviar valores
            pantalla2.putExtra("id", 1)
            pantalla2.putExtra("texto", texto.text.toString())

            // Abrir pantalla
            startActivity(pantalla2)
        }
    }

    fun carga(mensaje: String) {
        Toast.makeText(this, mensaje, Toast.LENGTH_LONG).show()
    }
}