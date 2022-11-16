using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transporte_datos;
using transporte_frontend.Http;

namespace transporte_frontend
{
    public partial class frmNuevoCamion : Form
    {
        camion oCamion;

        public frmNuevoCamion()
        {
            InitializeComponent();
            oCamion = new camion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarComboAsync();
            limpiar();
        }

        public async void cargarComboAsync()
        {
            string url = "http://localhost:5031/camion";
            var result = await  clientSingelton.getInstance().GetAsync(url);
            var lst =   JsonConvert.DeserializeObject<List<camion>>(result);

            cboTipoCarga.DataSource = lst;
            cboTipoCarga.DisplayMember = "tipoCarga";
            cboTipoCarga.ValueMember = "codigoTipoCarga";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text == "")
            {
                MessageBox.Show("escribir patente",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            if (txtPesoMax.Text == "" || !int.TryParse(txtPesoMax.Text, out _))
            {
                MessageBox.Show("escribir un peso maximo",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
            guardarCamionAsync();
            limpiar();
        }

        private async void guardarCamionAsync()
        {     
            oCamion.Patente = txtPatente.Text;
            oCamion.PesoMaximo = Convert.ToInt32(txtPesoMax.Text);
            var bodyContent = JsonConvert.SerializeObject(oCamion);

            string url = "http://localhost:5031/transporte";

            var result = await clientSingelton.getInstance().postAsync(url,bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("el camion  se  cargo   correctamente",
                    "informe"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error  al  cargar  camion  en  la  BD",
                    "error"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void tx_Click(object sender, EventArgs e)
        {
            if (cboTipoCarga.SelectedIndex==-1)
            {
                MessageBox.Show("seleccionar un tipo de carga",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            if (txtPesoCarga.Text == "" ||  !int.TryParse(txtPesoCarga.Text,out _))
            {
                MessageBox.Show("seleccionar un tipo de carga",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            if (txtPesoMax.Text == "" || !int.TryParse(txtPesoMax.Text, out _))
            {
                MessageBox.Show("escribir un peso maximo",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

            DataRowView grilla = (DataRowView)cboTipoCarga.SelectedItem;

            tipoCarga tipoCarga = new tipoCarga();

            tipoCarga.TipoCarga =Convert.ToInt32(grilla.Row[0]);
            int pesoCarga = Convert.ToInt32(txtPesoCarga.Text);

            carga Carga = new carga(pesoCarga, tipoCarga);

            if (oCamion.calcularPeso() < Convert.ToInt32(txtPesoMax.Text))
            {
                oCamion.cargarCamion(Carga);
                dgvCargas.Rows.Add(new object[] { grilla.Row.ItemArray[0],grilla.Row.ItemArray[1], Carga.PesoCarga });

                txtPesoTotal.Text = Convert.ToString(oCamion.calcularPeso());
            }
            else
            {
                MessageBox.Show("se pasa de peso",
                    "control"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            

        }

        private void dgvCargas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargas.CurrentCell.ColumnIndex==3)
            {
                oCamion.descargarCamion(dgvCargas.CurrentRow.Index);

                dgvCargas.Rows.Remove(dgvCargas.CurrentRow);

                txtPesoTotal.Text =Convert.ToString(oCamion.calcularPeso()); 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {        
            txtPatente.Text=String.Empty;
            txtPesoCarga.Text = String.Empty;
            txtPesoMax.Text = String.Empty;
            txtPesoTotal.Text = String.Empty;
            cboTipoCarga.SelectedIndex = 0;
            dgvCargas.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
