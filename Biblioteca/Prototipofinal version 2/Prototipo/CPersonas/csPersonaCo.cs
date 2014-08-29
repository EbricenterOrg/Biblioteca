using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/*Autor: "Rodrigo Miranda"
 *Fecha: "1/Agosto/2014"
 *Comentario: "Este modulo contendra la iteraccion con la base de datos."
 */

namespace Prototipo
{
    class PersonaCo
    {
        public static int Agregar(Persona pPersona)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_persona (nombre_per, apellido_per, foto_per, correo_per, direccion_per, tipo_per) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                pPersona.Nombre, pPersona.Apellido, pPersona.Foto, pPersona.Email, pPersona.Direccion, pPersona.Tipo), csConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        
    }
}
