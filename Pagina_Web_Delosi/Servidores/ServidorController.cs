using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MySql;
using System.Data;
using Pagina_Web_Delosi.Servidores;
using Pagina_Web_Delosi.Permisos;

namespace Pagina_Web_Delosi.Servidores
{
    public class ServidorController : Controller
    {
        // GET: Servidor
        OpcionesServidor db = new OpcionesServidor();
        // Listado de Servidores
        public ActionResult ListadoServidor()
        {
            return View(db.servidor());
        }

        // Agregar Nuevos Servidores
        public ActionResult CrearServidor()
        {
            ViewBag.servidor = new SelectList(db.servidor(), "cod_marca", "cod_tienda", "tienda");
            return View(new Servidor());
        }

        [HttpPost]
        public ActionResult CrearServidor(Servidor reg)
        {
            ViewBag.mensaje = db.Ingresar(reg);
            ViewBag.servidor = new SelectList(db.servidor(), "cod_marca", "tienda");
            return View(reg);
        }

        // Actualizar Servisores
        public ActionResult Editar(string id)
        {
            Servidor reg = db.Buscar(id);

            ViewBag.servidor = new SelectList(db.servidor(), "cod_marca", "tienda");
            return View(reg);
        }

        [HttpPost]
        public ActionResult Editar(Servidor reg)
        {
            ViewBag.mensaje = db.Actualizar(reg);
            ViewBag.servidor = new SelectList(db.servidor(), "cod_marca", "tienda");
            return View(reg);
        }

        // Eliminar


        public ActionResult Index()
        {
            return View();
        }
    }
}