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
        [Display(Name = "Modelo")] public string modelo { get; set; }
        [Display(Name = "Serie")] public string serie { get; set; }
        [Display(Name = "Sistema Operativo")] public string sistema_operativo { get; set; }
        [Display(Name = "Memoria Ram")] public string memoria_ram { get; set; }
        [Display(Name = "Procesador")] public string procesador { get; set; }
        [Display(Name = "Status")] public string status { get; set; }
        [Display(Name = "FLG Esatado")] public string flg_stado { get; set; }
        [Display(Name = "Usuario")] public string usuario_crea { get; set; }
        [Display(Name = "Fecha")] public string fecha_crea { get; set; }
        [Display(Name = "Usuario Mod.")] public string usuario_mod { get; set; }
        [Display(Name = "Fecha Mod.")] public string fecha_mod { get; set; }
    }
}