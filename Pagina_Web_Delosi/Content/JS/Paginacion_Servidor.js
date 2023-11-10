$(document).ready(function () {
	$('#tablax').DataTable({
		language: {
			lengthMenu: "",
			zeroRecords: "No se encontraron resultados",
			info: "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
			infoEmpty: "Mostrando registros del 0 al 0 de un total de 0 registros",
			infoFiltered: "(filtrado de un total de _MAX_ registros)",
			sSearch: "Buscar:",
			oPaginate: {
				sFirst: "Primero",
				sLast: "Último",
				sNext: "Siguiente",
				sPrevious: "Anterior"
			},
			sProcessing: "Procesando...",

		},
		info: false,
		ordering: false,
		lengthMenu: false,
		//para usar los botones   
		responsive: "true",
		dom: 'Bfrtilp',

		buttons: [
			{
				extend: 'excelHtml5',
				text: '<i class="fas fa-file-excel"></i> ',
				titleAttr: 'Exportar a Excel',
				className: 'btn btn-success'
			},
			{
				extend: 'pdfHtml5',
				text: '<i class="fas fa-file-pdf"></i> ',
				titleAttr: 'Exportar a PDF',
				className: 'btn btn-danger'
			},
			{
				extend: 'print',
				text: '<i class="fa fa-print"></i> ',
				titleAttr: 'Imprimir',
				className: 'btn btn-info'
			},
			{
				extend: 'colvis',
				text: 'Filtrar Columnas'
			}
		],
		pageLength: 3,

		columnDefs: [
			{
				target: 5,
				visible: false,
				searchable: false
			},
			{
				targe: 6,
				visible: false,
				searchable: false,
			},
			{
				targe: 7,
				visible: false,
				searchable: false,
			},
			{
				targe: 8,
				visible: false,
				searchable: false,
			},
			{
				targe: 9,
				visible: false,
				searchable: false,
			},
			{
				targe: 10,
				visible: false,
				searchable: false,
			},
			{
				targe: 11,
				visible: false,
				searchable: false,
			},
			{
				targe: 12,
				visible: false,
				searchable: false,
			},
			{
				targe: 13,
				visible: false,
				searchable: false,
			},
			{
				targe: 14,
				visible: false,
				searchable: false,
			},
			{
				targe: 15,
				visible: false,
				searchable: false,
			},
			{
				targe: 16,
				visible: false,
				searchable: false,
			},
			{
				targe: 17,
				visible: false,
				searchable: false,
			},
			{
				targe: 18,
				visible: false,
				searchable: false,
			},
			{
				targe: 19,
				visible: false,
				searchable: false,
			},
			{
				targe: 20,
				visible: false,
				searchable: false,
			}
		]
	});
});