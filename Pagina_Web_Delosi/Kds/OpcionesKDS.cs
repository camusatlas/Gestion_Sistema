using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Pagina_Web_Delosi.Servidores;

namespace Pagina_Web_Delosi.Kds
{
    public class OpcionesKDS
    {
        public MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        // Metodo para Listar
        public List<EquiposKds> kds()
        {
            List<EquiposKds> listado = new List<EquiposKds>();
            MySqlCommand cmd = new MySqlCommand("ListarKDS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EquiposKds equiposkds = new EquiposKds()
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

                    };
                    listado.Add(equiposkds);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        // Crear KDS
        public string IngresarKDS(EquiposKds reg)
        {

            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("IngresarKDS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empresa", reg.empresa);
                    cmd.Parameters.AddWithValue("@marca", reg.marca);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@nombre_tienda", reg.nombre_tienda);
                    cmd.Parameters.AddWithValue("@provincia", reg.provincia);
                    cmd.Parameters.AddWithValue("@departamento", reg.departamento);
                    cmd.Parameters.AddWithValue("@distrito", reg.distrito);
                    cmd.Parameters.AddWithValue("@ip_kds", reg.ip_kds);
                    cmd.Parameters.AddWithValue("@hostname", reg.hostname);
                    cmd.Parameters.AddWithValue("@status", reg.status);

                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha registrado {i} Servidor";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al intenar ingresar el servidor.";
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        // Actualizar KDS
        public string ActualizarKDS(EquiposKds reg)
        {
            string mensaje = string.Empty;
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("ActualizarKDS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empresa", reg.empresa);
                    cmd.Parameters.AddWithValue("@marca", reg.marca);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@nombre_tienda", reg.nombre_tienda);
                    cmd.Parameters.AddWithValue("@provincia", reg.provincia);
                    cmd.Parameters.AddWithValue("@departamento", reg.departamento);
                    cmd.Parameters.AddWithValue("@distrito", reg.distrito);
                    cmd.Parameters.AddWithValue("@ip_kds", reg.ip_kds);
                    cmd.Parameters.AddWithValue("@hostname", reg.hostname);
                    cmd.Parameters.AddWithValue("@status", reg.status);

                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha actualizado {i} KDS con exito";
                }
            }
            catch (Exception em)
            {
                mensaje = "Error al intenar ingresar el KDS.";
                throw em;
            }
            finally
            {
                if (cn.State != ConnectionState.Open)
                    cn.Close();
            }
            return mensaje;
        }
        public EquiposKds Buscar(string id)
        {
            return kds().FirstOrDefault(x => x.tienda == id);
        }

        // Eliminar KDS
        public string EliminaKDS(string id)
        {
            string mensaje = string.Empty;
            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("EliminarKDS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("tienda", id);

                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se ha eliminado {i} KDS";
            }

            return mensaje;

        }

    }
}