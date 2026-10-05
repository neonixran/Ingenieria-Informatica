package com.example.appspinner


import android.content.ContentValues
import android.content.Context
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper


class SQLiteHelper(context: Context) : SQLiteOpenHelper(
    context, "baseDatos.db", null, 1) {

    override fun onCreate(db: SQLiteDatabase?) {
        val productos = "CREATE TABLE productos " +
                "(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "nombre TEXT, precio INTEGER)"
        db!!.execSQL(productos)

        val venta = "CREATE TABLE ventas " +
                "(id_venta INTEGER PRIMARY KEY AUTOINCREMENT," +
                "id INTEGER, cantidad INTEGER)"
        db.execSQL(venta)
    }

    override fun onUpgrade(db: SQLiteDatabase?, oldVersion: Int, newVersion: Int) {
        val productosBorrado = "DROP TABLE IF EXISTS productos"
        db!!.execSQL(productosBorrado)
        onCreate(db)

        val ventasBorrado = "DROP TABLE IF EXISTS ventas"
        db.execSQL(ventasBorrado)
        onCreate(db)
    }

    fun agregarProducto(nombre: String, precio: Int) {
        val datos = ContentValues()
        datos.put("nombre", nombre)
        datos.put("precio", precio)

        val db = this.writableDatabase
        db.insert("productos", null, datos)
        db.close()
    }

    fun editarProducto(nombre: String, precio: Int, id: Int){
        val db = this.writableDatabase
        val registro = ContentValues()
        registro.put("nombre", nombre)
        registro.put("precio", precio)
        db.update("productos", registro, "id=$id", null)
        db.close()
    }

    fun agregarVenta(id: Int, cantidad: Int) {
        val datos = ContentValues()
        datos.put("id", id)
        datos.put("cantidad", cantidad)

        val db = this.writableDatabase
        db.insert("ventas", null, datos)
        db.close()
    }

    fun editarVenta(id: Int, cantidad: Int, id_venta: Int){
        val db = this.writableDatabase
        val registro = ContentValues()
        registro.put("id", id)
        registro.put("cantidad", cantidad)
        db.update("ventas", registro, "id_venta=$id_venta", null)
        db.close()
    }

}