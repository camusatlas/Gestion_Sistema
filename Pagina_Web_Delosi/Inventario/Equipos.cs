using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Equipos
    {
        [Display(Name = "N°")] public int id_equipo { get; set; }
        [Display(Name = "Equipo")] public string tipo_equipo { get; set; }
        [Display(Name = "Marca")] public string nom_marca { get; set; }
        [Display(Name = "Modelo")] public string modelo_equipo { get; set; }
        [Display(Name = "Cantidad")] public int cantidad { get; set; }
    }
}