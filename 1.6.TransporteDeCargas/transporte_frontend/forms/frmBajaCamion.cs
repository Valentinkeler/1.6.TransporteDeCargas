
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

namespace transporte_frontend.froms
{
    public partial class frmBajaCamion : Form
    {
        
        camion oCamion  = new camion();
        public frmBajaCamion()
        {
            InitializeComponent();
        }

        private void frmBajaCamion_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private async void cargarGrilla()
        {
            string url = "http://localhost:5031/camion";

            var result = await clientSingelton.getInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<camion>>(result);

            dgvCamiones.Rows.Clear();
            dgvCamiones.DataSource= lst;     
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void dgvCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCamiones.CurrentCell.ColumnIndex == 4)
            {
                //DataGridViewRow row = dgvCamiones.CurrentRow;
                //oDatos.bajaLogica("bajaCamion", Convert.ToInt32(row.Cells[0].Value));
                string url = "http://localhost:5031/id";

                var result = await clientSingelton.getInstance().deleteAsync(url);
                
                cargarGrilla();
            }
        }
    }
}
