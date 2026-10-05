package com.example.appspinner.ventas

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.appspinner.listado.ListaFragment
import com.example.appspinner.R
import com.example.appspinner.databinding.FragmentVentaInsertarBinding

class VentaInsertarFragment : Fragment() {

    private var listener: VentasInterface? = null
    private lateinit var binding : FragmentVentaInsertarBinding

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        binding  = FragmentVentaInsertarBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        listener?.cargaCombo(binding.spProductos)

        binding.btnVentaGuardar.setOnClickListener {
            val spinner = binding.spProductos
            val cantidad = binding.txtCantidad.text.toString()

            listener?.guardarDatos(spinner, cantidad)
            recargaListado()
        }

        binding.btnVentaLimpiar.setOnClickListener {
            binding.txtCantidad.text.clear()
        }
    }
    fun recargaListado(){
        val transaction = requireActivity().supportFragmentManager.beginTransaction()
        transaction.replace(R.id.fragListado2, ListaFragment())
        transaction.commit()
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)

        if (context is VentasInterface) {
            listener = context
        }
    }
    override fun onDetach() {
        super.onDetach()
        listener = null
    }
}