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
               txtNomAutor.Focus();
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
    }
}
