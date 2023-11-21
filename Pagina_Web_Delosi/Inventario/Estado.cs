using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Estado
    {
        [Display(Name = "N°")] public int idestado { get; set; }
        [Display(Name = "Estado")] public string estado { get; set; }
    }
}