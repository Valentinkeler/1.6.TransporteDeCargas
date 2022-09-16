using _1._6.TransporteDeCargas.datos;
using _1._6.TransporteDeCargas.reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.TransporteDeCargas.sevicios
{
    internal class servicio
    {
        private IcamionDao datos;

        public  servicio(AbstractDaoFactory factory)
        {
            datos   =   factory.crearAccesoDatos();
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
