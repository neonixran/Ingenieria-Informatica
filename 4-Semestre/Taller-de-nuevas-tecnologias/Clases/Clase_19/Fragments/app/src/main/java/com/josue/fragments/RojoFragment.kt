package com.josue.fragments

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.josue.fragments.databinding.FragmentRojoBinding


class RojoFragment : Fragment() {
    private var listener: EventosFragment? = null
    private lateinit var binding: FragmentRojoBinding

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View {
        binding = FragmentRojoBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.btnRojo.setOnClickListener {
            listener?.onClickFragmentButton("Rojo")
        }
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)

        if (context is EventosFragment) {
            listener = context
        }
    }

    override fun onDetach() {
        super.onDetach()
        listener = null
    }
}