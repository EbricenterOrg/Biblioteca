using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Prototipo
{
   public class conexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=dbiblioteca; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }


    }
}
