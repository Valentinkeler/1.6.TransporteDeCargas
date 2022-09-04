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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoCamion  nuevoCamion=new frmNuevoCamion();
            nuevoCamion.ShowDialog();
        }

        private void eliminarCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBajaCamion BajaCamion=new frmBajaCamion();
            BajaCamion.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteTipoCarga reporTipoCarga=new frmReporteTipoCarga();
            reporTipoCarga.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteCamion reportCamion=new frmReporteCamion();
            reportCamion.ShowDialog();
        }
    }
}
