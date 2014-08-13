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
    public partial class wfIngresoLibro : Form
    {
       // int giEnviar;


        public wfIngresoLibro()
        {
            InitializeComponent();
        }

        private void wfIngresoLibro_Load(object sender, EventArgs e)
        {
            cboMat.Visible = false;
            lblMat.Visible = false;
            llenar_autores_combo();
            llenar_corriente_literaria();
            llenar_Estante_combo();
            llenar_entre_combo();
            llenar_editorial_combo();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            int gienviar;
            csConexion.ObtenerConexion();
            //MessageBox.Show("Conectado");

           //******************************SI FUNCIONA
            string sidMateria = ((System.Data.DataRowView)cboMat.SelectedItem).Row.ItemArray[0].ToString();
            string sidubicacion = ((System.Data.DataRowView)cboEstante.SelectedItem).Row.ItemArray[0].ToString(); 
            DataSet ds = new DataSet();

            //MySqlCommand comando = new MySqlCommand(string.Format("Insert into carol values ('{0}')", sidMateria), csConexion.ObtenerConexion());

//*************************************************************************************************************************



            MySqlConnection conexion1 = new MySqlConnection();
            conexion1 = csConexion.ObtenerConexion();

            DataTable dtDatos = new DataTable();

            //indicamos la consulta en SQL
            MySqlDataAdapter da = new MySqlDataAdapter("select id_autor from tab_autor where nombre_autor ='"+cboAutor.Text+"' and apellido_autor ='"+cboApellido+"'", conexion1);
            string quer = "select id_autor from tab_autor where nombre_autor ='" + cboAutor.Text + "' and apellido_autor ='" + cboApellido + "'";

            MySqlCommand comando = new MySqlCommand(quer, csConexion.ObtenerConexion());
            MySqlDataReader leer = comando.ExecuteReader();
            // Con la información del adaptador se rellena el DataTable
            da.Fill(dtDatos);
            leer.Read();
            
            //string id = leer["id_autor"].ToString();

            //int id2 = Convert.ToInt32(id);

            //int id2 = leer.GetInt32(leer.GetOrdinal("id_autor")); 

            MessageBox.Show(leer["id_autor"].ToString());

            MySqlCommand comando1 = new MySqlCommand(string.Format("Insert into carol values ('{0}')", leer["id_autor"].ToString()), csConexion.ObtenerConexion());

            gienviar = comando1.ExecuteNonQuery();

            //MessageBox.Show(sidMateria);
            //MessageBox.Show(sidubicacion);
           

            
 
           

            
        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void llenar_autores_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion(); 

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select nombre_autor, apellido_autor from tab_autor", conexion1);


                //se indica el nombre de la tabla
                da.Fill(ds, "nombre_autor:");
                da.Fill(ds, "apellido_autor");
                cboAutor.DataSource = ds.Tables[0].DefaultView;
                cboApellido.DataSource = ds.Tables[1].DefaultView;
               

                //se especifica el campo de la tabla
                cboAutor.ValueMember = "nombre_autor";
                cboApellido.ValueMember = "apellido_autor";
                

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }




        public void llenar_corriente_literaria()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexioncorri = new MySqlConnection();
                conexioncorri = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select cliteraria_corriente from tab_corriente", conexioncorri);

                //se indica el nombre de la tabla
                da.Fill(ds, "Corriente_Literaria:");
                cboCorriente.DataSource = ds.Tables[0].DefaultView;


                //se especifica el campo de la tabla
                cboCorriente.ValueMember = "cliteraria_corriente";

                conexioncorri.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }



        public void llenar_materia_combo()
        {
            //se declara una variable de tipo SqlConnection
           

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select idmateria_materia, nombre_materia from tab_materia", conexion1);

                //se indica el nombre de la tabla
               
                da.Fill(ds, "nombre_materia:");
                
                
                cboMat.DataSource = ds.Tables[0].DefaultView;
               // cboMat.DataSource = ds.Tables[1].DefaultView;


                //se especifica el campo de la tabla

                cboMat.ValueMember = "idmateria_materia";
                cboMat.DisplayMember ="nombre_materia";
                

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
       


        public void llenar_Estante_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select id_ubicacion, noestante_ubicacion from tab_ubicacion", conexion1);

                //se indica el nombre de la tabla
               
                da.Fill(ds, "Estante:");

                cboEstante.DataSource = ds.Tables[0].DefaultView;


                //se especifica el campo de la tabla
                cboEstante.ValueMember = "id_ubicacion";
                cboEstante.DisplayMember = "noestante_ubicacion";

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }




        public void llenar_entre_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select noentrepa_ubicacion from tab_ubicacion", conexion1);

                //se indica el nombre de la tabla
                da.Fill(ds, "noentrepa_ubicacion");
                cboEntre.DataSource = ds.Tables[0].DefaultView;


                //se especifica el campo de la tabla
                cboEntre.ValueMember = "noentrepa_ubicacion";

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }



        public void llenar_editorial_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                MySqlConnection conexion1 = new MySqlConnection();
                conexion1 = csConexion.ObtenerConexion();

                DataSet ds = new DataSet();

                //indicamos la consulta en SQL
                MySqlDataAdapter da = new MySqlDataAdapter("Select nombre_edit from tab_editorial", conexion1);

                //se indica el nombre de la tabla
                da.Fill(ds, "nombre_editorial:");
                cboEdit.DataSource = ds.Tables[0].DefaultView;


                //se especifica el campo de la tabla
                cboEdit.ValueMember = "nombre_edit";

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           // LimpiarTextBox(tabPage);
            txtNomLib.Clear();
            txtLib.Clear();
            txtNoPag.Clear();
            txtNomLib.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cboCorriente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[0].ToString();
            if (valor == "Educativo")
            {
                lblMat.Visible = true;
                cboMat.Visible = true;
                llenar_materia_combo();
            }
            else
            {
                lblMat.Visible = false;
                cboMat.Visible = false;
            }


        }

        private void cboMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }




     
    }
}
