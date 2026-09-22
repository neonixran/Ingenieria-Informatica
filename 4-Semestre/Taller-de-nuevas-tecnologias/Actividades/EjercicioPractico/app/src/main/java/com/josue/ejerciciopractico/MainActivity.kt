package com.josue.ejerciciopractico

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private var listado :  ArrayList<Datos> = ArrayList()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val texto = findViewById<EditText>(R.id.txtTexto)
        val click = findViewById<Button>(R.id.btnClick)

        click.setOnClickListener {
            val dato = texto.text.toString()

            listado.add(Datos(dato))

            var res  = ""
            for (item in listado) {
                res += item.getDatito() + "\n"
            }

            Toast.makeText(this, res, Toast.LENGTH_SHORT).show()
        }
    }
}