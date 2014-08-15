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
        public string sidMateria;
        public string valor;
        public int bandera = 0;
        string idCo;
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


            DateTime fechahoy1 = DateTime.Now;
            int gienviar;
            string a = "";
            csConexion.ObtenerConexion();
            //MessageBox.Show("Conectado");

           //******************************SI FUNCIONA

            if (valor == "Educativo")
            {
                sidMateria = ((System.Data.DataRowView)cboMat.SelectedItem).Row.ItemArray[0].ToString();
                MessageBox.Show(sidMateria + " MATERIA");
            }
            else
            {
                sidMateria = "";
                MessageBox.Show(sidMateria + " NO MATERIA");
            }
           
            string sidubicacion = ((System.Data.DataRowView)cboEstante.SelectedItem).Row.ItemArray[0].ToString();
            string siddautor = ((System.Data.DataRowView)cboAutor.SelectedItem).Row.ItemArray[0].ToString();
            string sidCorriente = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[0].ToString();
            string sidEditorial = ((System.Data.DataRowView)cboEdit.SelectedItem).Row.ItemArray[0].ToString(); 
            DataSet ds = new DataSet();

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_libro values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", a, txtNomLib.Text, txtLib.Text, nudpag.Value, nudVol.Value, fechahoy1, nudEdi.Value, "1", nudEjem.Value, sidubicacion, siddautor, sidEditorial, sidCorriente, sidMateria), csConexion.ObtenerConexion());
            //MySqlCommand comando = new MySqlCommand(string.Format("Insert into carol values ('{0}','{1}','{2}','{3}','{4}','{5}')", siddautor, sidMateria, sidCorriente,  sidubicacion, fechahoy1, "1" ), csConexion.ObtenerConexion());
//*************************************************************************************************************************


           gienviar = comando.ExecuteNonQuery();

           
            //MessageBox.Show(sidMateria + "MAteria");
            MessageBox.Show(sidubicacion + "ubicacion");
            MessageBox.Show(siddautor+ "autor");
            MessageBox.Show(sidCorriente + "corriente");
            MessageBox.Show(sidEditorial + "Editorial");
           // MessageBox.Show(nudVol.Value + "Volumen");
            
           
           

            
 
           

            
        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void llenar_autores_combo()
        {
          
            try
            {

                string query = "SELECT  id_autor, (CONCAT(nombre_autor, '   ', apellido_autor)) AS autor FROM tab_autor";


                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                //cboAutor.ValueMember = "";
                cboAutor.DisplayMember = "autor";
                cboAutor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Autor");
        
            }
        }




        public void llenar_corriente_literaria()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
                string query = "select idliteraria_corriente,cliteraria_corriente from tab_corriente";
                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd); 
                DataTable dt = new DataTable();
                da1.Fill(dt);
                cboCorriente.ValueMember = "idliteraria_corriente";
                cboCorriente.DisplayMember = "cliteraria_corriente";
                cboCorriente.DataSource = dt;

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
                MySqlDataAdapter da = new MySqlDataAdapter("select  idmateria_materia, nombre_materia from tab_materia where idmateria_materia >=1", conexion1);

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
                string query = "SELECT  id_ubicacion, (CONCAT(noestante_ubicacion, ' - ', noentrepa_ubicacion)) AS ubicacion FROM tab_ubicacion";


                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                //cboAutor.ValueMember = "";
                cboEstante.DisplayMember = "ubicacion";
                cboEstante.DataSource = dt;
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
                string query = "Select id_edit, nombre_edit from tab_editorial";
                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                cboEdit.ValueMember = "id_edit";
                cboEdit.DisplayMember = "nombre_edit";
                cboEdit.DataSource = dt;
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
            
            valor = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[1].ToString();

            if (valor == "Educativo")
            {
                lblMat.Visible = true;
                cboMat.Visible = true;
                llenar_materia_combo();
                
                //valor = "";

                //valor = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[0].ToString();

            }



            else
            {
                
               
                    sidMateria = "";
                    sidMateria = null;
                    lblMat.Visible = false;
                    cboMat.Visible = false;
                    bandera = 1;
                    
                






            }

            
            sidMateria = "";


        }

        private void cboMat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }








       









     
    }
}
