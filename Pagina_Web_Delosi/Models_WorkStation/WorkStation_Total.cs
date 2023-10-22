using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Models_WorkStation
{
    public class WorkStation_Total
    {
        [Display(Name = "Código de Marca")] public string cod_marca { get; set; }
        [Display(Name = "Código de Tienda")] public string cod_tienda { get; set; }
        [Display(Name = "Tienda")] public string tienda { get; set; }
        [Display(Name = "Caja")] public string caja { get; set; }
        [Display(Name = "IP WorkStation")] public string ip_workstation { get; set; }
        [Display(Name = "HostName")] public string hostname { get; set; }
        [Display(Name = "Tipo")] public string tipo { get; set; }
        [Display(Name = "Modelo")] public string modelo { get; set; }
        [Display(Name = "Status")] public string status { get; set; }
        [Display(Name = "Ultima Venta")] public string ultima_venta { set; get; }
        [Display(Name = "FLG Estado")] public string flg_estado { set; get; }
        [Display(Name = "Usuario Creado")] public string usuario_crea { set; get; }
        [Display(Name = "Fecha Creada")] public string fecha_crea { set; get; }
        [Display(Name = "Usuario Mod.")] public string usuario_mod { set; get; }
        [Display(Name = "Fecha Mod.")] public string fecha_mod { set; get; }
        [Display(Name = "Version Facturador")] public string version_facturador { set; get; }
    }
}