using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Pagina_Web_Delosi.Servidores
{
    public class OpcionesServidor
    {
        private MySqlConnection cn;
        public OpcionesServidor()
        {
            cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        }
        //Metodo para listar cliente
        public List<Servidor> servidor()
        {
        List<Servidor> listado = new List<Servidor>();
        MySqlCommand cmd = new MySqlCommand("ListarServidor", cn);
        cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Servidor servidor = new Servidor()
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
                        };
                        listado.Add(servidor);
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return listado;
        }

        //Crear Servidor
        public string Ingresar(Servidor reg)
        {

            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("Ing_Servidores", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod_marca", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@cod_tienda", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@tienda", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@ip_servidor", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@nom_servidor", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@modelo", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@serie", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@sistema_operativo", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@version_micros", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@memoria_ram", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@tamano_bd", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@status", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@ultimo_reinicio", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@version_facturador", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@ultima_venta", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@flg_estado", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@usuario_crea", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@fecha_mod", reg.cod_marca);

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
        
        //Actualizar Servidor
        public string Actualizar(Servidor reg)
        {
            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("usp_actualizar_servidor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod_marca", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@cod_tienda", reg.cod_tienda);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@ip_servidor", reg.ip_servidor);
                    cmd.Parameters.AddWithValue("@nom_servidor", reg.nom_servidor);
                    cmd.Parameters.AddWithValue("@modelo", reg.modelo);
                    cmd.Parameters.AddWithValue("@serie", reg.serie);
                    cmd.Parameters.AddWithValue("@sistema_operativo", reg.sistema_operativo);
                    cmd.Parameters.AddWithValue("@version_micros", reg.version_micros);
                    cmd.Parameters.AddWithValue("@memoria_ram", reg.memoria_ram);
                    cmd.Parameters.AddWithValue("@tamano_bd", reg.tamano_bd);
                    cmd.Parameters.AddWithValue("@status", reg.status);
                    cmd.Parameters.AddWithValue("@ultimo_reinicio", reg.ultimo_reinicio);
                    cmd.Parameters.AddWithValue("@version_facturador", reg.version_facturador);
                    cmd.Parameters.AddWithValue("@ultima_venta", reg.ultima_venta);
                    cmd.Parameters.AddWithValue("@flg_estado", reg.flg_estado);
                    cmd.Parameters.AddWithValue("@usuario_crea", reg.usuario_crea);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.fecha_crea);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.usuario_mod);
                    cmd.Parameters.AddWithValue("@fecha_mod", reg.fecha_mod);

                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha actualizado {i} Servidor con exito";
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
        public Servidor Buscar(string id)
        {
            return servidor().FirstOrDefault(x => x.tienda == id);
        }

        //Eliminar Servidor
        public string Eliminar(string id)
        {
            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("Eliminar_Servidor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tienda", id);
                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha eliminado {i} Servidor";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al intentar eliminar el servidor.";
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }


    }

}
