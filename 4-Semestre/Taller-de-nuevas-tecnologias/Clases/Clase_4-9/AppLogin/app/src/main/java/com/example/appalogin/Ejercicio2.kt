package com.example.appalogin

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.Switch
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import org.w3c.dom.Text

class Ejercicio2 : AppCompatActivity() {
    private lateinit var txtNum1: EditText
    private lateinit var txtNum2: EditText
    private lateinit var lblResultado: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio2)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        var menu = findViewById<Button>(R.id.btnEj2Menu);

        txtNum1 = findViewById(R.id.txtEj2Num1)
        txtNum2 = findViewById(R.id.txtEj2Num2)
        lblResultado = findViewById(R.id.lblEj2Resultado)

        var btnSuma = findViewById<Button>(R.id.btnEj2Suma)
        var btnResta = findViewById<Button>(R.id.btnEj2Resta)
        var btnMultiplicacion = findViewById<Button>(R.id.btnEj2Multiplicacion)
        var btnDivision = findViewById<Button>(R.id.btnEj2Division)

        var limpiar = findViewById<Button>(R.id.btnEj2Limpiar)

        menu.setOnClickListener {
            startActivity(Intent(this, Menu::class.java))
            finish()
        }

        limpiar.setOnClickListener {
            txtNum1.text.clear()
            txtNum2.text.clear()
            lblResultado.setText("")
        }

        btnSuma.setOnClickListener {
            operacion("+")
        }

        btnResta.setOnClickListener {
            operacion("-")
        }

        btnMultiplicacion.setOnClickListener {
            operacion("*")
        }

        btnDivision.setOnClickListener {
            operacion("/")
        }
    }

    fun operacion(op: String) {
        if (txtNum1.text.isEmpty() || txtNum2.text.isEmpty())  {
            Toast.makeText(this, "Debe ingresar todos los valores", Toast.LENGTH_SHORT).show()
            return
        }

        var resultado = 0

        when(op) {
            "+" -> resultado = txtNum1.text.toString().toInt() + txtNum2.text.toString().toInt()
            "-" -> resultado = txtNum1.text.toString().toInt() - txtNum2.text.toString().toInt()
            "*" -> resultado = txtNum1.text.toString().toInt() * txtNum2.text.toString().toInt()
            "/" -> resultado = txtNum1.text.toString().toInt() / txtNum2.text.toString().toInt()
            else -> resultado = 0
        }

        lblResultado.text = resultado.toString()
    }
}