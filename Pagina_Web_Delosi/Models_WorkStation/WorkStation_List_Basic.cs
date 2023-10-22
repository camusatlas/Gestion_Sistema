using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Models_WorkStation
{
    public class WorkStation_List_Basic
    {
        [Display(Name = "Tienda")] public string tienda {  get; set; }
        [Display(Name = "Caja")] public string caja { get; set; }
        [Display(Name = "IP WorckStation")] public string ip_workstation { get; set; }
        [Display(Name = "HostName")] public string hostname { get; set; }
        [Display(Name = "Tipo")] public string tipo { get; set; }
    }
}