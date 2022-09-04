using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._6.TransporteDeCargas.froms
{
    public partial class frmReporteTipoCarga : Form
    {
        public frmReporteTipoCarga()
        {
            InitializeComponent();
        }

        private void frmReporteTipoCarga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTipoCarga.tipoCarga' Puede moverla o quitarla según sea necesario.
            this.tipoCargaTableAdapter.Fill(this.dsTipoCarga.tipoCarga);

            this.reportViewer1.RefreshReport();
        }
    }
}
