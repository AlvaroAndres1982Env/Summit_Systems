function validarTexto() {
    var data = {
        input: $("#Texto").val(),
    }
    $.post("https://localhost:44307/api/test/", data)
        .done(function (response) {
            console.log(response);
            if (response) {
                alert(response);
                //window.location = '/Vehiculo/VehiculoLista/';
            } else {
                alert("Error al crear");
            }
        });
}