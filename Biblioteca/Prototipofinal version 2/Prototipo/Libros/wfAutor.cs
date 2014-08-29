/*Autor: "Carol Flores"
 *Fecha: "08/Agosto/2014"
 *Comentario: "Este modulo realizara el ingreso de los datos un autor del libro"
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
   

   
    public partial class wfAutor : Form
    {



        // ****************************LIMPIAR TEXBOX DEL FORMULARIO*****************************

        // Declaramos nuestro metodo que hara la limpieza de los textbox
        public  void LimpiarTextBox(Form ofrm)
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





        int gienviar;
        
        public wfAutor()
        {

            InitializeComponent();
        }

        private void wfAutor_Load(object sender, EventArgs e)
        {
       

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int iBandera= 0;
            string a;




           if (string.IsNullOrWhiteSpace(txtNomAutor.Text) || string.IsNullOrWhiteSpace(txtApeAutor.Text))

               MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           else
           {
               
               //Manda a llamar a la clase conexion
               csConexion.ObtenerConexion();
               //MessageBox.Show("Conectado");
               a = "";
               iBandera = 1;


               //Realiza la Insercion en la Tabla AUTOR
               MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_autor values ('{0}','{1}','{2}')", a, txtNomAutor.Text, txtApeAutor.Text), csConexion.ObtenerConexion());

               gienviar = comando.ExecuteNonQuery();



           }

           if (iBandera == 1)
           {
               MessageBox.Show("Autor Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               LimpiarTextBox(this);
               Desabilitar();
           }
           else
           {
               MessageBox.Show("No se pudo guardar el autor", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }




            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {



            LimpiarTextBox(this);
            txtNomAutor.Focus();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public void Habilitar()
        {
            txtNomAutor.Enabled = true;
            txtApeAutor.Enabled = true;
            btnIngreAutor.Enabled = true;
            btnLimpiar.Enabled = true;
        }
        public void Desabilitar()
        {
            txtNomAutor.Enabled = false;
            txtApeAutor.Enabled = false;
            btnIngreAutor.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtNomAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApeAutor_KeyPress(object sender, KeyPressEventArgs e)
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
