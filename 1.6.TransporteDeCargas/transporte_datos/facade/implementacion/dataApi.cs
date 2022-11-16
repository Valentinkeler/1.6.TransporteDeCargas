using transporte_datos.datos;
using System.Data;

namespace transporte_datos.facade
{
    internal class dataApi
    {
        private IcamionDao datos;

        public  dataApi(AbstractDaoFactory factory)
        {
            datos   =   factory.crearAccesoDatos();
        }

        public dataApi()
        {
        }

        public DataTable    reader(string    SP)
        {
            return datos.reader(SP);
        }
        public  bool maestroDetalle(camion  ocamion)
        {
            return datos.maestroDetalle(ocamion);
        }
        public  void bajaLogica(string  SP,int id_camion)
        {
            datos.bajaLogica(SP,id_camion);
        }
    }
}
