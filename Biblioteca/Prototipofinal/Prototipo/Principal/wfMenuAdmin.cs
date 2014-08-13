using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo.Principal
{
    public partial class wfMenuAdmin : Form
    {
        public wfMenuAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfEditorial cedit = new wfEditorial();
            cedit.MdiParent = this;
            cedit.Show();
        }

        private void ingreasrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfIngresoLibro ingreso = new wfIngresoLibro();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfMateria mat = new wfMateria();
            mat.MdiParent = this;
            mat.Show();
        }

        private void corrienteLiterariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfCorrienteLiteraria mat = new wfCorrienteLiteraria();
            mat.MdiParent = this;
            mat.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfBusquedaLibro info = new wfBusquedaLibro();
            info.MdiParent = this;
            info.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfEditar info = new wfEditar();
            info.MdiParent = this;
            info.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfCPersonas info2 = new wfCPersonas();
            info2.MdiParent = this;
            info2.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfCLogin info3 = new wfCLogin();
            info3.MdiParent = this;
            info3.Show();
        }
    }
}
