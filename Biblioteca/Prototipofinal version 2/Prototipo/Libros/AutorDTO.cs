using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Prototipo.Libros
{
    class AutorDTO
    {
       // public static List<Autor> ObtenerAutores()
        //{
            /*
            List<Autor> _lista = new List<Autor>();
            SqlTransaction Transaccion_bd = new SqlTransaction();
            //SqlCommand _comando = new SqlCommand("select IdCiudad , Nombre from Ciudades", Libros.conexion.ObtenerConexion());
            SqlCommand _comando = new SqlCommand(string.Format("select IdCiudad , Nombre from Ciudades"), Libros.conexion.ObtenerConexion(), Transaccion_bd);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Autor pAutor = new Autor();

                pAutor.Nombre_autor = _reader.GetString(0);
                pAutor.Apellido_autor = _reader.GetString(1);

                _lista.Add(pAutor);
            }

            return _lista;
        */
        //}
    }
}
