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
            llenar_persona_combo();
                        
        }

        string valor2;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }

        void Limpiar()
        {
            
            txtUsuario.Clear();
            txtContra.Clear();
            
        }

        void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {

            
            txtUsuario.Enabled = true;
            txtContra.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        void Deshabilitar()//Deshabilira todo los textbox y botones
        {
            
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtUsuario.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
                //string.IsNullOrWhiteSpace(txtIdPersona.Text) ||
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                CLogin pLogin = new CLogin();
                //pLogin.IdPersona = txtIdPersona.Text.Trim();
                pLogin.idPersona = valor2;
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public void llenar_persona_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select id_per, nombre_per from tab_persona", conexion1);
                //Select id_tipo, tipo from tab_tipo_persona;
                //se indica el nombre de la tabla
                da.Fill(ds, "Nombre");
                cboPersona.DataSource = ds.Tables[0].DefaultView;

                //se especifica el campo de la tabla
                //cboTipo.ValueMember = "descrip_tipersona";
                cboPersona.ValueMember = "id_per";
                cboPersona.DisplayMember = "nombre_per";


                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor2 = ((System.Data.DataRowView)cboPersona.SelectedItem).Row.ItemArray[0].ToString();
        }

        

             

                

                    
      }
}
