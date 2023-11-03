$(document).ready(function () {
    // Manejar clic del botón "Eliminar"
    $('.eliminar-btn').click(function () {
        var id = $(this).data('id');
        // Mostrar un cuadro de diálogo de confirmación
        if (confirm('¿Estás seguro de que deseas eliminar este registro?')) {
            // Enviar una solicitud AJAX para eliminar la fila
            $.ajax({
                url: '@Url.Action("Eliminar", "TuControlador")',
                type: 'POST',
                data: { id: id },
                success: function (result) {
                    // Actualizar la vista después de eliminar la fila (opcional)
                    location.reload();
                },
                error: function (xhr, status, error) {
                    // Manejar errores si es necesario
                    console.error(error);
                }
            });
        }
    });
});