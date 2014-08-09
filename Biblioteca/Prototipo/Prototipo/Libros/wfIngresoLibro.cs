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
    public partial class wfIngresoLibro : Form
    {
        public wfIngresoLibro()
        {
            InitializeComponent();
        }

        private void wfIngresoLibro_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            //MessageBox.Show("Conectado");
        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
