using Google.Protobuf.WellKnownTypes;
using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Servidores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        IEnumerable<EquiposKds> ListarKDS()
        {
            List<EquiposKds> lista = new List<EquiposKds>();
            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("ListarKDS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EquiposKds
                    {
                        empresa = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                        marca = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        nombre_tienda = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        provincia = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                        departamento = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                        distrito = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                        ip_kds = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                        hostname = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                        status = !dr.IsDBNull(9) ? dr.GetString(9) : null
                    });
                }
                dr.Close();
                cn.Close();
            }
            return lista;
        }


        public ActionResult BuscarKDS()
        {
            return View(ListarKDS());
        }

        // Ingresar Nuevos KDS
        public ActionResult CrearKDS()
        {
            ViewBag.kds = new SelectList(ListarKDS());
            return View(new EquiposKds());
        }
        [HttpPost]
        public ActionResult CrearKDS(EquiposKds reg)
        {
            ViewBag.mensaje = db.IngresarKDS(reg);
            ViewBag.kds = new SelectList(ListarKDS());
            return View(reg);
        }

        // Actualizar KDS
        public ActionResult ObtenerDatosKDS(string id)
        {
            EquiposKds equipo = db.Buscar(id); // Utiliza tu método para buscar el equipo por ID

            // Retornar los datos como un objeto JSON
            return Json(equipo, JsonRequestBehavior.AllowGet);
        }




        public ActionResult EditarKDS(string id)
        {
            EquiposKds reg = db.Buscar(id);

            ViewBag.kds = new SelectList(ListarKDS());
            return View(reg);
        }

        [HttpPost]
        public ActionResult EditarKDS(EquiposKds reg)
        {
            ViewBag.mensaje = db.ActualizarKDS(reg);
            ViewBag.kds = new SelectList(ListarKDS());
            return View(reg);
        }

        // Eliminar KDS
        public ActionResult EliminaKDS(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("BuscarKDS");
            }

            ViewBag.mensaje = db.EliminaKDS(id);
            return RedirectToAction("BuscarKDS");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}