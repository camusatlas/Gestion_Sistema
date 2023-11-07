using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.WorkStation
{
    public class WorkStationController : Controller
    {
        // GET: WorkStation
        OpcionesWorkStation db = new OpcionesWorkStation();
        public ActionResult ListadoWorkStation()
        {
            return View(db.workstation());
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}