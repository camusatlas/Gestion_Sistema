using Pagina_Web_Delosi.Models_WorkStation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pagina_Web_Delosi.Controllers
{
    public class WorkStationController : Controller
    {
        // GET: WorkStation
        IEnumerable<WorkStation_Total> workStation_total()
        {
            List<WorkStation_Total> lista = new List<WorkStation_Total>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("tb_bhd_gen_workstation_List", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new WorkStation_Total
                {
                    cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    caja = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    ip_workstation = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    hostname = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    tipo = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    modelo = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    status = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    ultima_venta = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    flg_estado = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                    usuario_crea = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                    fecha_crea = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                    usuario_mod = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                    fecha_mod = !dr.IsDBNull(14) ? dr.GetString(14) : null,
                    version_facturador = !dr.IsDBNull(15) ? dr.GetString(15) : null
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        IEnumerable<WorkStation_List_Basic> WorkStation_List_Basicl()
        {
            List<WorkStation_List_Basic> lista = new List<WorkStation_List_Basic>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("tb_bhd_gen_workstation_List_Basic", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new WorkStation_List_Basic
                {
                    tienda = dr.GetString(0),
                    caja = dr.GetString(1),
                    ip_workstation = dr.GetString(2),
                    hostname = dr.GetString(3),
                    tipo = dr.GetString(4)
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        IEnumerable<WorkStation_List_Basic> buscarworkstation(string nombre)
        {
            List<WorkStation_List_Basic> lista = new List<WorkStation_List_Basic>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Busc_List_Date_WorkStation_Basic", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_tienda", nombre);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new WorkStation_List_Basic
                {
                    tienda = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    caja = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    ip_workstation = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    hostname = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    tipo = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        public ActionResult IndexBuscarPuntoVenta(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(buscarworkstation(nombre));
        }
        string AgregarPuntoVenta(WorkStation_Total reg)
        {
            string mensaje = string.Empty;
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Ing_WorkStation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod_marca", reg.cod_marca);
                cmd.Parameters.AddWithValue("cod_tienda", reg.cod_tienda);
                cmd.Parameters.AddWithValue("tienda", reg.tienda);
                cmd.Parameters.AddWithValue("caja", reg.caja);
                cmd.Parameters.AddWithValue("ip_workstation", reg.ip_workstation);
                cmd.Parameters.AddWithValue("hostname", reg.hostname);
                cmd.Parameters.AddWithValue("tipo", reg.tipo);
                cmd.Parameters.AddWithValue("modelo", reg.modelo);
                cmd.Parameters.AddWithValue("status", reg.status);
                cmd.Parameters.AddWithValue("ultima_venta", reg.ultima_venta);
                cmd.Parameters.AddWithValue("flg_estado", reg.flg_estado);
                cmd.Parameters.AddWithValue("usuario_crea", reg.usuario_crea);
                cmd.Parameters.AddWithValue("fecha_crea", reg.fecha_crea);
                cmd.Parameters.AddWithValue("usuario_mod", reg.usuario_mod);
                cmd.Parameters.AddWithValue("fecha_mod", reg.fecha_mod);
                cmd.Parameters.AddWithValue("version_facturador", reg.version_facturador);
                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se creo {i} Nuevo Punto de Venta...";
            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
            }
            finally { cn.Close(); }
            return mensaje;
        }
        public ActionResult CreateWorkStation()
        {
            ViewBag.servidors = new SelectList(workStation_total(), "tienda", "caja");
            return View(new WorkStation_Total());
        }
        public ActionResult CreateWorkStation(WorkStation_Total reg)
        {
            ViewBag.mensaje = AgregarPuntoVenta(reg);
            return View(new WorkStation_Total());
        }
        //Actualizar
        string ActualizarPuntoVenta(WorkStation_Total reg)
        {
            string mensaje = string.Empty;
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Upd_Servidores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod_marca", reg.cod_marca);
                cmd.Parameters.AddWithValue("cod_tienda", reg.cod_tienda);
                cmd.Parameters.AddWithValue("tienda", reg.tienda);
                cmd.Parameters.AddWithValue("caja", reg.caja);
                cmd.Parameters.AddWithValue("ip_workstation", reg.ip_workstation);
                cmd.Parameters.AddWithValue("hostname", reg.hostname);
                cmd.Parameters.AddWithValue("tipo", reg.tipo);
                cmd.Parameters.AddWithValue("modelo", reg.modelo);
                cmd.Parameters.AddWithValue("status", reg.status);
                cmd.Parameters.AddWithValue("ultima_venta", reg.ultima_venta);
                cmd.Parameters.AddWithValue("flg_estado", reg.flg_estado);
                cmd.Parameters.AddWithValue("usuario_crea", reg.usuario_crea);
                cmd.Parameters.AddWithValue("fecha_crea", reg.fecha_crea);
                cmd.Parameters.AddWithValue("usuario_mod", reg.usuario_mod);
                cmd.Parameters.AddWithValue("fecha_mod", reg.fecha_mod);
                cmd.Parameters.AddWithValue("version_facturador", reg.version_facturador);
                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se actualizó {i} Punto de Venta...";
            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
            }
            finally { cn.Close(); }
            return mensaje;
        }
        public ActionResult EditPuntoVenta(string id)
        {
            if (string.IsNullOrEmpty(id)) { id = string.Empty; }
            WorkStation_Total reg = workStation_total().FirstOrDefault(x => x.tienda == id);
            ViewBag.WorkStation_Total = new SelectList(workStation_total(), "nom_empresa_ws", "comp_tienda_ws");
            return View(reg);
        }
        [HttpPost]
        public ActionResult EditPuntoVenta(WorkStation_Total reg)
        {
            ViewBag.mensaje = ActualizarPuntoVenta(reg);
            return View(new WorkStation_Total());
        }
    }
}