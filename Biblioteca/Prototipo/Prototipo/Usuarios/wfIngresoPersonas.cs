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
    public partial class wfIngresoPersonas : Form
    {
        public wfIngresoPersonas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNombre.Focus();
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            cboTipo.ResetText();
            txtFoto.Clear();

        }

        void Habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            cboTipo.Enabled = true;
            txtFoto.Enabled =true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        void Deshabilitar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            cboTipo.Enabled = false;
            txtFoto.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtFoto.Text) ||
                            string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(cboTipo.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Persona pPersona = new Persona();
                pPersona.Nombre = txtNombre.Text.Trim();
                pPersona.Apellido = txtApellido.Text.Trim();
                pPersona.Foto = txtFoto.Text.Trim();
                pPersona.Email = txtEmail.Text.Trim();
                pPersona.Direccion = txtDireccion.Text.Trim();
                pPersona.Tipo = cboTipo.Text.Trim();
                

                int resultado = PersonaCo.Agregar(pPersona);
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        
    }
}
