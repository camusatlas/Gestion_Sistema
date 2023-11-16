using MySql.Data.MySqlClient;
using Pagina_Web_Delosi.Servidores;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.PCGerencial
{
    public class OpcionesPCGerencial
    {
        public MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        // Metodo para listar PcGerencial
        public List<PCGerencial> pcgerencial()
        {
            List<PCGerencial> listado = new List<PCGerencial>();
            MySqlCommand cmd = new MySqlCommand("ListPCGerencial", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PCGerencial pc = new PCGerencial()
                    {
                        cod_marca = !dr.IsDBNull(0) ? dr.GetString(0) : null,
                        cod_tienda = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        ip_gerente = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        nom_pc_gerencial = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                        modelo = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                        serie = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                        sistema_operativo = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                        memoria_ram = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                        procesador = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                        status = !dr.IsDBNull(10) ? dr.GetString(10) : null,
                        flg_stado = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                        usuario_crea = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                        fecha_crea = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                        usuario_mod = !dr.IsDBNull(14) ? dr.GetString(14) : null,
                        fecha_mod = !dr.IsDBNull(15) ? dr.GetString(15) : null
                    };
                    listado.Add(pc);
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

        // Agregar PCGerencial
        public string IngresarPCGerencial(PCGerencial reg)
        {

            string mensaje = string.Empty;
            try
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("Ing_Servidores", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cod_marca", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@cod_tienda", reg.cod_tienda);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@ip_gerente", reg.ip_gerente);
                    cmd.Parameters.AddWithValue("@ip_gerente", reg.nom_pc_gerencial);
                    cmd.Parameters.AddWithValue("@modelo", reg.modelo);
                    cmd.Parameters.AddWithValue("@serie", reg.serie);
                    cmd.Parameters.AddWithValue("@sistema_operativo", reg.sistema_operativo);
                    cmd.Parameters.AddWithValue("@memoria_ram", reg.memoria_ram);
                    cmd.Parameters.AddWithValue("@procesador", reg.procesador);
                    cmd.Parameters.AddWithValue("@status", reg.status);
                    cmd.Parameters.AddWithValue("@flg_stado", reg.flg_stado);
                    cmd.Parameters.AddWithValue("@usuario_crea", reg.usuario_crea);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.fecha_crea);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.usuario_mod);
                    cmd.Parameters.AddWithValue("@fecha_mod", reg.fecha_mod);

                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha registrado {i} PC Gerencial";
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

        // Actualizar PC Gerencial
        public string ActualizarPCGerencial(PCGerencial reg)
        {
            string mensaje = string.Empty;
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("usp_actualizar_servidor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cod_marca", reg.cod_marca);
                    cmd.Parameters.AddWithValue("@cod_tienda", reg.cod_tienda);
                    cmd.Parameters.AddWithValue("@tienda", reg.tienda);
                    cmd.Parameters.AddWithValue("@ip_gerente", reg.ip_gerente);
                    cmd.Parameters.AddWithValue("@ip_gerente", reg.nom_pc_gerencial);
                    cmd.Parameters.AddWithValue("@modelo", reg.modelo);
                    cmd.Parameters.AddWithValue("@serie", reg.serie);
                    cmd.Parameters.AddWithValue("@sistema_operativo", reg.sistema_operativo);
                    cmd.Parameters.AddWithValue("@memoria_ram", reg.memoria_ram);
                    cmd.Parameters.AddWithValue("@procesador", reg.procesador);
                    cmd.Parameters.AddWithValue("@status", reg.status);
                    cmd.Parameters.AddWithValue("@flg_stado", reg.flg_stado);
                    cmd.Parameters.AddWithValue("@usuario_crea", reg.usuario_crea);
                    cmd.Parameters.AddWithValue("@fecha_crea", reg.fecha_crea);
                    cmd.Parameters.AddWithValue("@usuario_mod", reg.usuario_mod);
                    cmd.Parameters.AddWithValue("@fecha_mod", reg.fecha_mod);


                    int i = cmd.ExecuteNonQuery();
                    mensaje = $"Se ha actualizado {i} PC GErencial con exito";
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al intenar ingresar el servidor.";
                throw ex;
            }
            finally
            {
                if (cn.State != ConnectionState.Open)
                    cn.Close();
            }
            return mensaje;
        }
        public PCGerencial Buscar(string id)
        {
            return pcgerencial().FirstOrDefault(x => x.tienda == id);
        }

        // Eliminar PC Gerencial
        public string Eliminar(string id)
        {
            string mensaje = string.Empty;
            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("Eliminar_Servidor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("tienda", id);

                int i = cmd.ExecuteNonQuery();
                mensaje = $"Se ha eliminado {i} PC Gerencial";
            }

            return mensaje;

        }

    }
}