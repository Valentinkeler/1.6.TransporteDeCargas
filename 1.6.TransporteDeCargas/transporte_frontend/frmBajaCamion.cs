using transporte_frontend.datos;
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
    public partial class frmBajaCamion : Form
    {
        accesoDatos oDatos = new accesoDatos();
        camion oCamion  = new camion();
        public frmBajaCamion()
        {
            InitializeComponent();
        }

        private void frmBajaCamion_Load(object sender, EventArgs e)
        {
            cargarGrilla("pa_mostrarCamion");
        }

        private void cargarGrilla(string SP)
        {
            DataTable tabla=oDatos.reader(SP);
            dgvCamiones.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvCamiones.Rows.Add(new object[] { tabla.Rows[i][0], tabla.Rows[i][1], tabla.Rows[i][2],tabla.Rows[i][3] });
            }        
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCamiones.CurrentCell.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvCamiones.CurrentRow;
                oDatos.bajaLogica("bajaCamion",Convert.ToInt32(row.Cells[0].Value));

                cargarGrilla("pa_mostrarCamion");
            }
        }
    }
}
