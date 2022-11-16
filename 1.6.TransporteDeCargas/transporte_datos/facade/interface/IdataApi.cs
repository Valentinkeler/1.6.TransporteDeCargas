using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.facade
{
    public interface IdataApi
    {
        public DataTable reader(string SP);
        public bool maestroDetalle(camion ocamion);
        public void bajaLogica(string SP, int id_camion);
    }
}
