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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(txtNombre.Text))

                MessageBox.Show("Ingrese un Dato!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Focus();
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
        }

        void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            btnLimpiar.Enabled = true;

        }
    }
}
