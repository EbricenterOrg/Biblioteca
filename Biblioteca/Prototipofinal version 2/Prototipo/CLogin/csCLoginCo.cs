/*Autor: "Rodrigo Miranda"
 *Fecha: "1/Agosto/2014"
 *Comentario: Clase que va a interactuar con la base de datos, tales que esta clase
 *tendra metodos que nos ejecutaran comandos para tener interaccion con la bd
 *(Insert, Update, Delete, Select, etc).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Prototipo
{
    
    class CLoginCo
    {
        public static int Agregar(CLogin pLogin) /*Metodo que nos permite agregar nuevos usuarios para loguearse.. */
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_usuario (usuario, contras, tab_persona_idpersona) values ('{0}','{1}','{2}')",
            pLogin.Usuario, pLogin.Contra, pLogin.idPersona), csConexion.ObtenerConexion());
                //OdbcCommand comando=  new OdbcCommand(string.Format("Insert into tab_usuario (usuario, contras, tab_persona_idpersona) values ('{0}','{1}','{2}')",
                //pLogin.Usuario, pLogin.Contra, pLogin.IdPersona), csConexion.ObtenerConexionprueba());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Eliminar(int pId_Persona)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tab_persona idpersona={0}", pId_Persona), conexion);
            retorno = comando.ExecuteNonQuery();

            conexion.Close();

            return retorno;
        }
    }
}

