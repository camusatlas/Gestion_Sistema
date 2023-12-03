using Pagina_Web_Delosi.Servidores;
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

        // Agregar PCGerencial
        public ActionResult CrearPCGerencial()
        {
            ViewBag.pcgerencial = new SelectList(db.pcgerencial(), "cod_marca", "cod_tienda", "tienda");
            return View(new PCGerencial());
        }

        [HttpPost]
        public ActionResult CrearPCGerencial(PCGerencial reg)
        {
            ViewBag.mensaje = db.IngresarPCGerencial(reg);
            ViewBag.pcgerencial = new SelectList(db.pcgerencial());
            return View(reg);
        }

        // Actualizar PCGerencial
        public ActionResult EditarPCGerencial(string id)
        {
            PCGerencial reg = db.Buscar(id);

            ViewBag.pcgerencial = new SelectList(db.pcgerencial());
            return View(reg);
        }

        [HttpPost]
        public ActionResult EditarPCGerencial(PCGerencial reg)
        {
            ViewBag.mensaje = db.ActualizarPCGerencial(reg);
            ViewBag.pcgerencial = new SelectList(db.pcgerencial());
            return View(reg);
        }

        // Eliminar PCGerencial
        public ActionResult EliminaPCGErencial(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("ListadoPCGerencial");
            }

            ViewBag.mensaje = db.Eliminar(id);
            return RedirectToAction("ListadoPCGerencial");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}