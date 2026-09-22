package com.uwu.ejercicio2

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import org.w3c.dom.Text

class HistoricoActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_historico)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val volver = findViewById<Button>(R.id.btnHistVolver)

        val titulo = findViewById<TextView>(R.id.lblHistDatos)
        val datos = findViewById<TextView>(R.id.txtHistDatos)

        volver.setOnClickListener {
            startActivity(Intent(this, RegistroActivity::class.java))
            finish()
        }

        if (Sesion.listadoHistorico.count() != 0) {
            titulo.text = "Creador - Fecha Hora - Usuario creado"
            for (dato in Sesion.listadoHistorico) {
                datos.append("${dato.getCreador()} - ${dato.getFechaHora()} - ${dato.getUsuario()}\n")
            }
        }
    }
}