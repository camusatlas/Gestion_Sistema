using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Models;
using Pagina_Web_Delosi.Models_Servidores;
using Pagina_Web_Delosi.Roles;
using Pagina_Web_Delosi.Tecnicos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.Controllers
{
    public class Servidores_TiendaController : Controller
    {
        // GET: Servidores_Tienda
        /* Listado de Servidores de Manerta total*/
        IEnumerable<Servidores_Total> servidores()
        {
            List<Servidores_Total> lista = new List<Servidores_Total>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("tb_bhd_gen_servidor_List_Total", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servidores_Total
                {
                    cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    ip_servidor = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    nom_servidor = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    modelo = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    serie = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    sistema_operativo = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    version_micros = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    memoria_ram = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    tamano_bd = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                    status = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                    ultimo_reinicio = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                    version_facturador = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                    ultima_venta = !dr.IsDBNull(14) ? dr.GetString(14) : null,
                    flg_estado = !dr.IsDBNull(15) ? dr.GetString(15) : null,
                    usuario_crea = !dr.IsDBNull(16) ? dr.GetString(16) : null,
                    fecha_crea = !dr.IsDBNull(17) ? dr.GetString(17) : null,
                    usuario_mod = !dr.IsDBNull(18) ? dr.GetString(18) : null,
                    fecha_mod = !dr.IsDBNull(19) ? dr.GetString(19) : null,
                    idtecnico = !dr.IsDBNull(20) ? dr.GetString(20) : null,
                    fecha_asignado = !dr.IsDBNull(21) ? dr.GetString(21) : null
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }

        IEnumerable<Servidores_Total> buscar_servidores(string nombre)
        {
            List<Servidores_Total> lista = new List<Servidores_Total>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Busc_List_Tienda_Total_Servidor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_tienda", nombre);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servidores_Total
                {
                    cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    ip_servidor = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    nom_servidor = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    modelo = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    serie = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    sistema_operativo = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    version_micros = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    memoria_ram = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    tamano_bd = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                    status = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                    ultimo_reinicio = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                    version_facturador = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                    ultima_venta = !dr.IsDBNull(14) ? dr.GetString(14) : null,
                    flg_estado = !dr.IsDBNull(15) ? dr.GetString(15) : null,
                    usuario_crea = !dr.IsDBNull(16) ? dr.GetString(16) : null,
                    fecha_crea = !dr.IsDBNull(17) ? dr.GetString(17) : null,
                    usuario_mod = !dr.IsDBNull(18) ? dr.GetString(18) : null,
                    fecha_mod = !dr.IsDBNull(19) ? dr.GetString(19) : null,
                    idtecnico = !dr.IsDBNull(20) ? dr.GetString(20) : null,
                    fecha_asignado = !dr.IsDBNull(21) ? dr.GetString(21) : null
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }

        public ActionResult Index_buscar_servidor_total(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(buscar_servidores(nombre));
        }
        public ActionResult Index_buscar_servidor_dato_comerciales(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(buscar_servidores(nombre));
        }
        public ActionResult Index_buscar_servidor_list_caracteristicas(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(buscar_servidores(nombre));
        }
        // Listado de tecnicos
        IEnumerable<Us_Tecnico> tecnicos()
        {
            List<Us_Tecnico> lista = new List<Us_Tecnico>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("List_datos_tecnico", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Us_Tecnico
                {
                    idtecnico = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    nombre_tec = dr.GetString(1)

                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        // Listado Roles
        IEnumerable<Id_roles> id_roles()
        {
            List<Id_roles> lista = new List<Id_roles>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("tb_bhd_gen_servidor_List_Total", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Id_roles
                {
                    IDroles = dr.GetString(0),
                    roles = dr.GetString(1)
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        //Actualizar consumidor
        string ActualizarServidor(Servidores_Total reg)
        {
            string mensaje = string.Empty;
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("usp_actualizar_servidor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod_marca", reg.cod_marca);
                cmd.Parameters.AddWithValue("cod_tienda", reg.cod_tienda);
                cmd.Parameters.AddWithValue("tienda", reg.tienda);
                cmd.Parameters.AddWithValue("ip_servidor", reg.ip_servidor);
                cmd.Parameters.AddWithValue("nom_servidor", reg.nom_servidor);
                cmd.Parameters.AddWithValue("modelo", reg.modelo);
                cmd.Parameters.AddWithValue("serie", reg.serie);
                cmd.Parameters.AddWithValue("sistema_operativo", reg.sistema_operativo);
                cmd.Parameters.AddWithValue("version_micros", reg.version_micros);
                cmd.Parameters.AddWithValue("memoeria_ram", reg.memoria_ram);
                cmd.Parameters.AddWithValue("tamano_bd", reg.tamano_bd);
                cmd.Parameters.AddWithValue("sttus", reg.status);
                cmd.Parameters.AddWithValue("ultimo_reinicio", reg.ultimo_reinicio);
                cmd.Parameters.AddWithValue("version_facturador", reg.version_facturador);
                cmd.Parameters.AddWithValue("ultima_venta", reg.ultima_venta);
                cmd.Parameters.AddWithValue("flg_estado", reg.flg_estado);
                cmd.Parameters.AddWithValue("usuario_crea", reg.usuario_crea);
                cmd.Parameters.AddWithValue("fecha_crea", reg.fecha_crea);
                cmd.Parameters.AddWithValue("usuario_mod", reg.usuario_mod);
                cmd.Parameters.AddWithValue("fecha_mod", reg.fecha_mod);
                cmd.Parameters.AddWithValue("idtecnico", reg.idtecnico);
                cmd.Parameters.AddWithValue("fecha_asignado", reg.fecha_asignado);
                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se actualizo {i} Cliente...";
            }
            catch (MySqlException ex)
            {
                mensaje = ex.Message;
            }
            finally { cn.Close(); }
            return mensaje;
        }
        string AgregarServidor(Servidores_Total reg)
        {
            //Condicion para poder agregar los datos
            if (string.IsNullOrEmpty(reg.cod_marca) || string.IsNullOrEmpty(reg.cod_tienda) ||
            string.IsNullOrEmpty(reg.tienda) || string.IsNullOrEmpty(reg.ip_servidor) ||
            string.IsNullOrEmpty(reg.nom_servidor) || reg.idtecnico == null || reg.fecha_asignado == null)
            {
                return "Por favor, ingrese todos los datos del servidor.";
            }


            string mensaje = string.Empty;
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Ing_Servidores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod_marca", reg.cod_marca);
                cmd.Parameters.AddWithValue("cod_tienda", reg.cod_tienda);
                cmd.Parameters.AddWithValue("tienda", reg.tienda);
                cmd.Parameters.AddWithValue("ip_servidor", reg.ip_servidor);
                cmd.Parameters.AddWithValue("nom_servidor", reg.nom_servidor);
                cmd.Parameters.AddWithValue("modelo", reg.modelo);
                cmd.Parameters.AddWithValue("serie", reg.serie);
                cmd.Parameters.AddWithValue("sistema_operativo", reg.sistema_operativo);
                cmd.Parameters.AddWithValue("version_micros", reg.version_micros);
                cmd.Parameters.AddWithValue("memoria_ram", reg.memoria_ram);
                cmd.Parameters.AddWithValue("tamano_bd", reg.tamano_bd);
                cmd.Parameters.AddWithValue("status", reg.status);
                cmd.Parameters.AddWithValue("ultimo_reinicio", reg.ultimo_reinicio);
                cmd.Parameters.AddWithValue("version_facturador", reg.version_facturador);
                cmd.Parameters.AddWithValue("ultima_venta", reg.ultima_venta);
                cmd.Parameters.AddWithValue("flg_estado", reg.flg_estado);
                cmd.Parameters.AddWithValue("usuario_crea", reg.usuario_crea);
                cmd.Parameters.AddWithValue("fecha_crea", reg.fecha_crea);
                cmd.Parameters.AddWithValue("usuario_mod", reg.usuario_mod);
                cmd.Parameters.AddWithValue("fecha_mod", reg.fecha_mod);
                cmd.Parameters.AddWithValue("idtecnico", reg.idtecnico);
                cmd.Parameters.AddWithValue("fecha_asignado", reg.fecha_asignado);
                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se creo {i} Nuevo Servidor...";
            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
            }
            finally { cn.Close(); }
            return mensaje;
        }
        public ActionResult Create()
        {
            ViewBag.servidor = new SelectList(servidores(), "nom_servidor");
            return View(new Servidores_Total());
        }
        [HttpPost]
        public ActionResult Create(Servidores_Total reg)
        {
            if (string.IsNullOrEmpty(reg.cod_marca) || string.IsNullOrEmpty(reg.cod_tienda) ||
                string.IsNullOrEmpty(reg.tienda) || string.IsNullOrEmpty(reg.ip_servidor) ||
                string.IsNullOrEmpty(reg.nom_servidor) || reg.idtecnico == null || reg.fecha_asignado == null)
            {
                ViewBag.paises = new SelectList(servidores(), "nom_servidor");
                ViewBag.ErrorMessage = "Por favor, ingrese todos los datos del servidor.";
                return View(reg);
            }

            string mensaje = AgregarServidor(reg);

            if (mensaje.StartsWith("Se creo"))
            {
                ViewBag.paises = new SelectList(servidores(), "nom_servidor", reg.nom_servidor);
                ViewBag.mensaje = mensaje;
                return View(new Servidores_Total());
            }
            else
            {
                ViewBag.paises = new SelectList(servidores(), "nom_servidor");
                ViewBag.mensaje = mensaje;
                return View(new Servidores_Total());
            }
        }







        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) { id = string.Empty; }
            Servidores_Total reg = servidores().FirstOrDefault(x => x.tienda == id);

            if (reg != null)
            {
                ViewBag.servidor = new SelectList(servidores(), "tienda", reg.tienda);
                return View(reg);
            }
            else
            {
                // Manejar el caso cuando reg es null, por ejemplo, redirigir a una página de error
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(Servidores_Total reg)
        {
            ViewBag.mensaje = ActualizarServidor(reg);
            ViewBag.servidor = new SelectList(servidores(), "tienda", reg.tienda);
            return View(new Servidores_Total());
        }



        /* Metodo de actualizar */
        public ActionResult Editar(string id)
        {
            if (string.IsNullOrEmpty(id)) { id = string.Empty; }
            Servidores_Total reg = servidores().FirstOrDefault(x => x.tienda == id);
            if (reg == null)
            {
                return RedirectToAction("Error");
            }
            ViewBag.tienda = new SelectList(tecnicos(), "tienda", reg.tienda);
            return View(reg);
        }

        [HttpPost]
        public ActionResult Editar(Servidores_Total reg)
        {
            ViewBag.mensaje = ActualizarServidor(reg);
            ViewBag.tecnicos = new SelectList(tecnicos(), "idtecnicos", "nombretecnico", reg.idtecnico);
            return View(new Servidores_Total());
        }


        /* Eliminar Servidor segun su Nombre */

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("Eliminar_Servidor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nom_servidor", id);

                        cmd.ExecuteNonQuery();
                    }

                    return RedirectToAction("Index", "Home"); // Redirige a la página principal después de eliminar la fila
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la eliminación
                ViewBag.Error = ex.Message;
                return View("Error"); // Muestra una vista de error
            }
        }

        public ActionResult Index()
        {
            return View(servidores());
        }
    }
}