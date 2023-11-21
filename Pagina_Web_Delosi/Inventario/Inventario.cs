using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Inventario
    {
        [Display(Name = "N°")] public int id { get; set; }
        [Display(Name = "Equipo")] public string id_equipo { get; set; }
        [Display(Name = "Estado")] public string id_estado {  get; set; }
        [Display(Name = "Estado")] public DateTime fecha_ingreso { get; set; }
        [Display(Name = "Estado")] public string id_asignado { get; set; }
        [Display(Name = "Estado")] public string id_almacen { get; set; }
        [Display(Name = "Estado")] public int cantidad { get; set; }
        [Display(Name = "Estado")] public string marca { get; set; }
        [Display(Name = "Estado")] public string modelo { get; set; }
        [Display(Name = "Estado")] public string id_responsable { get; set; }
        [Display(Name = "Estado")] public int num_guia_ingreso { get; set; }
        [Display(Name = "Estado")] public string usuario { get; set; }
        [Display(Name = "Estado")] public string destino { get; set; }
        [Display(Name = "Estado")] public string id_tienda { get; set; }
        [Display(Name = "Estado")] public DateTime fechasalida { get; set; }
        [Display(Name = "Estado")] public string id_tecnico { get; set; }
        [Display(Name = "Estado")] public int tiket { get; set; }
        [Display(Name = "Estado")] public string num_guia_salida { get; set; }
        [Display(Name = "Estado")] public string id_proveeor { get; set; }
        [Display(Name = "Estado")] public string orden_compra { get; set; }
        [Display(Name = "Estado")] public string orden_interna { get; set; }
        [Display(Name = "Estado")] public string afecoactivo_fijo { get; set; }
        [Display(Name = "Estado")] public string almacen_ingreso { get; set; }
        [Display(Name = "Estado")] public string cod_material_sap { get; set; }
        [Display(Name = "Estado")] public string razon_social { get; set; }
        [Display(Name = "Estado")] public string prioridad { get; set; }
        [Display(Name = "Estado")] public string id_sistem_operativo { get; set; }
        [Display(Name = "Estado")] public string direction_mac { get; set; }
        [Display(Name = "Estado")] public string especificaciones { get; set; }
        [Display(Name = "Estado")] public DateTime fecha_grantia { get; set; }
        [Display(Name = "Estado")] public DateTime fecha_actualizacion { get; set; }
        [Display(Name = "Estado")] public string observaction { get; set; }

    }
}