using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Proveedor
    {
        [Display(Name = "N°")] public int id_proveeor { get; set; }
        [Display(Name = "Proveedor")] public string nom_proveedor { get; set; }
    }
}