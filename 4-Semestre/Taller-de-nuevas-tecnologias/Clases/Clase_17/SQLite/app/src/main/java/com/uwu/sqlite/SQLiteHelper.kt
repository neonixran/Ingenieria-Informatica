package com.uwu.sqlite

import android.content.ContentValues
import android.content.Context
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper

private val NOMBRE_BD = "baseDatos.db"
private val VERSION = 1

class SQLiteHelper(context: Context) : SQLiteOpenHelper(
    context,
    NOMBRE_BD,
    null,
    VERSION
) {
    private val NOMBRE_TABLA = "personas"
    override fun onCreate(db: SQLiteDatabase?) {
        db!!.execSQL(
            "CREATE TABLE $NOMBRE_TABLA (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombres TEXT," +
                    "apellidos TEXT," +
                    "edad INTEGER" +
            ")"
        )
    }

    // Este se ejecuta siempre que se cambia la versión.
    override fun onUpgrade(db: SQLiteDatabase?, oldVersion: Int, newVersion: Int) {
        db!!.execSQL("DROP TABLE IF EXISTS $NOMBRE_TABLA")
        onCreate(db)
    }

    fun anadirRegistro(nombres: String, apellidos: String, edad: Int) {
        val db = this.writableDatabase

        val datos = ContentValues()
        datos.put("nombres", nombres)
        datos.put("apellidos", apellidos)
        datos.put("edad", edad)

        db.insert(NOMBRE_TABLA, null, datos)
        db.close()
    }

    fun editarRegistro(nombres: String, apellidos: String, edad: Int, id: Int){
        val db = this.writableDatabase

        val registro = ContentValues()
        registro.put("nombres", nombres)
        registro.put("apellidos", apellidos)
        registro.put("edad", edad)

        db.update(NOMBRE_TABLA, registro, "id=$id", null)
        db.close()
    }

    fun eliminarRegistro(id: Int) {
        val db = this.writableDatabase

        db.delete(NOMBRE_TABLA, "id=$id", null)
        db.close()
    }
}