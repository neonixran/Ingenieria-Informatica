package com.josue.jetpackcompose

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.CenterAlignedTopAppBar
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.ui.graphics.Color
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.saveable.rememberSaveable
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import com.josue.jetpackcompose.ui.theme.JetpackComposeTheme

class MainActivity : ComponentActivity() {
    @OptIn(ExperimentalMaterial3Api::class)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            JetpackComposeTheme {
                Scaffold(modifier = Modifier.fillMaxSize(), topBar = {
                    CenterAlignedTopAppBar(
                        title = {
                            Text("Mi app compose")
                        },
                        colors = TopAppBarDefaults.topAppBarColors(
                            containerColor = MaterialTheme.colorScheme.primary,
                            titleContentColor = Color.White,
                            actionIconContentColor = Color.White
                        )
                    )
                }) { innerPadding ->
                    ListaColores(
                        modifier = Modifier
                            .fillMaxSize()
                            .padding(innerPadding)
                    )
                }
            }
        }
    }
}

@Composable
fun ListaColores(modifier: Modifier = Modifier) {
    val items = listOf("Rojo", "Verde", "Azul", "Amarillo")
    var selectedItem by rememberSaveable { mutableStateOf<String?>(null) }

    LazyColumn(
        modifier = modifier,
        verticalArrangement = Arrangement.Center,
        horizontalAlignment = Alignment.CenterHorizontally
    ) {
        items(items) { colorNombre ->
            val isSelected = colorNombre == selectedItem
            val colorReal = when (colorNombre) {
                "Rojo" -> Color.Red
                "Verde" -> Color.Green
                "Azul" -> Color.Blue
                "Amarillo" -> Color.Yellow
                else -> Color.Black
            }

            Text(
                text = colorNombre,
                modifier = Modifier
                    .fillMaxWidth()
                    .clickable{selectedItem = colorNombre}
                    .background(if (isSelected) Color.LightGray else Color.Transparent)
                    .padding(16.dp),
                fontWeight = if (isSelected) FontWeight.Bold else FontWeight.Normal,
                color = if (isSelected) colorReal else Color.Black
            )
        }
    }
}