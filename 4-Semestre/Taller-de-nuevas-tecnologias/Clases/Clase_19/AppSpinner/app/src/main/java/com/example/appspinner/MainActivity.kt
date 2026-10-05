package com.example.appspinner

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.appspinner.productos.ProductosActivity
import com.example.appspinner.ventas.VentasActivity

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

        val btnProductos = findViewById<Button>(R.id.btnProductos)
        val btnVentas = findViewById<Button>(R.id.btnVenta)
        val btnTabla = findViewById<Button>(R.id.btnTabla)

        btnProductos.setOnClickListener {
            startActivity(Intent(this, ProductosActivity::class.java))
            finish()
        }

        btnVentas.setOnClickListener {
            startActivity(Intent(this, VentasActivity::class.java))
            finish()
        }

        btnTabla.setOnClickListener {
            startActivity(Intent(this, TablaDatosActivity::class.java))
            finish()
        }
    }
}