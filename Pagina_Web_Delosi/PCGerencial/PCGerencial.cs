using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.PCGerencial
{
    public class PCGerencial
    {
        [Display(Name = "Marca")] public string cod_marca { get; set; }
        [Display(Name = "Número de Tienda")] public string cod_tienda { get; set; }
        [Display(Name = "Nombre e Tienda")] public string tienda { get; set; }
        [Display(Name = "IP PC")] public string ip_gerente { get; set; }
        [Display(Name = "HostName")] public string nom_pc_gerencial { get; set; }
        [Display(Name = "Modelo")] public String modelo { get; set; }
    }
}