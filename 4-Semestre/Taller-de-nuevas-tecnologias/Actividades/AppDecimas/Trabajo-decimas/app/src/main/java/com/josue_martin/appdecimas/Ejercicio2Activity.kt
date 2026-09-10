package com.josue_martin.appdecimas

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class Ejercicio2Activity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ejercicio2)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val menu = findViewById<Button>(R.id.btnEj2Menu)

        val metros = findViewById<EditText>(R.id.txtEj2Metros)
        val min = findViewById<EditText>(R.id.txtEjer2Min)
        val segun = findViewById<EditText>(R.id.txtEj2Seg)
        val cent = findViewById<EditText>(R.id.txtEj2Cen)

        val calcular = findViewById<Button>(R.id.btnEj2Calcular)
        val limpiar = findViewById<Button>(R.id.btnEj2Clear)

        val resultado = findViewById<TextView>(R.id.txvEj2Resul)

        menu.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
        }

        calcular.setOnClickListener {

            if(metros.text.isEmpty() || min.text.isEmpty() || segun.text.isEmpty() || cent.text.isEmpty())
            {
                Mensaje("Los campos no pueden estar vacios")
            }
            else if(converInt(metros) <= 0)
            {
                Mensaje("Los metros deben ser mayor a 0")
            }
            else if(converInt(min) == 0 && converInt(segun) == 0 && converInt(cent) == 0)
            {
                Mensaje("Los campos de tiempo no pueden ser todos 0")
            }
            else
            {
                var respuesta = KilometrosHora(converInt(metros), converInt(min),
                                            converInt(segun), converInt(cent))

                resultado.text = "${String.format("%.3f", respuesta)} Km/Hr"
            }
        }

        limpiar.setOnClickListener {
            metros.text.clear()
            min.text.clear()
            segun.text.clear()
            cent.text.clear()
            resultado.text = ""
        }

    }

    fun KilometrosHora(met: Int, minu: Int, seg: Int, centesimas: Int): Double
    {
        var distancia = met / 1000.0
        var tiempo = (minu / 60.0) + (seg / (60.0 * 60.0)) + (centesimas / (100.0 * 60.0 * 60.0))

        return distancia / tiempo
    }

    fun converInt(ent: EditText): Int
    {
        return ent.text.toString().toInt()
    }

    fun Mensaje(msj:String)
    {
        return Toast.makeText(this, msj, Toast.LENGTH_SHORT).show()
    }
}