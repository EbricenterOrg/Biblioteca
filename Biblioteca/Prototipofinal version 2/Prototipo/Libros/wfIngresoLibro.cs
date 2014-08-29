/*Autor: "Carol Flores"
 *Fecha: "16/Agosto/2014"
 *Comentario: "Este modulo realizara el ingreso de un libro nuevo  y existente"
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
using System.Collections;


namespace Prototipo
{


    public partial class wfIngresoLibro : Form
    {

       
       
        public string sidMateria;
        public string valor;
        public string sidCorrienteE;
        public string sidMateriaE;
        public string sidENomLibro;
        public string sidETitulo;
        public string idmateria;
        public string sidVolE;
        public int bandera = 0;
       
        public int entro = 0;
        public wfIngresoLibro()
        {
            InitializeComponent();
        }

        private void wfIngresoLibro_Load(object sender, EventArgs e)
        {
            
            cboMat.Visible = false;
            lblMat.Visible = false;
            cboEMat.Visible = false;
            lblEMat.Visible = false;
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

            if (tcIngresoLibro.SelectedTab.Name == "tpNuevo")
            {
                
                int iBandera = 0;

                if (string.IsNullOrWhiteSpace(txtNomLib.Text) || string.IsNullOrWhiteSpace(txtLib.Text) || string.IsNullOrWhiteSpace(nudpag.Text) || string.IsNullOrWhiteSpace(nudVol.Text) || string.IsNullOrWhiteSpace(nudEdi.Text) || string.IsNullOrWhiteSpace(cboEdit.Text) || string.IsNullOrWhiteSpace(cboAutor.Text) || string.IsNullOrWhiteSpace(cboCorriente.Text) || string.IsNullOrWhiteSpace(cboEstante.Text) || string.IsNullOrWhiteSpace(nudEjem.Text))

                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    iBandera = 1;
                    DateTime fechahoy1 = DateTime.Now;
                    fechahoy1.ToString("yyyy/MM/dd");
                    int gienviar;
                    string a = "";
                    csConexion.ObtenerConexion();
                   

                    if (valor == "Educativo")
                    {
                        sidMateria = ((System.Data.DataRowView)cboMat.SelectedItem).Row.ItemArray[0].ToString();
                        
                     
                    }
                    else
                    {
                        sidMateria = "";
                        
                       
                    }

                    string sidubicacion = ((System.Data.DataRowView)cboEstante.SelectedItem).Row.ItemArray[0].ToString();
                    string siddautor = ((System.Data.DataRowView)cboAutor.SelectedItem).Row.ItemArray[0].ToString();
                    string sidCorriente = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[0].ToString();
                    string sidEditorial = ((System.Data.DataRowView)cboEdit.SelectedItem).Row.ItemArray[0].ToString();
                    DataSet ds = new DataSet();

                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into tab_libro values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", a, txtNomLib.Text, txtLib.Text, nudpag.Value, nudVol.Value, fechahoy1.ToString("yyyy/MM/dd HH:mm:ss"), nudEdi.Value, "1", nudEjem.Value, sidubicacion, siddautor, sidEditorial, sidCorriente, sidMateria), csConexion.ObtenerConexion());
                    


                    gienviar = comando.ExecuteNonQuery();

                   
                     
                }

                if (iBandera == 1)
                {
                    MessageBox.Show("Libro Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Desabilitar();

                }

            }


            
       
            if (tcIngresoLibro.SelectedTab.Name == "tpExistente")
            {
                
                
                Seleccionar_Texbox();
                btnActualizar.Enabled = true;
            }


            


            
           
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
                cboECate.ValueMember = "idliteraria_corriente";
                cboECate.DisplayMember = "cliteraria_corriente";

                cboCorriente.DataSource = dt;
                cboECate.DataSource = dt;

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
                cboEMat.DataSource = ds.Tables[0].DefaultView;
               // cboMat.DataSource = ds.Tables[1].DefaultView;


                //se especifica el campo de la tabla

                cboMat.ValueMember = "idmateria_materia";
                cboMat.DisplayMember ="nombre_materia";
                cboEMat.ValueMember = "idmateria_materia";
                cboEMat.DisplayMember = "nombre_materia";
               
              
                

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



        public void llenar_NombreLibro_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {
               
                sidVolE = ((System.Data.DataRowView)cboEVol.SelectedItem).Row.ItemArray[3].ToString();

                string query = "Select id_lib, nombre_lib, titulo_lib, volumen_lib from tab_libro where tab_corriente_idliteraria_corriente = ('" + sidCorrienteE + "')";

                

               
                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
               
                
                
                cboENomLib.DisplayMember = "nombre_lib";
                cboENomLib.ValueMember= "id_lib";
                cboENomLib.DataSource = dt;
                cboETitulo.DisplayMember = "titulo_lib";
                cboETitulo.DataSource = dt;
                cboEVol.DisplayMember = "volumen_lib";
                cboEVol.DataSource = dt;

               
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en  nombre libro, titulo libro");
            }
        }






        public void llenar_NombreLibroMateria_combo()
        {
            //se declara una variable de tipo SqlConnection

            try
            {

                
               

                sidMateriaE = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
               
                string query = "Select id_lib, nombre_lib, titulo_lib, volumen_lib from tab_libro where tab_materia_idmateria_materia = ('" + sidMateriaE + "')";




                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
               

                cboENomLib.DisplayMember = "nombre_lib";
                cboENomLib.ValueMember = "id_lib";
                cboENomLib.DataSource = dt;

                cboETitulo.DisplayMember = "titulo_lib";
                cboETitulo.DataSource = dt;

                cboEVol.DisplayMember = "volumen_lib";
                cboEVol.DataSource = dt;
               sidVolE = ((System.Data.DataRowView)cboEVol.SelectedItem).Row.ItemArray[3].ToString();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en  nombre libro, titulo libro");
            }
        }




       
























       
        public void Seleccionar_Texbox()
        {




            if (string.IsNullOrWhiteSpace(cboECate.Text) || string.IsNullOrWhiteSpace(cboENomLib.Text) || string.IsNullOrWhiteSpace(cboETitulo.Text) || string.IsNullOrWhiteSpace(cboEVol.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string sidCorriente = ((System.Data.DataRowView)cboCorriente.SelectedItem).Row.ItemArray[0].ToString();
                sidVolE = ((System.Data.DataRowView)cboEVol.SelectedItem).Row.ItemArray[3].ToString();
               

                DataTable dtDatos = new DataTable();
                
                // Se crea un MySqlAdapter para obtener los datos de la base
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT ejemplares_lib FROM tab_libro where nombre_lib like('" + cboENomLib.SelectedValue + "') and tab_corriente_idliteraria_corriente = ('" + sidCorrienteE + "') ", csConexion.ObtenerConexion());
                string quer = "SELECT ejemplares_lib FROM tab_libro where id_lib like('" + cboENomLib.SelectedValue + "') and tab_corriente_idliteraria_corriente = ('" + sidCorrienteE + "') and volumen_lib = ('" + sidVolE + "')";
                MySqlCommand comando = new MySqlCommand(quer, csConexion.ObtenerConexion());
                MySqlDataReader leer = comando.ExecuteReader();
              
               
                leer.Read();
                txtEEjem.Text = leer["ejemplares_lib"].ToString();

                

            }


            



        }

        


        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            if (tcIngresoLibro.SelectedTab.Name == "tpNuevo")
            {
                Limpiar(); 
            }

            if (tcIngresoLibro.SelectedTab.Name == "tpExistente")
            {
                txtEEjem.Clear();

            }


           
           
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (tcIngresoLibro.SelectedTab.Name == "tpNuevo")
            {
                Habilitar();
            }

            if (tcIngresoLibro.SelectedTab.Name == "tpExistente")
            {
                HabilitarExistente();
                
            }

        }



        
        public void Habilitar ()
        {
            txtNomLib.Enabled = true;
            txtLib.Enabled = true;
            nudpag.Enabled = true;
            nudVol.Enabled = true;
            nudEdi.Enabled = true;
            cboEdit.Enabled = true;
            cboAutor.Enabled = true;
            cboCorriente.Enabled = true;
            cboMat.Enabled = true;
            cboEstante.Enabled = true;
            nudEjem.Enabled = true;
            btnLimpiar.Enabled = true;
            btnIngreso.Enabled = true;

        }


        public void HabilitarExistente()
        {
            cboECate.Enabled = true;
            cboEMat.Enabled = true;
            cboENomLib.Enabled = true;
            cboETitulo.Enabled = true;
            cboEVol.Enabled = true;
            txtEEjem.Enabled = true;
            btnLimpiar.Enabled = true;
            btnIngreso.Enabled = true;

        }


        
        public void Desabilitar()
        {
            txtNomLib.Enabled = false;
            txtLib.Enabled = false;
            nudpag.Enabled = false;
            nudVol.Enabled = false;
            nudEdi.Enabled = false;
            cboEdit.Enabled = false;
            cboAutor.Enabled = false;
            cboCorriente.Enabled = false;
            cboMat.Enabled = false;
            cboEstante.Enabled = false;
            nudEjem.Enabled = false;
            btnLimpiar.Enabled = false;
            btnIngreso.Enabled = false;

        }
        
         
        public void Limpiar()
        {
            txtNomLib.Clear();
            txtLib.Clear();
            txtNomLib.Focus();
            
        }

        private void cboECate_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = ((System.Data.DataRowView)cboECate.SelectedItem).Row.ItemArray[1].ToString();
            
            if (valor == "Educativo")
            {
                lblEMat.Visible = true;
                cboEMat.Visible = true;
                llenar_materia_combo();

                
                sidCorrienteE = ((System.Data.DataRowView)cboECate.SelectedItem).Row.ItemArray[0].ToString();
                sidMateriaE = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
               
               
            }



            else
            {

               
                sidMateria = "";
                sidMateria = null;
                lblEMat.Visible = false;
                cboEMat.Visible = false;
                bandera = 1;

                sidCorrienteE = ((System.Data.DataRowView)cboECate.SelectedItem).Row.ItemArray[0].ToString();
              
                sidMateriaE = "0";




            }

            llenar_NombreLibro_combo();
            sidMateria = "";
          
        }

        private void tpExistente_Click(object sender, EventArgs e)
        {

        }

        private void cboETitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (entro == 0)
            {
                sidETitulo = ((System.Data.DataRowView)cboETitulo.SelectedItem).Row.ItemArray[2].ToString();
            }

            
        }

        private void cboENomLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entro == 0)
            {
                sidENomLibro = ((System.Data.DataRowView)cboENomLib.SelectedItem).Row.ItemArray[1].ToString();
            }
        }

        private void cboEMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valor == "Educativo")
            {
                llenar_NombreLibroMateria_combo();
                sidMateriaE = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
            }
            else
            {
                llenar_NombreLibro_combo();
                
            }
            if (entro == 1)
            {
                idmateria = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
                sidMateriaE = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
            }
            sidMateriaE = ((System.Data.DataRowView)cboEMat.SelectedItem).Row.ItemArray[0].ToString();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
           

            try
            {
                entro = 1;
                string query = "UPDATE tab_libro SET ejemplares_lib = ('" + txtEEjem.Text + "') WHERE tab_corriente_idliteraria_corriente = ('" + sidCorrienteE + "') and tab_materia_idmateria_materia = ('" + sidMateriaE + "') and nombre_lib = ('" + sidENomLibro + "') and titulo_lib = ('" + sidETitulo + "') and volumen_lib = ('" + sidVolE +"') ;";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlCommand cmd = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlCommand MyCommand2 = new MySqlCommand(query, csConexion.ObtenerConexion());
                MySqlDataReader MyReader2;
                
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                csConexion.ObtenerConexion().Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            sidMateriaE = "0";
            idmateria = "0";
            entro = 0;

            btnActualizar.Enabled = false;

        }

       

        private void cboEVol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entro == 0)
            {
               
                sidVolE = ((System.Data.DataRowView)cboEVol.SelectedItem).Row.ItemArray[3].ToString();
               
            }
        }

        private void txtNomLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se acepta el ingreso de letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudpag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudVol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudEdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudEjem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEEjem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       
       





     
    }
}
