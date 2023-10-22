using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace Pagina_Web_Delosi.Models
{
    public class Servidor_Datos_Tienda
    {
        [Display(Name = "Código Marca")] public string cod_marca { get; set; }
        [Display(Name = "Código de Tienda")] public string cod_tienda { get; set; }
        [Display(Name = "Tienda")] public string tienda { get; set; }
        [Display(Name = "Departamento")] public string departamento { get; set; }
        [Display(Name = "Provincia")] public string provincia { get; set; }
        [Display(Name = "Distrito")] public string distrito { get; set; }
        [Display(Name = "Gmail Tienda")] public string mail_tienda { get; set; }
        [Display(Name = "FLG Delivery")] public string flg_delivery { get; set; }
        [Display(Name = "FLG Multimarca")] public string flg_multimarca { get; set; }
        [Display(Name = "Código G.A.")] public string cod_ger_area { get; set; }
        [Display(Name = "G.A.")] public string gte_area { get; set; }
        [Display(Name = "Gmail G.A.")] public string mail_gte_area { get; set; }
        [Display(Name = "Telefono G.A.")] public string tlfno_gte_area { get; set; }
        [Display(Name = "Rank Total")] public string rank_total { get; set; }
        [Display(Name = "Rank Marca")] public string rank_marca { get; set; }
    }
}