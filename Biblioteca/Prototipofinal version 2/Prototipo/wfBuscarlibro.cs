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

namespace busqueda
{
    public partial class wfBuscar : Form
    {
        public wfBuscar()
        {
            InitializeComponent();
        }
        conexion con = new conexion();
        private static wfBuscar consulta;
        private void button1_Click(object sender, EventArgs e)
        {




            string consulta = null;

            if (rbtnNinguno.Checked == true)
            {

                dataGridView1.DataSource = con.consultaespecifica(consulta);

            }

            if (rbtnAutor.Checked == true)
            {
                //* busqueda mediante un autor especifico *//
                consulta = "SELECT a.id_lib, a.nombre_lib, a.tab_autor_id_autor, b.id_autor, b.nombre_autor";
                consulta += " FROM tab_libro a, tab_autor b";
                consulta += " WHERE b.nombre_autor LIKE  '" + txtBuscar.Text + "%'";


                dataGridView1.DataSource = con.consultaespecifica(consulta);
            }
            if (rbtnEditorial.Checked == true)
            {
                //* busqueda mendiante una editorial especifica *//
                consulta = "SELECT a.id_lib, a.nombre_lib, a.tab_editorial_id_edit, b.id_edit, b.nombre_edit";
                consulta += " FROM tab_libro a, tab_editorial b";
                consulta += " WHERE b.nombre_edit LIKE  '" + txtBuscar.Text + "%'";

                dataGridView1.DataSource = con.consultaespecifica(consulta);
            }
            if (rbtnEdicion.Checked == true)
            {
                //* busqueda mediente una editorial especifica *//
                consulta = "SELECT * FROM tab_libro WHERE edicion_lib LIKE  '" + txtBuscar.Text + "%'";

                dataGridView1.DataSource = con.consultaespecifica(consulta);
            }


            //dataGridView1.DataSource = con.cargarconsulta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.cargarconsulta();
        }

        private void rbtnAutor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNinguno_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rbtnEditorial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresoToolStrinpMenuItem_Click(object sender, EventArgs e)
        {

            wfBuscar info2 = new wfBuscar();
            info2.ShowDialog();
        }

        private void rbtnDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        public wfBuscar libroseleccionado { get; set; }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id_lib = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                libroseleccionado = wfBuscar.cargarconsulta(id_lib);
                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private static wfBuscar cargarconsulta(int id_lib)
        {
            throw new NotImplementedException();
        }
    }
}



;


    

