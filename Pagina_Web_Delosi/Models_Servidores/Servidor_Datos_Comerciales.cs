using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Models_Servidores
{
    public class Servidor_Datos_Comerciales
    {
        [Display(Name = "Tienda")] public string tienda {  get; set; }
        [Display(Name = "Version Facturador")] public string version_facturador { get; set;}
        [Display(Name = "Usuario Crea.")] public string usuario_crea { get; set; }
        [Display(Name = "Fecha Crea.")] public string fecha_crea {  get; set; }
    }
}