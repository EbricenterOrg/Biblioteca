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
    public partial class wfBuscarPersona : Form
    {
        public wfBuscarPersona()
        {
            InitializeComponent();
        }

       
        //public Persona ClienteSelecionado { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBNombre.Text))

                MessageBox.Show("Ingrese un Dato!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                dgvBusqueda.DataSource = PersonaCo.Buscar(txtBNombre.Text);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtBNombre.Focus();
        }

        void Limpiar()
        {
            txtBNombre.Clear();
            
        }

        void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {

            txtBNombre.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            
            if (dgvBusqueda.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBusqueda.CurrentRow.Cells[0].Value);
               // ClienteSelecionado = PersonaCo.ObtenerCliente(id);

                this.Close();
            }
            else
                MessageBox.Show("Tiene que seleccionar una fila");
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
