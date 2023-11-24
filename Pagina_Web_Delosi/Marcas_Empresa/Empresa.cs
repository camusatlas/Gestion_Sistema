using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Marcas_Empresa
{
    public class Empresa
    {
        [Display(Name = "ID")] public int id_empresa { get; set; }
        [Display(Name = "Empresa")] public string nom_empresa { get; set; }
    }
}