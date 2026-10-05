package com.example.appspinner

import android.content.Intent
import android.graphics.Color
import android.os.Bundle
import android.view.Gravity
import android.widget.Button
import android.widget.TableLayout
import android.widget.TableRow
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.appspinner.productos.ProductosActivity
import org.w3c.dom.Text

class TablaDatosActivity : AppCompatActivity() {
    lateinit var datosDBHelper : SQLiteHelper

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_tabla_datos)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        datosDBHelper = SQLiteHelper(this)

        val btnVolver = findViewById<Button>(R.id.btnTablaVolver)
        val tbDatos =  findViewById<TableLayout>(R.id.tbDatos)

        cargaTabla(tbDatos)

        btnVolver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }

    fun cargaTabla(tabla: TableLayout) {
        val cabecera = TableRow(this)

        val cabeceraId = TextView(this)
        val cabeceraNombre = TextView(this)
        val cabeceraPrecio = TextView(this)

        cabeceraId.text = "ID"
        cabeceraId.width = 200
        cabeceraId.textSize = 20.toFloat()
        cabeceraId.gravity = Gravity.CENTER
        cabeceraId.setTextColor(Color.WHITE)
        cabeceraId.setBackgroundColor(Color.BLACK)

        cabeceraNombre.text = "Nombre"
        cabeceraNombre.width = 400
        cabeceraNombre.textSize = 20.toFloat()
        cabeceraNombre.gravity = Gravity.END
        cabeceraNombre.setTextColor(Color.WHITE)
        cabeceraNombre.setBackgroundColor(Color.BLACK)

        cabeceraPrecio.text = "Precio"
        cabeceraPrecio.width = 800
        cabeceraPrecio.textSize = 20.toFloat()
        cabeceraPrecio.gravity = Gravity.CENTER
        cabeceraPrecio.setTextColor(Color.WHITE)
        cabeceraPrecio.setBackgroundColor(Color.BLACK)

        cabecera.addView(cabeceraId)
        cabecera.addView(cabeceraNombre)
        cabecera.addView(cabeceraPrecio)

        tabla.addView(cabecera)

        // Añadimos las filas desde la Base de Datos
        val bd = datosDBHelper.writableDatabase

        val filas = bd.rawQuery("SELECT * FROM productos", null)

        while (filas.moveToNext()) {
            val fila = TableRow(this)

            val contenidoId = TextView(this)
            val contenidoNombre = TextView(this)
            val contenidoPrecio = TextView(this)

            contenidoId.text = filas.getString(0)
            contenidoId.width = 200
            contenidoId.textSize = 15.toFloat()
            contenidoId.gravity = Gravity.CENTER
            contenidoId.setTextColor(Color.WHITE)
            contenidoId.setBackgroundColor(Color.DKGRAY)

            contenidoNombre.text = filas.getString(1)
            contenidoNombre.width = 400
            contenidoNombre.textSize = 15.toFloat()
            contenidoNombre.gravity = Gravity.END
            contenidoNombre.setTextColor(Color.WHITE)
            contenidoNombre.setBackgroundColor(Color.DKGRAY)

            contenidoPrecio.text = "$${filas.getString(2)}"
            contenidoPrecio.width = 800
            contenidoPrecio.textSize = 15.toFloat()
            contenidoPrecio.gravity = Gravity.CENTER
            contenidoPrecio.setTextColor(Color.WHITE)
                contenidoPrecio.setBackgroundColor(Color.DKGRAY)

            fila.addView(contenidoId)
            fila.addView(contenidoNombre)
            fila.addView(contenidoPrecio)

            tabla.addView(fila)
        }
    }
}