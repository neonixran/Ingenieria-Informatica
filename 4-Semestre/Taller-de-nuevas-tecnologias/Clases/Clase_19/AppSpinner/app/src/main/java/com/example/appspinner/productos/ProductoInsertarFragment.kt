package com.example.appspinner.productos

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.appspinner.listado.ListaFragment
import com.example.appspinner.R
import com.example.appspinner.databinding.FragmentProductoInsertarBinding

class ProductoInsertarFragment : Fragment() {
    private var listener: ProductosInterface? = null
    private lateinit var binding : FragmentProductoInsertarBinding

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        binding  = FragmentProductoInsertarBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.btnProductoLimpiar.setOnClickListener {
            limpiarFormulario()
        }

        binding.btnProductoInsertar.setOnClickListener {
            val producto = binding.txtProducto.text.toString()
            val precio = binding.txtPrecio.text.toString()

            listener?.insertarDatos(producto, precio, 0)

            recargaListado()
            limpiarFormulario()
        }
    }
    fun recargaListado() {
        val transaction = requireActivity().supportFragmentManager.beginTransaction()
        transaction.replace(R.id.fragListado, ListaFragment())
        transaction.commit()
    }

    fun limpiarFormulario() {
        binding.txtProducto.text.clear()
        binding.txtPrecio.text.clear()
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)

        if (context is ProductosInterface) {
            listener = context
        }
    }

    override fun onDetach() {
        super.onDetach()
        listener = null
    }
}