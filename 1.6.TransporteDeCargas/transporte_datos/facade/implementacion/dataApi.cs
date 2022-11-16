using transporte_datos.datos;
using System.Data;

namespace transporte_datos.facade
{
    public class dataApi:IdataApi
    {
        private IcamionDao datos;

        public  dataApi()
        {
            datos = new camionDao();
        }

        public List<camion> GetCamion()
        {
            return datos.reader();
        }
        public  bool PostCamion(camion  ocamion)
        {
            return datos.maestroDetalle(ocamion);
        }
        public  void DeleteLogico(int id_camion)
        {
            datos.bajaLogica(id_camion);
        }


    }
}
