const encabezado = document.getElementById("enca") // Obtiene el elemento H1 por su ID
console.log("Encabezado:", encabezado)

const cards = document.getElementsByClassName("card"); // Obtiene todos los elementos de clase "card"
console.log("Tarjetas:", cards)

const alerta = document.querySelector("#alert"); // Obtiene el elemento alert por su ID 
console.log("Alerta:", alerta)

function cambiarH1() {
    encabezado.textContent = "Wena po'" // Cambiar texto al elemento "encabezado"
    encabezado.classList.add("bg-warning") // Agregar una nueva clase al elemento "encabezado"
}

function cambiarTarjeta() {
    cards[0].style.backgroundColor  = "LightBlue" // Cambia el color de la primera tarjeta
    cards[1].style["background-color"]  = "red" // Cambia el color de la primera tarjeta 
    cards[2].style["background-color"]  = "yellow" // Cambia el color de la primera tarjeta 
}