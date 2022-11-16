using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.datos
{
    abstract class AbstractDaoFactory
    {
        abstract public IcamionDao  crearAccesoDatos();
    }
}
