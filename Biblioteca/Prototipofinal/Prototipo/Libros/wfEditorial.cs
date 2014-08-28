/*Autor: "Carol Flores"
 *Fecha: "09/Agosto/2014"
 *Comentario: "Este modulo realizara el ingreso de la Editorial del libro"
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
    public partial class wfEditorial : Form
    {




        // ****************************LIMPIAR TEXBOX DEL FORMULARIO*****************************

        // Declaramos nuestro metodo que hara la limpieza de los textbox
        public void LimpiarTextBox(Form ofrm)
        {

            // hace un chequeo por todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {


                    oControls.Text = ""; // eliminar el texto

                }



            }


        }


        //*********************************FIN DE LIMPIEZA DE TEXBOX****************************












        int giEnviar;

        public wfEditorial()
        {
            InitializeComponent();
        }

        private void wfEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnIngreEdit_Click(object sender, EventArgs e)
        {
            string a;
            int iBandera = 0;

            if (string.IsNullOrWhiteSpace(txtNomEdit.Text) || string.IsNullOrWhiteSpace(txtDirec.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtCiudad.Text) )

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                csConexion.ObtenerConexion();
               
                a = "";

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_editorial values ('{0}','{1}','{2}','{3}','{4}')", a, txtNomEdit.Text, txtDirec.Text, txtTel.Text, txtCiudad.Text), csConexion.ObtenerConexion());

                giEnviar = comando.ExecuteNonQuery();
                iBandera = 1;
            }

            if (iBandera == 1)
            {
                MessageBox.Show("Editorial Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox(this);
                Desabilitar();

            }
            else
            {
                MessageBox.Show("No se pudo guardar la Editorial", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimpiarTextBox(this);
            txtNomEdit.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomEdit_TextChanged(object sender, EventArgs e)
        {

        }


        public void Habilitar()
        {
            txtNomEdit.Enabled = true;
            txtDirec.Enabled = true;
            txtCiudad.Enabled = true;
            txtTel.Enabled = true;
            btnIngreEdit.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void Desabilitar()
        {
            txtNomEdit.Enabled = false;
            txtDirec.Enabled = false;
            txtCiudad.Enabled = false;
            txtTel.Enabled = false;
            btnIngreEdit.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtNomEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }


    }
}
