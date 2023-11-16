using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Servidores;
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

        // Listado de KDS
        public ActionResult BuscarKDS()
        {
            return View(db.kds());
        }

        // Ingresar Nuevos KDS
        public ActionResult CrearKDS()
        {
            ViewBag.kds = new SelectList(db.kds(), "cod_marca", "cod_tienda", "tienda");
            return View(new EquiposKds());
        }
        [HttpPost]
        public ActionResult CrearKDS(EquiposKds reg)
        {
            ViewBag.mensaje = db.IngresarKDS(reg);
            ViewBag.kds = new SelectList(db.kds(), "cod_marca", "tienda");
            return View(reg);
        }

        // Actualizar KDS
        public ActionResult EditarKDS(string id)
        {
            EquiposKds reg = db.Buscar(id);

            ViewBag.kds = new SelectList(db.kds(), "cod_marca", "tienda");
            return View(reg);
        }

        [HttpPost]
        public ActionResult EditarKDS(EquiposKds reg)
        {
            ViewBag.mensaje = db.ActualizarKDS(reg);
            ViewBag.kds = new SelectList(db.kds(), "cod_marca", "tienda");
            return View(reg);
        }

        // Eliminar KDS
        public ActionResult EliminaKDS(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("ListadoServidor");
            }

            ViewBag.mensaje = db.EliminarKDS(id);
            return RedirectToAction("ListadoServidor");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}