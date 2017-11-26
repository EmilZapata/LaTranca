$(document).ready(function () {
    $('#btnSaveUpdateUsuario').on('click',function () {
        console.log("GG");
        $.ajax({
            type: 'POST',
            url: '/ModuloAdministracion/GestorUsuarios/SaveUpdateUsuario',
            data: $('#form-usuario').serialize(),
            success: function (data) {
                var mensaje = new Mensaje(data.notificacion);

                if (mensaje.tipo == 'exito') {
                    mensaje.enviarMensaje();

                    setTimeout(function () {
                        window.location = "/ModuloAdministracion/GestorUsuarios/Index";
                    }, 2000);
                } else {
                    mensaje.enviarMensaje();
                }
            },
            error: function () {
                var mensaje = new Mensaje({
                    tipo: 'error',
                    titulo: 'Error',
                    mensaje: 'Error en el sistema.'
                });

                mensaje.enviarMensaje();
            }
        });
    });

    $('#btnRetrocederUsuarios').on('click', function () {
        window.location = "/ModuloAdministracion/GestorUsuarios/Index";
    });
});