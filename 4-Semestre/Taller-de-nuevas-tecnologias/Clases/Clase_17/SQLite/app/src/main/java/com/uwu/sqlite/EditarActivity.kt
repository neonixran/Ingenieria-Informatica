package com.uwu.sqlite

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class EditarActivity : AppCompatActivity() {
    lateinit var personasDBHelper: SQLiteHelper

    lateinit var textoNombres : EditText
    lateinit var textoApellidos : EditText
    lateinit var textoEdad : EditText

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_editar)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        personasDBHelper = SQLiteHelper(this)

        val botonVolver = findViewById<Button>(R.id.btnEditarVolver)

        val textoId = findViewById<EditText>(R.id.txtEditarId)
        textoNombres = findViewById(R.id.txtEditarNombres)
        textoApellidos = findViewById(R.id.txtEditarApellidos)
        textoEdad = findViewById(R.id.txtEditarEdad)

        val botonLimpiar = findViewById<Button>(R.id.btnEditarLimpiar)
        val botonEditar = findViewById<Button>(R.id.btnEditar)
        val botonEliminar = findViewById<Button>(R.id.btnEditarEliminar)

        // Asignar cada dato que llego del elemento seleccionado en el MainActivity
        textoId.setText(intent.getStringExtra("ID"))
        textoNombres.setText(intent.getStringExtra("NOMBRES"))
        textoApellidos.setText(intent.getStringExtra("APELLIDOS"))
        textoEdad.setText(intent.getStringExtra("EDAD"))

        botonVolver.setOnClickListener {
            volver()
        }

        botonLimpiar.setOnClickListener {
            limpiarDatos()
        }

        botonEditar.setOnClickListener {
            val id = textoId.text.toString().toInt()
            val nombres = textoNombres.text.toString()
            val apellidos = textoApellidos.text.toString()
            val edad = textoEdad.text.toString()

            val tituloMensaje = "Para poder editar este registro, debe ingresar:\n"
            var mensaje = tituloMensaje

            if (nombres.isEmpty()) {
                mensaje += "- Sus nombres:\n"
            }

            if (apellidos.isEmpty()) {
                mensaje += "- Sus apellidos\n"
            }

            if (edad.isEmpty()) {
                mensaje += "- Su edad"
            }

            if (!mensaje.matches(Regex(tituloMensaje))) {
                AlertDialog.Builder(this)
                    .setMessage(mensaje)
                    .setPositiveButton("Ok") { dialog, id ->
                        dialog.dismiss()
                    }
                    .create()
                    .show()
            } else {
                personasDBHelper.editarRegistro(nombres, apellidos, edad.toInt(), id)
                limpiarDatos()
                Toast.makeText(this, "Editado exitosamente", Toast.LENGTH_SHORT).show()

                volver()
            }


        }

        botonEliminar.setOnClickListener {
            AlertDialog.Builder(this)
                .setMessage("¿Está seguro de eliminar este registro?")
                .setPositiveButton("Sí") { dialog, id ->
                    val id = textoId.text.toString().toInt()
                    personasDBHelper.eliminarRegistro(id)

                    dialog.dismiss()
                    volver()
                }
                .setNegativeButton("No") { dialog, id ->
                    dialog.dismiss()
                }
                .create()
                .show()
        }
    }

    fun limpiarDatos() {
        textoNombres.text.clear()
        textoApellidos.text.clear()
        textoEdad.text.clear()
    }

    fun volver() {
        startActivity(Intent(this, ConsultarActivity::class.java))
    }
}