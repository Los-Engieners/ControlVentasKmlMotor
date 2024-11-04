// Estilo de alerta personalizada
const Swal2 = Swal.mixin({
    customClass: {
        confirmButton: 'btn btn-primary w-100',
        cancelButton: 'btn btn-danger'
    },
    buttonsStyling: false
})

// funcion para capturar errores del servidor.
function capturarError(data) {
    var mensaje = data.substring((data.indexOf("<title>") + 7), (data.indexOf("</title>")));
    console.log("EXCEPTION: " + mensaje);
    alertaError("Error en el servidor", mensaje);
    return mensaje;
}

// funcion para mostrar errores
function alertaError(titulo, mensaje) {
    Swal2.fire({
        title: '<strong>' + titulo + '</strong>',
        icon: 'error',
        html: "<p class='text-danger'>" + mensaje + "</p>",
    });
}




// funcion para validar respuesta del servidor
function validarResponse(data) {
    if (data.resultado == 1) {
        Swal2.fire("Éxito", data.texto, "success");
        if (data.func != null) {
            data.func();
        }
    }
    else {
        alertaError("Error", "Ocurrio un error al realizar la solicitud");
    }
}

// funcion para mostrar como error las excepciones del servidor
function catchJS(response) {
    capturarError(response.data);
}