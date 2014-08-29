/*Autor: "Rodrigo Miranda"//
 *Fecha: "3/Agosto/2014"
 *Comentario: "Este modulo contendra la conexion a la base de datos"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prototipo
{
    class csConexion
    {
        
        public static MySqlConnection ObtenerConexion()
        {
            
            
            //MySqlConnection conectar = new MySqlConnection("server=localhost;port=3306;uid=root;password=;database=dbiblioteca;");
           MySqlConnection conectar = new MySqlConnection("server=192.168.1.3;port=3306;database=dbiblioteca;Uid=prueba; password=1234;");
            //server=127.0.0.1
            conectar.Open();
            return conectar;

        }
       
    }
}
