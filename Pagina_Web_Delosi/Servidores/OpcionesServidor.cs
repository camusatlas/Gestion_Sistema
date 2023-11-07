using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Servidores
{
    public class OpcionesServidor
    {
        public MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        //Metodo para listar cliente
        public List<Servidor> servidor()
        {
        List<Servidor> listado = new List<Servidor>();
        MySqlCommand cmd = new MySqlCommand("ListarServidor", cn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Servidor servidores= new Servidor()
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
                    listado.Add(servidores);
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
    }
    //Crear Servidor
    

    //Actualizar Servidor


    //Eliminar Servidor



}
