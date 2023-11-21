using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Sistema_Operativo
    {
        [Display(Name = "N°")] public int id_sistema_operativo { get; set; }
        [Display(Name = "Sistema Operativo")] public string nom_sistema_operativo { get; set; }
    }
}