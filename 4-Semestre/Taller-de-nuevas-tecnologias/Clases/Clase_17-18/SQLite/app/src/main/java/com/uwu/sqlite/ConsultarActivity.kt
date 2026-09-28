package com.uwu.sqlite

import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.transition.Visibility
import kotlin.math.log

class ConsultarActivity : AppCompatActivity() {
    private lateinit var personas_list: ListView
    lateinit var personasDBHelper: SQLiteHelper

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_consultar)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        personasDBHelper = SQLiteHelper(this)

        personas_list = findViewById(R.id.personas_list)
        val textoMensaje = findViewById<TextView>(R.id.lblMensaje)

        val botonVolver = findViewById<Button>(R.id.btnConsultarVolver)

        val arrayList = ArrayList<String>()

        val bd = personasDBHelper.writableDatabase
        val fila = bd.rawQuery("SELECT * FROM personas", null)

        while (fila.moveToNext()) {
            val id = fila.getString(0)
            val nombres = fila.getString(1)
            val apellidos = fila.getString(2)
            val edad = fila.getString(3)

            arrayList.add("ID: $id\nNombres: $nombres\nApellidos: $apellidos\nEdad: $edad")
        }

        val arrayAdapter : ArrayAdapter<*> = ArrayAdapter(this, android.R.layout.simple_list_item_1, arrayList)
        personas_list.adapter = arrayAdapter
        bd.close()

        personas_list.setOnItemClickListener { parent, view, position, id ->
            val selectedItem = parent.getItemAtPosition(position) as String
            val datos = selectedItem
                .replace("ID: ", "")
                .replace("Nombres: ", "")
                .replace("Apellidos: ", "")
                .replace("Edad: ", "") // Reemplaza por un string vacío dejando solo el dato (ej. Edad: 20 -> 20)
                .split("\n") // Divide los datos con el delimitador "\n" (ej. ID: 1\nNombres: Juan -> 1, Juan)

            val actividad = Intent(this, EditarActivity::class.java)
            actividad.putExtra("ID", datos[0])
            actividad.putExtra("NOMBRES", datos[1])
            actividad.putExtra("APELLIDOS", datos[2])
            actividad.putExtra("EDAD", datos[3])
            startActivity(actividad)
        }

        botonVolver.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
        }

        personas_list.emptyView = textoMensaje // Si la lista está vacía muestra el mensaje.
    }
}