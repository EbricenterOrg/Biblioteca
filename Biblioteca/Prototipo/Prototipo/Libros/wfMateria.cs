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
    public partial class wfMateria : Form
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
        public wfMateria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            int iBandera = 0;


            if (string.IsNullOrWhiteSpace(txtMat.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                conexion.ObtenerConexion();
                //MessageBox.Show("Conectado");
                a = "";

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_materia values ('{0}','{1}')", a, txtMat.Text), conexion.ObtenerConexion());

                giEnviar = comando.ExecuteNonQuery();
                iBandera = 1;
            }

            if (iBandera == 1)
            {
                MessageBox.Show("Autor Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox(this);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el autor", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(this);
            txtMat.Focus();
        }
    }
}
