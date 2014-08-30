using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
namespace busqueda
{
    class conexion
    {
        OdbcConnection Conn = new System.Data.Odbc.OdbcConnection("DSN=abc;");


        public DataTable cargarconsulta()
        {

            OdbcCommand catCMD = new OdbcCommand("SELECT a.id_lib, a.nombre_lib, a.titulo_lib, a.edicion_lib, a.tab_autor_id_autor, a.tab_editorial_id_edit, b.id_edit, b.nombre_edit, c.id_autor, c.nombre_autor, c.apellido_autor FROM tab_libro a, tab_editorial b, tab_autor c WHERE a.tab_autor_id_autor = c.id_autor OR a.tab_editorial_id_edit = b.id_edit;", Conn);

            Conn.Open();

            OdbcDataReader myReader = catCMD.ExecuteReader();

             DataTable dt = new DataTable ();
             dt.Clear();
            dt.Load(myReader);
            
            myReader.Close();
            Conn.Close();

            return dt;
        }
        public DataTable consultaespecifica(String consulta)
        {

            OdbcCommand catCMD = new OdbcCommand(consulta, Conn);

            Conn.Open();

            OdbcDataReader myReader = catCMD.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Load(myReader);

            myReader.Close();
            Conn.Close();

            return dt;
        }

    }
}
