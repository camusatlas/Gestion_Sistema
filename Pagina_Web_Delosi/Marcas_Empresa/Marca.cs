using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Marcas_Empresa
{
    public class Marca
    {
        [Display(Name = "ID")] public int id_marca { get; set; }
        [Display(Name = "Marca")] public string nom_marca { get; set; }
    }
}