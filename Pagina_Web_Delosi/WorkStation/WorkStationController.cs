using Pagina_Web_Delosi.Servidores;
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

        // Ingresar WorkSation
        public ActionResult CrearWorkSation()
        {
            ViewBag.worksation = new SelectList(db.workstation(), "cod_marca", "cod_tienda", "tienda");
            return View(new WorKStation());
        }

        [HttpPost]
        public ActionResult CrearWorkSation(WorKStation reg)
        {
            ViewBag.mensaje = db.IngresarWorkSation(reg);
            ViewBag.worksation = new SelectList(db.workstation(), "cod_marca", "tienda");
            return View(reg);
        }

        // Actualizar WorkSation
        public ActionResult EditarWorkStation(string id)
        {
            WorKStation reg = db.Buscar(id);

            ViewBag.workstation = new SelectList(db.workstation(), "cod_marca", "tienda");
            return View(reg);
        }

        [HttpPost]
        public ActionResult Editar(WorKStation reg)
        {
            ViewBag.mensaje = db.ActualizarWorkStation(reg);
            ViewBag.workstation = new SelectList(db.workstation(), "cod_marca", "tienda");
            return View(reg);
        }

        // Eliminar
        public ActionResult EliminaWorkSation(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("ListadoServidor");
            }

            ViewBag.mensaje = db.EliminarWorkSation(id);
            return RedirectToAction("ListadoServidor");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}