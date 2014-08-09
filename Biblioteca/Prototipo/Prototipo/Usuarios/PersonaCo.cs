using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Prototipo
{
    class PersonaCo
    {
        public static int Agregar(Persona pPersona)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_persona (nombre, apellido, foto, correo, direccion, tipo) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                pPersona.Nombre, pPersona.Apellido, pPersona.Foto, pPersona.Email, pPersona.Direccion, pPersona.Tipo), conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
