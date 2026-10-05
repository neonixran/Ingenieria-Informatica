package com.example.appspinner.ventas

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.Spinner
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.appspinner.MainActivity
import com.example.appspinner.listado.ListadosFragment
import com.example.appspinner.R
import com.example.appspinner.SQLiteHelper

class VentasActivity : AppCompatActivity(), ListadosFragment, VentasInterface {

    lateinit var datosDBHelper: SQLiteHelper

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_venta)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        datosDBHelper = SQLiteHelper(this)

        val btnVolver = findViewById<Button>(R.id.btnVolverVenta)

        btnVolver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
            finish()
        }
    }

    override fun cargaListado(listView: ListView) {
        val arraylist = ArrayList<String>()

        val bd = SQLiteHelper(this).writableDatabase
        val fila = bd.rawQuery("SELECT v.id_venta, v.id, p.nombre, p.precio, v.cantidad, " +
                "(p.precio*v.cantidad) as vendido" +
                " FROM ventas v" +
                " INNER JOIN productos p on p.id = v.id", null)

        while (fila.moveToNext()) {
            val idVenta = fila.getString(0)
            val idProducto = fila.getString(1)
            val producto = fila.getString(2)
            val precio = fila.getString(3)
            val cantidad = fila.getString(4)
            val totalVendido = fila.getString(5)

            arraylist.add("ID Ventas: $idVenta\nID Producto: $idProducto\nProducto: $producto\nPrecio unitario: $precio\nCantidad: $cantidad\nTotal: $totalVendido")
        }

        bd.close()

        listView.adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, arraylist)
    }

    override fun cargaCombo(spProductos: Spinner) {
        val arraylist = ArrayList<String>()

        val bd = SQLiteHelper(this).writableDatabase
        val fila = bd.rawQuery("SELECT * FROM Productos", null)

        while (fila.moveToNext()) {
            arraylist.add("${fila.getString(0)} - ${fila.getString(1)}")
        }

        bd.close()

        val adaptador = ArrayAdapter(this, android.R.layout.simple_spinner_item, arraylist)
        adaptador.setDropDownViewResource(android.R.layout.simple_spinner_item)

        spProductos.adapter = adaptador
    }

    override fun guardarDatos(spProductos: Spinner, cant: String) {
        if (cant.isEmpty()) {
            val builder = AlertDialog.Builder(this)
                .setMessage("Debe ingresar todos los datos")
                .setCancelable(false)
                .setPositiveButton("OK") { dialog, id ->
                    dialog.dismiss()
                }

            val alert = builder.create()
            alert.show()
        } else {
            val spinner = spProductos.selectedItem.toString()
            val datos = spinner.split(" - ")

            val idProducto = datos[0].toInt()
            val cantidad = cant.toInt()

            datosDBHelper.agregarVenta(idProducto, cantidad)

            Toast.makeText(this, "Guardado correctamente", Toast.LENGTH_SHORT).show()
        }
    }
}