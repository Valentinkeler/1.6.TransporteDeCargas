using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.TransporteDeCargas
{
    internal class carga
    {
        public int PesoCarga { get; set; }
        public tipoCarga TipoCarga { get; set; }
        public carga(int pesoCarga, tipoCarga tipoCarga)
        {
            PesoCarga = pesoCarga;
            TipoCarga = tipoCarga;
        }
        public carga()
        {
            PesoCarga = 0;
            TipoCarga = null;
        }
    }
}
