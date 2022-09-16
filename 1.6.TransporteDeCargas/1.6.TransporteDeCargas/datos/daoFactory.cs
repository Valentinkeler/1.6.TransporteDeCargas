using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.TransporteDeCargas.datos
{
    internal class daoFactory
    {
        public  override    IcamionDao crearAccesoDatos()
        {
            return  new camionDao();
        }
    }
}
