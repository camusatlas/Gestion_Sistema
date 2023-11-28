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
		pageLength: 10,

		columnDefs: [
			{
				target: 5,
				visible: false,
				searchable: false
			},
			{
				target: 6,
				visible: false,
				searchable: false,
			},
			{
				target: 7,
				visible: false,
				searchable: false,
			},
			{
				target: 8,
				visible: false,
				searchable: false,
			},
			{
				target: 9,
				visible: false,
				searchable: false,
			},
			{
				target: 10,
				visible: false,
				searchable: false,
			},
			{
				target: 11,
				visible: false,
				searchable: false,
			},
			{
				target: 12,
				visible: false,
				searchable: false,
			},
			{
				target: 13,
				visible: false,
				searchable: false,
			},
			{
				target: 14,
				visible: false,
				searchable: false,
			},
			{
				target: 15,
				visible: false,
				searchable: false,
			},
			{
				target: 16,
				visible: false,
				searchable: false,
			},
			{
				target: 17,
				visible: false,
				searchable: false,
			},
			{
				target: 18,
				visible: false,
				searchable: false,
			},
			{
				target: 19,
				visible: false,
				searchable: false,
			},
			{
				target: 20,
				visible: false,
				searchable: false,
			},
			{
				target: 21,
				visible: false,
				searchable: false,
			}
		],

	});
});