package com.josue.fragments

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.josue.fragments.databinding.FragmentAzulBinding

class AzulFragment : Fragment() {
    private var listener: AccionBotones? = null
    private lateinit var binding: FragmentAzulBinding

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentAzulBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.btnAzul.setOnClickListener {
            listener?.onClickFragmentButton("Azul")
        }
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)

        if (context is AccionBotones) {
            listener = context
        }
    }

    override fun onDetach() {
        super.onDetach()
        listener = null
    }
}