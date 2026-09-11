package com.example.ejemplo

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private var listado: ArrayList<Datos> = ArrayList()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val enviar = findViewById<Button>(R.id.btnClick)
        val texto = findViewById<EditText>(R.id.txtTexto)
        val datos = findViewById<ListView>(R.id.lstDatos)

        var adaptador: ArrayAdapter<*>
        val arrayList = ArrayList<String>()

        enviar.setOnClickListener {
            val dato = texto.text.toString()

            if (!dato.isEmpty()) {
                AlertDialog.Builder(this).setMessage("¿Desea guardar el valor ingresado?")
                    .setCancelable(false)
                    .setNegativeButton("No") { dialog, _ ->
                        dialog.dismiss()
                    }
                    .setPositiveButton("Sí") { dialog, _ ->
                        listado.add(Datos(dato)) // Guarda
                        arrayList.clear()

                        for(item in listado){
                            arrayList.add(item.getDatito())
                        }

                        adaptador = ArrayAdapter(this,
                            android.R.layout.simple_list_item_1,
                            arrayList
                        )

                        datos.adapter = adaptador
                        texto.text.clear()
                        dialog.dismiss()
                    }.create().show()
            } else {
                Toast.makeText(this, "Debe ingresar un valor", Toast.LENGTH_SHORT).show()
            }
        }
    }
}