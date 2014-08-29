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
using MySql.Data.MySqlClient;

namespace Prototipo
{
    public partial class wfCPersonas : Form
    {
        public wfCPersonas()
        {
            InitializeComponent();
            llenar_descrip_combo();
        }

        //--------------
        //public Persona clienteActual { get; set; }
        string gsPath;
        string valor;

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
            pboFoto.Image = null;
            

        }

        public void Habilitar()//Habilita todo los textbox y botones cuando se presiona el boton de NUEVO
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnExaminar.Enabled = true;
            cboTipo.Enabled = true;

        }
        void Deshabilitar()//a todo los textbox y botones
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
            btnExaminar.Enabled = false;
            cboTipo.Enabled = false;

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtDireccion.Text) )

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Persona pPersona = new Persona();
                pPersona.Nombre = txtNombre.Text.Trim();
                pPersona.Apellido = txtApellido.Text.Trim();
                pPersona.Email = txtEmail.Text.Trim();
                pPersona.Direccion = txtDireccion.Text.Trim();
                //pPersona.Tipo = txtTipo.Text.Trim();
                //pPersona.idpersona = Convert.ToInt32(cboTipo.Text.Trim());
                pPersona.Foto = gsPath;
                pPersona.id_tipersona = valor;
                

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

        private void wfCPersonas_Load(object sender, EventArgs e)
        {
            
        }

               

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) //Verificacion de Campo Nombre
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           
        }

       
        public void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal); //ruta donde inicias a buscar

                if (result == DialogResult.OK)
                {
                    pboFoto.Image = Image.FromFile(dialog.FileName);
                }

                gsPath = dialog.FileName;
                pboFoto.ImageLocation = @gsPath;
                btnGuardar.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No se puede carga la imagen " + ex.Message);
            } 
        }

       
        public void llenar_descrip_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select id_tipersona, descrip_tipersona from tab_tipersona", conexion1);
                //Select id_tipo, tipo from tab_tipo_persona;
                //se indica el nombre de la tabla
                da.Fill(ds, "Descripción");
                cboTipo.DataSource = ds.Tables[0].DefaultView;

                //se especifica el campo de la tabla
                //cboTipo.ValueMember = "descrip_tipersona";
                cboTipo.ValueMember = "id_tipersona";
                cboTipo.DisplayMember = "descrip_tipersona";
                               
               
                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            wfBuscarPersona bp1 = new wfBuscarPersona();
            bp1.ShowDialog();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = ((System.Data.DataRowView)cboTipo.SelectedItem).Row.ItemArray[0].ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

                
    }
}
