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
    public partial class wfMenuAdministrador : Form
    {
        public wfMenuAdministrador()
        {
            InitializeComponent();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfIngresoPersonas cautor = new wfIngresoPersonas();
            cautor.MdiParent = this;
            cautor.Show();
        }

        private void btnCAutor_Click(object sender, EventArgs e)
        {
            wfAutor cautor = new wfAutor();
            cautor.MdiParent = this;
            cautor.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfEditorial cedit = new wfEditorial();
            cedit.MdiParent = this;
            cedit.Show();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            wfIngresoLibro ingreso = new wfIngresoLibro();
            ingreso.MdiParent = this;
            ingreso.Show();
        }
    }
}
