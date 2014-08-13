using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipo {
	public partial class wfMenuBibliotecario : Form {
		
		
		public wfMenuBibliotecario() {
			InitializeComponent();
		}
		
		void WfMenuLoad(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Conectado al Administrador";
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
            wfBusquedaLibro info = new wfBusquedaLibro();
            info.MdiParent = this;
            info.Show();
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            alquiler.wfAlquiler ingreso = new alquiler.wfAlquiler();
            ingreso.MdiParent = this;
            ingreso.Show();
            
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            wfIngresoLibro ingreso = new wfIngresoLibro();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void btnGu_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wfAutor ingemple = new wfAutor();
            ingemple.MdiParent = this;
            ingemple.Show();
        }

        private void btnCLiteraria_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCAutor_Click(object sender, EventArgs e)
        {
            wfAutor cautor = new wfAutor();
            cautor.MdiParent = this;
            cautor.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
         
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           wfMateria mat = new wfMateria();
            mat.MdiParent = this;
            mat.Show();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void msMenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editorialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            wfEditorial cedit = new wfEditorial();
            cedit.MdiParent = this;
            cedit.Show();
        }

        private void materiaToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alquiler.wfAlquiler mat = new alquiler.wfAlquiler();
            mat.MdiParent = this;
            mat.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alquiler.wfentrega_libro mat = new alquiler.wfentrega_libro();
            mat.MdiParent = this;
            mat.Show();
        }

        

        

       

        
	}
}
