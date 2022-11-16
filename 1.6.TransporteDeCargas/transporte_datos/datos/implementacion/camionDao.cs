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
        SqlConnection cnn = new SqlConnection();



        public List<camion> reader()
        {
            List<camion> lst = new List<camion>();

            DataTable tabla= helperDao.obtenerInstancia().reader("pa_mostrarCamion");

            foreach (DataRow item in tabla.Rows)
            {
                int idCamion = Convert.ToInt32(item["idCamion"]);
                string patente= item["patente"].ToString();
                int pesoMax= Convert.ToInt32(item["pesoMaximo"]);
                bool  estado  =  Convert.ToBoolean(item["estado"]);
                camion oCamion = new camion(patente,estado,pesoMax);
                lst.Add(oCamion);
            }
            return lst;
        }

        public bool maestroDetalle(camion oCamion)
        {
            return  helperDao.obtenerInstancia().maestroDetalle(oCamion,"pa_insertarCamion", "pa_insertarCarga");
            
        }
        public void bajaLogica(int idCamion)
        {
           helperDao.obtenerInstancia().BajaLogica("bajaCamion", idCamion);
        }
     
    }
}
