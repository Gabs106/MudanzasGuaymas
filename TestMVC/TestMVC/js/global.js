function Agregar() {
    $("#agregar").on("submit", function(e){
        e.preventDefault();
        var data = {
                nombre: $("#usuario").val(),
                
        }
        $.ajax({
            method: "GET",
            url: "http://localhost:49727/Services/CRUD/SrvUsuario.svc/create/"+data,
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        }).done(function (info) {
            //Respuesta del servidor
            console.log(info);
            $(".mensaje").html( info.d );
        })
    });
}