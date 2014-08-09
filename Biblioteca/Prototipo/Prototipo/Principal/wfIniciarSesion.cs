using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Prototipo
{
    public partial class wfIniciarSesion : Form
    {
        //string sUsuario;
        //MySqlConnection CN = new MySqlConnection("server=localhost;port=3306;uid=rodrigo;password=juarez;database=biblioteca;");
        MySqlConnection CN = new MySqlConnection("server=localhost;port=3306;uid=root;password='';database=dbiblioteca;");
        MySqlCommand cm = new MySqlCommand();

        public wfIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
               CN.Open();
              cm.Connection = CN;

            try {
                //cm.CommandText = "select count(*) from usuario where nombre = '" + txtUsuario.Text + "' and contra = '" + txtContrasena.Text + "'";
                cm.CommandText = "select count(*) from tab_usuario where usuario = '" + txtUsuario.Text + "' and contras = '" + txtContrasena.Text + "'";
                int valor = int.Parse(cm.ExecuteScalar().ToString());
                //compara si el valor recibido es q existe si no No
                    if (valor == 1)
                    {
                        wfIniciarSesion formu2 = new wfIniciarSesion();
                        formu2.Close();
                        MessageBox.Show("Bienvenido");
                        wfMenuAdministrador form = new wfMenuAdministrador();
                        form.Show();
                                                   
                    }
                    else
                    {
                    MessageBox.Show("No Existe");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                 CN.Close();
                
            }
        

        private void btnconexion_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            MessageBox.Show("conectado");
        }

        private void wfIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}

        

        

