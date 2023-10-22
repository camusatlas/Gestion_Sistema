using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.Permisos
{
    public class AgregarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["usuario"] == null)
            {
                filterContext.Result = new RedirectResult("~/Login/Login");
            }

            base.OnActionExecuted(filterContext);
        }
    }
}