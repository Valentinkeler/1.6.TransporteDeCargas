using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transporte_frontend.froms
{
    public partial class Principal : Form
    {
        public Principal()
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
