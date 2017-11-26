
$(document).ready(function () {
    $('.btnVerUsuario').on('click',function () {
        var idUsuario = $(this).attr('id-usuario');

        window.location = "/ModuloAdministracion/GestorUsuarios/SaveUpdateUsuario?idUsuario=" + idUsuario + "&accion=" + 1;
    });

    $('.btnEditarUsuario').on('click', function () {
        var idUsuario = $(this).attr('id-usuario');

        window.location = "/ModuloAdministracion/GestorUsuarios/SaveUpdateUsuario?idUsuario=" + idUsuario + "&accion=" + 0;
    });

    $('#btnBloquearUsuario').on(function () {
        var idUsuario = $(this).attr('id-usuario');
    });

    $('#btnEditContrasenia').on(function () {
        var idUsuario = $(this).attr('id-usuario');


    });

    $('#btnCambiarRol').on(function () {
        var idUsuario = $(this).attr('id-usuario');
    });
});