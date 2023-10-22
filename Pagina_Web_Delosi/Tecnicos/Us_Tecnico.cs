using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Tecnicos
{
    public class Us_Tecnico
    {
        [Display(Name = "ID")] public string idtecnico { get; set; }
        [Display(Name = "Nombre")] public string nombre_tec { get; set; }
        [Display(Name = "ID Roles")] public string IDroles { get; set;}
    }
}