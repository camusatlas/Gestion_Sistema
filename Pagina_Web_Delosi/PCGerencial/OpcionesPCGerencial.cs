using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}