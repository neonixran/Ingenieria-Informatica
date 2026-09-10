function validar(event) {
  event.preventDefault();

  const email = document.querySelector("#correo").value;
  const contraseña = document.querySelector("#contrasena").value;

  if (validarCorreo(email) && validarContraseña(contraseña)) {
    alert("Wena ql, tu correo y pass están tiki taka.");
    event.target.submit();
  } else {
    alert("Wons, tus credenciales están malas")
  }

  return false;
}

function validarCorreo(email) {
  const regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

  return regex.test(email.toLowerCase());
}

function validarContraseña(contraseña) {
    return contraseña > 11;
}