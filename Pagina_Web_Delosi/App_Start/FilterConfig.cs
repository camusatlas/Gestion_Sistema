using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
