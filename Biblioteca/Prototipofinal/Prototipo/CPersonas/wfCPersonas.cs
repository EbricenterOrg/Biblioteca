/*Autor: "Rodrigo Miranda"
 *Fecha: "1/Agosto/2014"
 *Comentario: "Este modulo contendra la validacion de información y guardar datos."
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
    public partial class wfCPersonas : Form
    {
        public wfCPersonas()
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
            txtTipo.ResetText();
            txtFoto.Clear();

        }

        void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTipo.Enabled = true;
            txtFoto.Enabled =true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        void Deshabilitar()//Deshabilira todo los textbox y botones
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTipo.Enabled = false;
            txtFoto.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtFoto.Text) ||
                            string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTipo.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Persona pPersona = new Persona();
                pPersona.Nombre = txtNombre.Text.Trim();
                pPersona.Apellido = txtApellido.Text.Trim();
                pPersona.Foto = txtFoto.Text.Trim();
                pPersona.Email = txtEmail.Text.Trim();
                pPersona.Direccion = txtDireccion.Text.Trim();
                pPersona.Tipo = txtTipo.Text.Trim();
                

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
