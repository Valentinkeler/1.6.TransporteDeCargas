using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.facade
{
    internal class DataApiFactory : abstractDataApiFactory
    {
        public override dataApi crearDataApi()
        {
            return new dataApi();
        }
    }
}
