package com.example.appspinner.productos

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.appspinner.listado.ListadosFragment
import com.example.appspinner.MainActivity
import com.example.appspinner.R
import com.example.appspinner.SQLiteHelper

class ProductosActivity : AppCompatActivity(), ProductosInterface, ListadosFragment {
    lateinit var datosDBHelper: SQLiteHelper
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_productos)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        datosDBHelper = SQLiteHelper(this)

        val btnVolver = findViewById<Button>(R.id.btnVolverProducto)

        btnVolver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }

    override fun insertarDatos(nombre: String, precio: String, id: Int) {
        try {
            if (nombre.isEmpty() || precio.isEmpty()) {
                val builder = AlertDialog.Builder(this)
                    .setMessage("Debe ingresar todos los datos")
                    .setCancelable(false)
                    .setPositiveButton("OK") { dialog, id ->
                        dialog.dismiss()
                    }

                val alert = builder.create()
                alert.show()
            } else {
                datosDBHelper.agregarProducto(nombre, precio.toInt())
                Toast.makeText(this, "Guardado con exito", Toast.LENGTH_SHORT).show()
            }
        } catch (e: Exception) {
            Toast.makeText(this, e.toString(), Toast.LENGTH_SHORT).show()
        }
    }

    override fun cargaListado(listView: ListView) {
        val arraylist = ArrayList<String>()

        val bd = SQLiteHelper(this).writableDatabase
        val fila = bd.rawQuery("SELECT * FROM productos", null)

        while (fila.moveToNext()) {
            arraylist.add("ID: ${fila.getString(0)}\nNombre: ${fila.getString(1)}\nPrecio: ${fila.getString(2)}")
        }

        bd.close()

        listView.adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, arraylist)
    }

}