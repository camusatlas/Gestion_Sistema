//Esperar 1.5 segundos
setTimeout(function () {
    $(".alerta").fadeOut("slow");
}, 1500);

function mostrar() {
    var div = document.getElementById('alerta');
    div.style.display = 'block';
}