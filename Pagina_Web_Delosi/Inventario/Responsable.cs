using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Responsable
    {
        [Display(Name = "N°")] public int id_responsable { get; set; }
        [Display(Name = "Responsable")] public string nom_responsable { get; set; }
    }
}