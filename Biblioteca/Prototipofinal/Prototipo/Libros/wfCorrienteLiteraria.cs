/*Autor: "Carol Flores"
 *Fecha: "08/Agosto/2014"
 *Comentario: "Este modulo realizara el ingreso de la corriente literaria"
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
    public partial class wfCorrienteLiteraria : Form
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
        public wfCorrienteLiteraria()
        {
            InitializeComponent();
        }


        private void btnIgresarCorriente_Click(object sender, EventArgs e)
        {
            string a;

            int iBandera=0;


            if (string.IsNullOrWhiteSpace(txtNomCorriente.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            else
            {
               
                csConexion.ObtenerConexion();
                
                a = "";

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_corriente values ('{0}','{1}')", a, txtNomCorriente.Text), csConexion.ObtenerConexion());

                giEnviar = comando.ExecuteNonQuery();
                iBandera = 1;
            }

            if (iBandera == 1)
            {
                MessageBox.Show("Corriente Literaria Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox(this);
                Desabilitar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar la corriente literaria", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(this);
            txtNomCorriente.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wfCorrienteLiteraria_Load(object sender, EventArgs e)
        {

        }


        public void Habilitar()
        {
            txtNomCorriente.Enabled = true;
            btnIgreCorriente.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void Desabilitar()
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar();
           
        }

        private void txtNomCorriente_KeyPress(object sender, KeyPressEventArgs e)
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
