let dataTable;
let dataTableIsInitialized = false;

const dataTableOptions = {
    //scrollX: "2000px",
    //scrollY: "250px",
    columnDefs: [{ className: "centered", targets: [0, 1, 2, 3, 4, 5, 6] },
    { orderable: false, targets: [5, 6] },
    { searchable: false, "targets": [0] }
        //{ width: "50%", targets: [0] }
    ],
    pageLength: 5,
    destroy: true,
    language: {
        lengthMenu: "",
        zeroRecords: "Ningún usuario encontrado",
        info: "Mostrando de _START_ a _END_ de un total de _TOTAL_ registros",
        infoEmpty: "Ningún usuario encontrado",
        infoFiltered: "(filtrados desde _MAX_ registros totales)",
        search: "Buscar:",
        loadingRecords: "Cargando...",
        paginate: {
            first: "Primero",
            last: "Último",
            next: "Siguiente",
            previous: "Anterior"
        }

    },
    info: false,
    ordering: false,
    lengthMenu: false,
    dom: 'Bfrtip',
    buttons: {
        buttons: [
            {
                extend: 'copy',
                text: '<i class="bi bi-clipboard-fill"></i>',
                titleAttr: 'Copiar',
                className: 'btn btn-secondary'
            },
            {
                extend: 'excel',
                text: '<i class="bi bi-file-earmark-spreadsheet"></i>',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-success'
            },
            {
                extend: 'pdf',
                text: '<i class="bi bi-file-earmark-pdf"></i>',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-danger'
            },
            {
                extend: 'print',
                text: '<i class="bi bi-printer"></i>',
                titleAttr: 'Imprimir',
                className: 'btn btn-info'
            },
            {
                extend: 'colvis',
                text: 'Filtrar Columnas'
            }
        ]
    },
    /*buttons: ['copy','excel','pdf', 'print','colvis']*/
};

const initDataTable = async () => {
    if (dataTableIsInitialized) {
        dataTable.destroy();
    }

    dataTable = $("#datatable_users").dataTable(dataTableOptions);

    dataTableIsInitialized = true;
};



window.addEventListener("load", async () => {
    await initDataTable();
});