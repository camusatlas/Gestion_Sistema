﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

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
                        marca = !dr.IsDBNull(1) ? dr.GetString(1) : null,
                        tienda = !dr.IsDBNull(2) ? dr.GetString(2) : null,
                        nombre_tienda = !dr.IsDBNull(3) ? dr.GetString(3) : null,
                        provicia = !dr.IsDBNull(4) ? dr.GetString(4) : null,
                        departamento = !dr.IsDBNull(5) ? dr.GetString(5) : null,
                        distrito = !dr.IsDBNull(6) ? dr.GetString(6) : null,
                        ip_kds = !dr.IsDBNull(7) ? dr.GetString(7) : null,
                        hostname = !dr.IsDBNull(8) ? dr.GetString(8) : null,
                        status = !dr.IsDBNull(9) ? dr.GetString(9) : null,
                        join_tienda = !dr.IsDBNull(10) ? dr.GetString(10) : null
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



        // Actualizar KDS

        
        // Eliminar KDS


    }
}