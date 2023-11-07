using Microsoft.Ajax.Utilities;
using MySql.Data.MySqlClient;
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
        IEnumerable<EquiposKds> kds()
        {
            List<EquiposKds> lista = new List<EquiposKds>();
            MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("ListarKDS", cn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new EquiposKds
                {
                    marca = !dr.IsDBNull(1) ?  dr.GetString(1) : null,
                    tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                    nombre_tienda = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    provicia = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                    departamento = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                    distrito = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                    ip_kds = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                    hostname = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                    status = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                    join_tienda = !dr.IsDBNull(10) ? dr.GetString(10) : null,

                });
            }
            dr.Close();
            cn.Close();
            return lista;
        }
        public ActionResult BuscarKDS(string nombre)
        {
            if (nombre == null) nombre = string.Empty;
            return View(kds());
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}