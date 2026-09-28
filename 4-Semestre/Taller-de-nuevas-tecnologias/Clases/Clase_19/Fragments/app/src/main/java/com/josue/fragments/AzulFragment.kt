package com.josue.fragments

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment

class AzulFragment : Fragment() {
    private var listener: AccionBotones? = null
    private lateinit var binding: AzulFragment

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        return inflater.inflate(R.layout.fragment_azul, container, false)
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
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