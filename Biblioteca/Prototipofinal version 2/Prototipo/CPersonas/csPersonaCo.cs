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

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_persona (nombre_per, apellido_per, foto_per, correo_per, direccion_per,tab_tipersona_id_tipersona) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                pPersona.Nombre, pPersona.Apellido, pPersona.Foto, pPersona.Email, pPersona.Direccion, pPersona.id_tipersona), csConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /*Metodo que nos permite buscar a un cliente por medio una lista*/
        public static List<Persona> Buscar(string pNombre)
        {
            List<Persona> _lista = new List<Persona>();

            //Consulta para buscar el cliente
            //MySqlCommand _comando = new MySqlCommand(String.Format(
           //"SELECT id_per, nombre_per, apellido_per, direccion_per,correo_per,tab_tipersona_id_tipersona,foto_per FROM tab_persona  where nombre_per ='{0}' or apellido_per='{1}'", pNombre, pApellido), csConexion.ObtenerConexion());
            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT id_per, nombre_per, apellido_per, foto_per, correo_per,direccion_per,tab_tipersona_id_tipersona FROM tab_persona  where nombre_per LIKE '{0}%' ", pNombre), csConexion.ObtenerConexion());
                //"SELECT id_per, nombre_per, apellido_per, direccion_per,correo_per,tab_tipersona_id_tipersona,foto_per FROM tab_persona  where nombre_per LIKE '%{0}%' or apellido_per LIKE '%{1}%'", pNombre, pApellido), csConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Persona pPersona = new Persona();

                pPersona.id_per = _reader.GetInt32(0);
                pPersona.Nombre = _reader.GetString(1);
                pPersona.Apellido = _reader.GetString(2);
                pPersona.Foto = _reader.GetString(3);
                pPersona.Email = _reader.GetString(4);
                pPersona.Direccion = _reader.GetString(5);
                pPersona.id_tipersona = _reader.GetString(6);
                
                
                //   pCliente.sApellido2_cte = _reader.GetString(4);
                //pPersona.snit_cte = _reader.GetString(5);

                _lista.Add(pPersona);
            }

            return _lista;
        }

        public static Persona ObtenerCliente(int pidpersona)
        {
            Persona pPersona = new Persona();
            MySqlConnection conexion = csConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT id_per, nombre_per, apellido_per, foto_per, correo_per,direccion_per,tab_tipersona_id_tipersona FROM tab_persona where id_per={0}", pidpersona), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                pPersona.id_per = _reader.GetInt32(0);
                pPersona.Nombre = _reader.GetString(1);
                pPersona.Apellido = _reader.GetString(2);
                pPersona.Foto = _reader.GetString(3);
                pPersona.Email = _reader.GetString(4);
                pPersona.Direccion = _reader.GetString(5);
                pPersona.id_tipersona = _reader.GetString(6);
                                               
            }

            conexion.Close();
            return pPersona;
        }

        public static int Eliminar(int pidpersona)
        {
            int retorno = 0;
            MySqlConnection conexion = csConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tab_persona where idpersona={0}", pidpersona), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        
    }
}
