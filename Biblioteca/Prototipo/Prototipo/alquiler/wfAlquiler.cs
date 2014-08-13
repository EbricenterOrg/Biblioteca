using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipo.alquiler
{
    
    public partial class wfAlquiler : Form
    {

        int test;
        public wfAlquiler()
        {
            InitializeComponent();

        }
        

        private void wfAlquiler_Load(object sender, EventArgs e)
        {
            //dropdown list de selección de corriente
            string querycorriente = "select idliteraria_corriente,cliteraria_corriente from tab_corriente";
            MySqlCommand cmdcorriente = new MySqlCommand(querycorriente, csConexion.ObtenerConexion());
            MySqlDataAdapter dacorriente = new MySqlDataAdapter(cmdcorriente);
            DataTable dtcorriente = new DataTable();
            dacorriente.Fill(dtcorriente);
            comboBox1.ValueMember = "idliteraria_corriente";
            comboBox1.DisplayMember = "cliteraria_corriente";
            comboBox1.DataSource = dtcorriente;

            //dropdown list de cliente
            string querycliente = "select idpersona,nombre,apellido from tab_persona";
            MySqlCommand cmdcliente = new MySqlCommand(querycliente, csConexion.ObtenerConexion());
            MySqlDataAdapter dacliente = new MySqlDataAdapter(cmdcliente);
            DataTable dtcliente = new DataTable();
            dacliente.Fill(dtcliente);
            cboSelecCliente.ValueMember = "idpersona";
            cboSelecCliente.DisplayMember = "idpersona";
            //lblnombrecliente.Text = "nombre" + " " + "apellido";
            lblnombrecliente.Visible = true;
            cboSelecCliente.DataSource = dtcliente;


            /*dropdown list de cliente
            string querylibro = "select id_lib,nombre_lib from tab_libro where tab_corriente_idliteraria_corriente = 'valor'";
            MySqlCommand cmdlibro = new MySqlCommand(querylibro, conexion.ObtenerConexion());
            MySqlDataAdapter dalibro = new MySqlDataAdapter(cmdlibro);
            DataTable dtlibro = new DataTable();
            dalibro.Fill(dtlibro);
            comboBox1.ValueMember = "idliteraria_corriente";
            comboBox1.DisplayMember = "cliteraria_corriente";
            comboBox1.DataSource = dtlibro;
            */
            
        }

        private void cboSelecCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
                
                
            
            
        }

        private void btnagregarlibro_Click(object sender, EventArgs e)
        {
            //test=reader
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string valor = ((System.Data.DataRowView)comboBox1.SelectedItem).Row.ItemArray[0].ToString();
        }

        

        
    }
}
