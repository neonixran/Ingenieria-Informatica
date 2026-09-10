preguntarInstituto()

function validarDatos() {
    const usuario = document.getElementById("usuario")
    const respuesta = confirm("¿Quiere compartir sus datos con la libreria online?")

    if (respuesta) {
        alert("Ok! le enviaremos la información")

        const prompt_mail = prompt("Por favor, ingrese su correo para recibir novedades.")

        if (prompt_mail != null) {
            alert(`Le enviaremos la información a ${prompt_mail}`)
        }

        usuario.innerText = "Usuario VIP"
    } else {
        alert("Disfrute su estadia")
    }
}

function preguntarInstituto() {
    let i = 0;

    do {
        const pregunta = prompt("¿Cuál es el mejor instituto?")

        if (pregunta.toUpperCase() == "IPVG") {
            alert("Mish")
            break;
        }

        i++
    } while (i < 5)
}