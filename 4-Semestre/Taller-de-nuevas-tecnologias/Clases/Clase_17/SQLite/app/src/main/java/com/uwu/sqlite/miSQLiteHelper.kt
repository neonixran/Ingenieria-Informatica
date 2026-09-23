package com.uwu.sqlite

import android.content.ContentValues
import android.content.Context
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper


class miSQLiteHelper(context: Context) : SQLiteOpenHelper(
    context, "baseDatos.db", null, 1) {

    override fun onCreate(db: SQLiteDatabase?) {
        db!!.execSQL(
            "CREATE TABLE personas (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "nombres TEXT," +
                    "apellidos TEXT," +
                    "edad INTEGER" +
            ")"
        )
    }

    override fun onUpgrade(db: SQLiteDatabase?, oldVersion: Int, newVersion: Int) {
        db!!.execSQL("DROP TABLE IF EXISTS personas")
        onCreate(db)
    }

    fun anyadirDato(nombres: String, apellidos: String, edad: Int) {
        val datos = ContentValues()
        datos.put("nombres", nombres)
        datos.put("apellidos", apellidos)
        datos.put("edad", edad)

        val db = this.writableDatabase
        db.insert("personas", null, datos)
        db.close()
    }

    fun editarDato(nombres: String, apellidos: String, edad: Int, id: Int){
        val db = this.writableDatabase
        val registro = ContentValues()
        registro.put("nombres", nombres)
        registro.put("apellidos", apellidos)
        registro.put("edad", edad)
        db.update("personas", registro, "id=$id", null)
        db.close()
    }
}