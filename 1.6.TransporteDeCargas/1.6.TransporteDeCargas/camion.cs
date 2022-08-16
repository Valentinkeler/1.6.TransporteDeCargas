using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.TransporteDeCargas
{
    internal class camion
    {
        public int Patente { get; set; }
        public bool Estado { get; set; }
        public int PesoMaximo { get; set; }
        public List<carga> Carga { get; set; }
        public camion(int patente,bool estado,int pesoMaximo)
        {
            Patente = patente;
            Estado = false;
            PesoMaximo = pesoMaximo;
            Carga = new List<carga>();
        }
        public camion()
        {
            Patente = 0;
            Estado = false;
            PesoMaximo =    0;
            Carga = new List<carga>();
        }
        public  string cargarCamion(carga CargaM)
        {
            int total = 0;
            foreach (carga item in Carga)
            {
                if (PesoMaximo > total)
                {
                    Carga.Add(item);
                    total += item.pesoCarga;
                }
            }
            Estado = true;
            return "este camion carga " + total + "kg";
        }
        public  void descargarCamion(int indice)
        {
            Carga.RemoveAt(indice);
            Estado = false;
        }
    }
}
