using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.Kds
{
    public class KDSController : Controller
    {

        // GET: KDS

        
        OpcionesKDS db = new OpcionesKDS();
        public ActionResult BuscarKDS()
        {
            return View(db.kds());
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}