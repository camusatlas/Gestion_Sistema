using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.PCGerencial
{
    public class PCGerencialController : Controller
    {
        // GET: PCGerencial
        OpcionesPCGerencial db = new OpcionesPCGerencial();
        public ActionResult ListadoPCGerencial()
        {
            return View(db.pcgerencial());
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}