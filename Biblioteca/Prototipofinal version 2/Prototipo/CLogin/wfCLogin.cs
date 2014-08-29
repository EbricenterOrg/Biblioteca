using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Prototipo
{
    public partial class wfCLogin : Form
    {
        public wfCLogin()
        {
            InitializeComponent();

            
            
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        void Limpiar()
        {
            txtIdPersona.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            
        }

        void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {

            txtIdPersona.Enabled = true;
            txtUsuario.Enabled = true;
            txtContra.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        void Deshabilitar()//Deshabilira todo los textbox y botones
        {
            txtIdPersona.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtIdPersona.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPersona.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                CLogin pLogin = new CLogin();
                pLogin.IdPersona = txtIdPersona.Text.Trim();
                pLogin.Usuario = txtUsuario.Text.Trim();
                pLogin.Contra = txtContra.Text.Trim();
               
                
                int resultado = CLoginCo.Agregar(pLogin);
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

        private void wfCLogin_Load(object sender, EventArgs e)
        {

        }

                

                    
      }
}
