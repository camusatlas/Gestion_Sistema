using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagina_Web_Delosi.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        IEnumerable<Servidor_Datos_Tienda> tienda()
        {
            List<Servidor_Datos_Tienda> lista = new List<Servidor_Datos_Tienda>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("List_datos_tienda", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servidor_Datos_Tienda
                {
                    cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    departamento = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    provincia = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    distrito = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    mail_tienda = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    flg_multimarca = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    flg_delivery = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    cod_ger_area = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    gte_area = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                    mail_gte_area = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                    tlfno_gte_area = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                    rank_total = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                    rank_marca = !dr.IsDBNull(14) ? dr.GetString(14) : null
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }

        IEnumerable<Servidor_Datos_Tienda> buscar_tienda(string nombre)
        {
            List<Servidor_Datos_Tienda> lista = new List<Servidor_Datos_Tienda>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("Busc_List_Tienda", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_tienda", nombre);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servidor_Datos_Tienda
                {
                    cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                    cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    departamento = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    provincia = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    distrito = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    mail_tienda = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    flg_multimarca = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    flg_delivery = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    cod_ger_area = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    gte_area = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                    mail_gte_area = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                    tlfno_gte_area = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                    rank_total = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                    rank_marca = !dr.IsDBNull(14) ? dr.GetString(14) : null
                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }

        public ActionResult Index_buscar_tienda_total(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(buscar_tienda(nombre));
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}