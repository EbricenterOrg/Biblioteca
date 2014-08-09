using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipo {
	public partial class btnprodu : Form {
		
		
		public btnprodu() {
			InitializeComponent();
		}
		
		void WfMenuLoad(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Conectado - Ad";
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e) {
			this.Close();
		}

        private void btninfo_Click(object sender, EventArgs e)
        {
                        
            wfAcercaDe info = new wfAcercaDe();
            info.MdiParent = this;
            info.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfBusquedaLibro busc = new wfBusquedaLibro();
            busc.MdiParent = this;
            busc.Show();
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            wfAlquiler alquilar = new wfAlquiler();
            alquilar.MdiParent = this;
            alquilar.Show();
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            wfIngresarLibros ingreso = new wfIngresarLibros();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void btnGu_Click(object sender, EventArgs e)
        {
            wfEditar editar = new wfEditar();
            editar.MdiParent = this;
            editar.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfIngresoPersonas ingemple = new wfIngresoPersonas();
            ingemple.MdiParent = this;
            ingemple.Show();
        }

        private void btnCLiteraria_Click(object sender, EventArgs e)
        {
            wfCLiteraria lite = new wfCLiteraria();
            lite.MdiParent = this;
            lite.Show();
        }

        private void btnCAutor_Click(object sender, EventArgs e)
        {
            wfCAutor cautor = new wfCAutor();
            cautor.MdiParent = this;
            cautor.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfCEditorial cedit = new wfCEditorial();
            cedit.MdiParent = this;
            cedit.Show();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            wfEliminar elim = new wfEliminar();
            elim.MdiParent = this;
            elim.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfCMateria mat = new wfCMateria();
            mat.MdiParent = this;
            mat.Show();
        }

        

        

       

        
	}
}
