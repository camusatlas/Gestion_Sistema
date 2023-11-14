using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

using System.Data;
using Pagina_Web_Delosi.WorkStation;

namespace Pagina_Web_Delosi.WorkStation
{
    public class OpcionesWorkStation
    {
        public MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        //Metodo para Lista WorkStation
        public List<WorKStation> workstation()
        {
            List<WorKStation> listado = new List<WorKStation>();
            MySqlCommand cmd = new MySqlCommand("ListarWorkStation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    WorKStation workStation = new WorKStation()
                    {
                        cod_marca = dr[0].ToString(),
                        cod_tienda = dr[1].ToString(),
                        tienda = dr[2].ToString(),
                        caja = dr[3].ToString(),
                        ip_workstation = dr[4].ToString(),
                        hostname = dr[5].ToString(),
                        tipo = dr[6].ToString(),
                        modelo = dr[7].ToString(),
                        status = dr[8].ToString(),
                        ultima_venta = dr[9].ToString(),
                        flg_estado = dr[10].ToString(),
                        usuario_crea = dr[11].ToString(),
                        fecha_crea = dr[12].ToString(),
                        usuario_mod = dr[13].ToString(),
                        fecha_mod = dr[14].ToString(),
                        version_facturador = dr[15].ToString()

                    };
                    listado.Add(workStation);
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
        // Crear Punto de WorkStation
        public string IngresarWork(WorKStation reg)
        {
            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@cod_tienda", reg.cod_tienda);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@caja", reg.caja);
                    cmd.Parameters.AddWithValue("@ip_workstation", reg.ip_workstation);
                    cmd.Parameters.AddWithValue("@hostname", reg.hostname);
                    cmd.Parameters.AddWithValue("@tipo", reg.tipo);
                    cmd.Parameters.AddWithValue("@modelo", reg.modelo);
                    cmd.Parameters.AddWithValue("@ip_workstation", reg.ip_workstation);
                    cmd.Parameters.AddWithValue("@hostname", reg.hostname);
                    cmd.Parameters.AddWithValue("@tipo", reg.tipo);
                    cmd.Parameters.AddWithValue("@modelo", reg.modelo);
                    cmd.Parameters.AddWithValue("@status", reg.status);
                    cmd.Parameters.AddWithValue("@ultima_venta", reg.ultima_venta);
                    cmd.Parameters.AddWithValue("@flg_estado", reg.flg_estado);
                    cmd.Parameters.AddWithValue("@usuario_crea", reg.usuario_crea);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.fecha_crea);
                    cmd.Parameters.AddWithValue("@flg_estado", reg.usuario_mod);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.fecha_mod);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.fecha_crea);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.usuario_mod);
                    cmd.Parameters.AddWithValue("@fecha_mod", reg.fecha_mod);
                    cmd.Parameters.AddWithValue("@version_facturador", reg.version_facturador);

                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha registrado {i} WorkStation Nuevo";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al intentar ingresar nuevo WorkStation";
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        //Actualizar WorkStation


        // Eliminar WorkStation




    }
}