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
            txtAutor.Enabled = true;
            txtEdicion.Enabled = true;
            txtEditorial.Enabled = true;
            txtNombre.Enabled = true;
            txtTitulo.Enabled = true;
            txtVolumen.Enabled = true;
        }

        private void cboTipobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          txtAutor.Clear();
            txtEdicion.Clear();
                txtEditorial.Clear();
                    txtNombre.Clear();
                        txtTitulo.Clear();
                            txtVolumen.Clear();
                                txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtAutor.Enabled = false;
            txtEdicion.Enabled = false;
            txtEditorial.Enabled = false;
            txtTitulo.Enabled = false;
            txtVolumen.Enabled = false;

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            txtAutor.Enabled = false;
            txtEdicion.Enabled = false;
            txtEditorial.Enabled = false;
            txtNombre.Enabled = false;
            txtVolumen.Enabled = false;
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            txtEdicion.Enabled = false;
            txtEditorial.Enabled = false;
            txtNombre.Enabled = false;
            txtVolumen.Enabled = false;
            txtTitulo.Enabled = false;
        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {
            txtEdicion.Enabled = false;
            txtAutor.Enabled = false;
            txtNombre.Enabled = false;
            txtVolumen.Enabled = false;
            txtTitulo.Enabled = false;
        }

        private void txtEdicion_TextChanged(object sender, EventArgs e)
        {
            txtAutor.Enabled = false;
            txtEditorial.Enabled = false;
            txtNombre.Enabled = false;
            txtTitulo.Enabled = false;
            txtVolumen.Enabled = false;
        }

        private void txtVolumen_TextChanged(object sender, EventArgs e)
        {
            txtAutor.Enabled = false;
            txtEditorial.Enabled = false;
            txtNombre.Enabled = false;
            txtTitulo.Enabled = false;
            txtEdicion.Enabled = false;
        }
    }
}
