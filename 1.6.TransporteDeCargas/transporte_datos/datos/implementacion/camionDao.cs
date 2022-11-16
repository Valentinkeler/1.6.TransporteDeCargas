using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.datos
{
    public class camionDao : IcamionDao
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True");



        public DataTable reader(string SP)
        {
            return  helperDao.obtenerInstancia().reader(SP);
        }

        public bool maestroDetalle(camion oCamion)
        {
            return  helperDao.obtenerInstancia().maestroDetalle(oCamion);
            
        }
        public void bajaLogica(string SP, int idCamion)
        {
           helperDao.obtenerInstancia().BajaLogica(SP, idCamion);
        }
     
    }
}
