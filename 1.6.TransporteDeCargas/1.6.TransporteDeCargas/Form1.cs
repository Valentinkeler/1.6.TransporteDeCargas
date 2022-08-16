using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1._6.TransporteDeCargas
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=1.6.TransporteDeCarga;Integrated Security=True");
        camion Camion = new camion();
        DataTable tabla = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarLista();

        }

        private void cargarLista()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("consultarCamion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            lstCamiones.DataSource = tabla;
            lstCamiones.DisplayMember = "estado";
            lstCamiones.ValueMember = "patente";
        }

        private void cargarCombo()
        {
            
            conexion.Open();
            SqlCommand comando = new SqlCommand("consultarTipoCarga", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            cboTipoCarga.DataSource = tabla;
            cboTipoCarga.DisplayMember = "tipoCarga";
            cboTipoCarga.ValueMember = "codigoTipoCarga";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
