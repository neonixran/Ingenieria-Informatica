package com.clase10.actividad

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat


class MainActivity : AppCompatActivity() {
    lateinit var rNum1 : TextView
    lateinit var rNum2 : TextView
    lateinit var rNum3 : TextView

    lateinit var operacion : TextView
    lateinit var resultado : TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val num1 = findViewById<EditText>(R.id.txtNum1)
        val num2 = findViewById<EditText>(R.id.txtNum2)
        val num3 = findViewById<EditText>(R.id.txtNum3)

        val calcular = findViewById<Button>(R.id.btnCalcular)

        rNum1 = findViewById(R.id.txtRNum1)
        rNum2 = findViewById(R.id.txtRNum2)
        rNum3 = findViewById(R.id.txtRNum3)
        operacion = findViewById(R.id.txtOperacion)
        resultado = findViewById(R.id.txtResultado)

        calcular.setOnClickListener {
            if (num1.text.isEmpty() && num2.text.isEmpty() && num3.text.isEmpty()) {
                Toast.makeText(this, "Los tres campos no pueden estar vacíos.", Toast.LENGTH_SHORT).show()
            } else if (num1.text.isNotEmpty() && num2.text.isEmpty() && num3.text.isEmpty()) {
                calcular(num1, num2, num3, "${num1.text} * 2", (num1.text.toString().toInt() * 2))
            } else if (num1.text.isEmpty() && num2.text.isNotEmpty() && num3.text.isEmpty()) {
                calcular(num1, num2, num3, "${num2.text} - 10", (num2.text.toString().toInt() - 10))
            } else if (num1.text.isEmpty() && num2.text.isEmpty() && num3.text.isNotEmpty()) {
                calcular(num1, num2, num3, "${num3.text} / 3", (num3.text.toString().toInt() / 3))
            } else if (num1.text.isNotEmpty() && num2.text.isNotEmpty() && num3.text.isEmpty()) {
                calcular(num1, num2, num3, "${num1.text} * ${num2.text}", (num1.text.toString().toInt() * num2.text.toString().toInt()))
            } else if (num1.text.isNotEmpty() && num2.text.isEmpty() && num3.text.isNotEmpty()) {
                calcular(num1, num2, num3, "${num1.text} / ${num3.text}", (num1.text.toString().toInt() / num3.text.toString().toInt()))
            } else if (num1.text.isEmpty() && num2.text.isNotEmpty() && num3.text.isNotEmpty()) {
                calcular(num1, num2, num3, "${num2.text} - ${num3.text}", (num2.text.toString().toInt() - num3.text.toString().toInt()))
            } else if (num1.text.isNotEmpty() && num2.text.isNotEmpty() && num3.text.isNotEmpty()) {
                calcular(num1, num2, num3, "(${num1.text} + ${num2.text}) * 2 / ${num3.text}", ((num1.text.toString().toInt() + num2.text.toString().toInt() * 2) / num3.text.toString().toInt()))
            }
        }
    }

    fun calcular(num1: EditText, num2: EditText, num3: EditText, op: String, res: Int) {
        rNum1.text = num1.text.toString()
        rNum2.text = num2.text.toString()
        rNum3.text = num3.text.toString()
        operacion.text = op
        resultado.text = res.toString()
    }
}