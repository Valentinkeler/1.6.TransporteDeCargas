﻿using System;
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
    public partial class frmNuevoCamion : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True");
        camion oCamion = new camion();
        
        public frmNuevoCamion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            limpiar();
        }

        private void cargarCombo()
        {
            DataTable  tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand("pa_consultarTipoCarga", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            cboTipoCarga.DataSource = tabla;
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
            
            guardarCamion();
            limpiar();
        }

        private void guardarCamion()
        {
            oCamion.Patente = txtPatente.Text;
            oCamion.PesoMaximo = Convert.ToInt32(txtPesoMax.Text);
           

            if (oCamion.confirmar())
            {
                MessageBox.Show("el camion  se  cargo   correctamente",
                    "informe"
                    , MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Dispose();
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
            if (cboTipoCarga.SelectedIndex==0)
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

            tipoCarga.TipoCarga =Convert.ToInt32(cboTipoCarga.SelectedValue);
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
            dgvCargas.ClearSelection();
        }
    }
}