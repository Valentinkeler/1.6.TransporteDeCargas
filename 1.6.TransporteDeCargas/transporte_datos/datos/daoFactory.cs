using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.datos
{
    abstract class daoFactory:AbstractDaoFactory
    {
        public  override    IcamionDao crearAccesoDatos()
        {
            return  new camionDao();
        }
    }
}
