using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Servidores
{
    public class Servidor
    {
        [Display(Name = "MARCA")] public string cod_marca { get; set; }
        [Display(Name = "CÓDIGO DE TIENDA")] public string cod_tienda { get; set; }
        [Display(Name = "TIENDA")] public string tienda { get; set; }
        [Display(Name = "IP SERVIDOR")] public string ip_servidor { get; set; }
        [Display(Name = "NOMBRE DE SERVIDOR")] public string nom_servidor { get; set; }
        [Display(Name = "MODELO")] public string modelo { get; set; }
        [Display(Name = "SERIE")] public string serie { get; set; }
        [Display(Name = "SISTEMA")] public string sistema_operativo { get; set; }
        [Display(Name = "VERSION MICROS")] public string version_micros { get; set; }
        [Display(Name = "MEMORIA RAM")] public string memoria_ram { get; set; }
        [Display(Name = "TAMAÑO DE BD")] public string tamano_bd { get; set; }
        [Display(Name = "STATUS")] public string status { get; set; }
        [Display(Name = "ULTIMO REINICIO")] public string ultimo_reinicio { get; set; }
        [Display(Name = "VERSION FACTURADOR")] public string version_facturador { get; set; }
        [Display(Name = "ULTIMA VENTA")] public string ultima_venta { get; set; }
        [Display(Name = "FLG ESTADO")] public string flg_estado { get; set; }
        [Display(Name = "USUARIO CREADO")] public string usuario_crea { get; set; }
        [Display(Name = "FECHA CREADA")] public string fecha_crea { get; set; }
        [Display(Name = "USUARIO MOD.")] public string usuario_mod { get; set; }
        [Display(Name = "FECHA MOD.")] public string fecha_mod { get; set; }
        [Display(Name = "USUARIO ")] public string idtecnico { get; set; }
        [Display(Name = "FECHA ASIGNADO")] public string fecha_asignado { get; set; }
    }
}