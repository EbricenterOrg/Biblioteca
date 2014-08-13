/*Autor: "Biverlyn López"
 * Fecha: "30/Julio/2014"
 * Comentario: "Este módulo mostrará la busqueda de libros, ya sea por autor, titulo, etc." 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class wfBusquedaLibro : Form
    {
        string gsQuery;
        public wfBusquedaLibro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            using (MySqlConnection conexion = dbiblioteca.ObtenerConexion()) ;
            gsQuery = "select a.id_lib, a.nombre_lib, titulo_lib, a.edicion_lib, a.volumen_lib, a.tab_autor_id_autor, a.tab_editorial_id_edit, a.tab_corriente_idliteraria_corriente, b.id_autor, b.nombre_autor, b.apellido_autor, c.id_edit, c.nombre_edit from tab_libro a, tab_autor b, tab_editorial c where a.tab_autor_id_autor = b.id_autor and (b.nombre_autor like '" + txtBuscarDato.Text + "%' or a.nombre_lib like '" + txtBuscarDato.Text + "%', or a.volumen_lib like '" + txtBuscarDato.Text + "%', or a.edicion_lib like '" + txtBuscarDato.Text + "%') order by nombre_lib asc;";
            MysqlConnection reader = comando.ExcuteReader();

            conectar.Open();
            return conectar;
        }

        private void cboTipobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarDato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void grbTipoBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscarDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            btnBuscar_Click(this, e);
        }

    }
}
