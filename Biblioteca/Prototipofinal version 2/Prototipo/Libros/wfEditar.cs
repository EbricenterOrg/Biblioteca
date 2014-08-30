
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Prototipo
{
    public partial class wfEditar : Form
    {
        OdbcConnection Conn = new System.Data.Odbc.OdbcConnection("DSN=abc;");
        public wfEditar()
        {
            InitializeComponent();
        }

        public void cargarinformacion(String id)
        {

            

            Conn.Open();
            string comando;

            comando = "SELECT id_lib,nombre_lib,titulo_lib, nopag_lib, volumen_lib,fecha_lib,edicion_lib,disponibilidad_lib from tab_libro where id_lib=" + id;

            OdbcCommand cmd = new OdbcCommand(comando,Conn);

            OdbcDataReader reader = cmd.ExecuteReader();
            

            if (reader.Read())
            {
                txtlibro.Text = ""+(int)reader["id_lib"];
                txtNombre.Text = (string)reader["nombre_lib"];
                txtTitulo.Text = (string)reader["titulo_lib"];
                //nudpag.Value = (int)reader["nopag_lib"];
                //nudVol.Value = (int)reader["volumen_lib"];
                //nudEdi.Value = (int)reader["edicion_lib"];



            }
            reader.Close();
            Conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            



            Conn.Open();
            
            //string update = "UPDATE tab_libro SET nombre_lib=" + txtNombre.Text + ",titulo_lib=" + txtTitulo.Text + ", nopag_lib=" + nudpag.Value + ", volumen_lib=" + nudVol.Value + ",edicion_lib=" + nudEdi.Value + " where id_lib=" + txtlibro;
            //string update = "UPDATE tab_libro SET nombre_lib=@nombrelibro, titulo_lib=@titulolibro, nopag_lib=@numeropaglibro, volumen_lib=@volumenlibro, edicion_lib=@edicionlibro where id_lib=@idlibro";
            string update = "UPDATE tab_libro SET nombre_lib=@nombrelibro, where id_lib=@idlibro";

            OdbcCommand cmd = new OdbcCommand(update, Conn);

            cmd.Parameters.AddWithValue("@idlibro", txtlibro.Text);
            cmd.Parameters.AddWithValue("@nombrelibro", txtNombre.Text);
            cmd.Parameters.AddWithValue("@titulolibro", txtTitulo.Text);
            cmd.Parameters.AddWithValue("@numeropaglibro", nudpag.Value);
            cmd.Parameters.AddWithValue("@volumenlibro", nudVol.Value);
            cmd.Parameters.AddWithValue("@edicionlibro", nudEdi.Value);

            //cmd.Parameters.AddWithValue("@idlibro", 6);
            //cmd.Parameters.AddWithValue("@nombrelibro", "casa");
            //cmd.Parameters.AddWithValue("@titulolibro", "bueno");
            //cmd.Parameters.AddWithValue("@numeropaglibro", 100);
            //cmd.Parameters.AddWithValue("@volumenlibro", 2);
            //cmd.Parameters.AddWithValue("@edicionlibro", 3);
            

            int ingreso = cmd.ExecuteNonQuery();

            
            //if(ingreso==0)
            //{
            //    MessageBox.Show("No se pudo actualizar");
            //}
            //else
            //{
            //    MessageBox.Show("Actualizado");
            //}



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtNombre.Clear();
            txtTitulo.Clear();
            
           // txtEdicion.Clear();
            
            //txtVolumen.Clear();
            
           // txtCodigo.Focus();

            Desabilitar();


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {


        


        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void Habilitar()
        {
            txtNombre.Enabled = true;
            txtTitulo.Enabled = true;
            nudpag.Enabled = true;
            nudVol.Enabled = true;
            nudEdi.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void Desabilitar()
        {
            txtNombre.Enabled = false;
           
            txtTitulo.Enabled = false;
            
            nudpag.Enabled = false;
            
            nudVol.Enabled = false;
            
            nudEdi.Enabled = false;
            
            btnLimpiar.Enabled = false;
        }



        private void btnAgrega_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtNombre_keypress(object sender, KeyPressEventArgs e)
        {

        }

        
    }

         
}
