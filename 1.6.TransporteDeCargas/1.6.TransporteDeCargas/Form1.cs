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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            DataTable  tabla = new DataTable();
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
    }
}
