using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MySql;
using System.Data;
using Pagina_Web_Delosi.Servidores;

namespace Pagina_Web_Delosi.Servidores
{
    public class ServidorController : Controller
    {
        // GET: Servidor
        OpcionesServidor db = new OpcionesServidor();
        public ActionResult ListadoServidor()
        {
            return View(db.servidor());
        }
        


        public ActionResult Index()
        {
            return View();
        }
    }
}