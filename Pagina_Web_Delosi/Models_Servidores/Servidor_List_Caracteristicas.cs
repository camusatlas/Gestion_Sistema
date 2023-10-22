using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Models
{
    public class Servidor_List_Caracteristicas
    {
        [Display(Name = "Tienda")] public string tienda { get; set; }
        [Display(Name = "Modelo")] public string modelo { get; set; }
        [Display(Name = "Serie")] public string serie { get; set; }
        [Display(Name = "Sistema Operativo")] public string sistema_operativo { get; set; }
        [Display(Name = "Version Micros")] public string version_micros { get; set; }
        [Display(Name = "Memoria Ram")] public string memoria_ram {get; set; }
        [Display(Name = "Tamaño de BD")] public string tamano_db { get; set; }
    }
}