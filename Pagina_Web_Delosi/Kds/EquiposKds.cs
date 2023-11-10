using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Kds
{
    public class EquiposKds
    {
        [Display(Name = "Empresa")] public string empresa { get; set; }
        [Display(Name = "Marca")] public string marca { get; set; }
        [Display(Name = "Tienda")] public string tienda { get; set; }
        [Display(Name = "Nombre de Tienda")] public string nombre_tienda { get; set; }
        [Display(Name = "Provincia")] public string provicia { get; set; }
        [Display(Name = "Departamento")] public string departamento { get; set; }
        [Display(Name = "Distrito")] public string distrito { get; set; }
        [Display(Name = "IP KDS")] public string ip_kds { get; set; }
        [Display(Name = "Hostname")] public string hostname { get; set; }
        [Display(Name = "Status")] public string status { get; set; }

    }
}