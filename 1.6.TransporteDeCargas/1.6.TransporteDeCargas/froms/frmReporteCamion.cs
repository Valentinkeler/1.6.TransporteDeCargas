using _1._6.TransporteDeCargas.datos;
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
    public partial class frmReporteCamion : Form
    {
        public frmReporteCamion()
        {
            InitializeComponent();
        }

        private void frmReporteCamion_Load(object sender, EventArgs e)
        {
            accesoDatos odatos = new accesoDatos();
            DataTable tabla = odatos.reader("SP_Reporte_camion");

            rvCamion.LocalReport.DataSources.Clear();
            rvCamion.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",tabla));
            rvCamion.RefreshReport();
        }
    }
}
