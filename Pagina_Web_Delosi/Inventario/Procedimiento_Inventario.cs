using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Pagina_Web_Delosi.Inventario
{
    public class Procedimiento_Inventario
    {
        public MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ServidorDelosi"].ConnectionString);
        /* Metodo para Listar todas la tablas */
        // Listado Equipo
        public List<Equipos> equipos()
        {
            List<Equipos> listado = new List<Equipos>();
            MySqlCommand cmd = new MySqlCommand("", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipos equipo = new Equipos()
                    {
                        id_equipo = dr.GetInt32(0),
                        tipo_equipo = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        nom_marca = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        modelo_equipo = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        cantidad = !dr.IsDBNull(4) ? dr.GetInt32(4) : 0,
                    };
                    listado.Add(equipo);
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

        // Listado de Estados
        public List<Estado> estado()
        {
            List<Estado> listado = new List<Estado>();
            MySqlCommand cmd = new MySqlCommand("", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Estado equipo = new Estado()
                    {
                        idestado = dr.GetInt32(0),
                        estado = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                    };
                    listado.Add(equipo);
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

        // Listado de Inventario
        public List<Inventario> inventario()
        {
            List<Inventario> listado = new List<Inventario>();
            MySqlCommand cmd = new MySqlCommand("", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Inventario equipo = new Inventario()
                    {
                        id = dr.GetInt32(0),
                        id_equipo = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        id_estado = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        fecha_ingreso = !dr.IsDBNull(3) ? dr.GetDateTime(3) : DateTime.MinValue,
                        id_asignado = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                        id_almacen = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                        cantidad = dr.GetInt32(6),
                        marca = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                        modelo = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                        id_responsable = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                        num_guia_ingreso = dr.GetInt32(10),
                        usuario = !dr.IsDBNull(11) ? dr.GetString(11) : null,
                        destino = !dr.IsDBNull(12) ? dr.GetString(12) : null,
                        id_tienda = !dr.IsDBNull(13) ? dr.GetString(13) : null,
                        fechasalida = !dr.IsDBNull(14) ? dr.GetDateTime(14) : DateTime.MinValue,
                        id_tecnico = !dr.IsDBNull(15) ? dr.GetString(15) : null,
                        tiket = !dr.IsDBNull(4) ? dr.GetInt32(4) : 0,
                        num_guia_salida = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        id_proveeor = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        orden_compra = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        orden_interna = !dr.IsDBNull(4) ? dr.GetInt32(4) : 0,
                        afecoactivo_fijo = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        almacen_ingreso = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        cod_material_sap = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        razon_social = !dr.IsDBNull(4) ? dr.GetInt32(4) : 0,
                        prioridad = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        id_sistem_operativo = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        direction_mac = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        especificaciones = !dr.IsDBNull(4) ? dr.GetInt32(4) : 0,
                        fecha_grantia = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        fecha_actualizacion = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        observaction = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                    };
                    listado.Add(equipo);
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