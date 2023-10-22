using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Roles
{
    public class Id_roles
    {
        [Display(Name = "ID Roles")] public string IDroles { get; set; }
        [Display(Name = "roles")] public string roles { get; set; }
    }
}