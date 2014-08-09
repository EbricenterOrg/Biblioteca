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
    public partial class wfentrega_libro : Form
    {
        public wfentrega_libro()
        {
            InitializeComponent();
        }

        private void wfentrega_libro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtDatos = new DataTable();
            int numero;
            numero =  Convert.ToInt32(txtno.Text);
 
 // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("Select * from tabt_detalquiler where iddetalle_detalquiler like('"+txtno.Text+"')", conexion.ObtenerConexion());
 string quer = "Select * from tabt_detalquiler where iddetalle_detalquiler='"+txtno.Text+"' ";
 MySqlCommand comando = new MySqlCommand(quer, conexion.ObtenerConexion());
 MySqlDataReader leer = comando.ExecuteReader();
 // Con la información del adaptador se rellena el DataTable
 mdaDatos.Fill(dtDatos);
 leer.Read();
 txtnombre.Text = leer["descrip_detalquiler"].ToString();
 
 // Se asigna el DataTable como origen de datos del DataGridView
 gridalqui.DataSource = dtDatos;
        }
    }
}
