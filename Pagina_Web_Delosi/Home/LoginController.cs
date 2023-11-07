using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Servidores;

using System.DirectoryServices.AccountManagement;

using System.DirectoryServices;

using Pagina_Web_Delosi.Models_Servidores;

namespace Pagina_Web_Delosi.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usuario, string clave, string mensaje)
        {
            // Aquí va el path URL del servicio de directorio LDAP
            string ldapPath = "LDAP://192.168.0.6/DC=FRANQUICIASPERU,DC=COM";
            string username = usuario;
            string password = clave;
            string msn = mensaje;

            bool isAuthenticated = EstaAutenticado("FRANQUICIASPERU.COM", username, password, ldapPath, msn);

            if (isAuthenticated)
            {
                // Establecer una variable de sesión o hacer otro tipo de seguimiento de inicio de sesión
                Session["usuario"] = usuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Manejar la autenticación fallida apropiadamente, por ejemplo, mostrando un mensaje de error en la vista
                ViewData["Mensaje"] = "usuario no encontrado";
                return View();
            }
        }
        public bool EstaAutenticado(string dominio, string usuario, string pwd, string path, string msn)
        {
            // Armamos la cadena completa de dominio y usuario
            string domainAndUsername = usuario + "@" + dominio;

            // Creamos un objeto DirectoryEntry al cual le pasamos el URL, dominio/usuario y la contraseña
            using (DirectoryEntry entry = new DirectoryEntry(path, domainAndUsername, pwd))
            {
                try
                {
                    using (DirectorySearcher search = new DirectorySearcher(entry))
                    {
                        // Verificamos que los datos de logeo proporcionados son correctos
                        SearchResult result = search.FindOne();
                        return result != null;
                    }
                }
                catch (Exception )
                {
                    // Puedes manejar el error de alguna manera apropiada, como registrar o mostrar un mensaje
                    return false;
                }
            }
        }
        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Login");
        }
    }
    public class VariableSessionAttribute : ActionFilterAttribute
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