package com.example.appspinner.ventas

import android.widget.EditText
import android.widget.Spinner

interface VentasInterface {
    fun cargaCombo(spProductos: Spinner)
    fun guardarDatos(spProductos: Spinner, cant: String)

}