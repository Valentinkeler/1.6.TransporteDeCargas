using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using transporte_datos.datos;

namespace transporte_datos
{
    public class camion
    {
        public string Patente { get; set; }
        public bool Estado { get; set; }
        public int PesoMaximo { get; set; }
        public List<carga> Carga { get; set; }
        public camion(string patente, bool estado, int pesoMaximo)
        {
            Patente = patente;
            Estado = true;
            PesoMaximo = pesoMaximo;
            Carga = new List<carga>();
        }
        public camion()
        {
            Patente = string.Empty;
            Estado = true;
            PesoMaximo = 0;
            Carga = new List<carga>();
        }
        public void cargarCamion(carga CargaM)
        {
            Carga.Add(CargaM);
        }
        public void descargarCamion(int indice)
        {
            Carga.RemoveAt(indice);

        }
        public int calcularPeso()
        {
            int total = 0;
            foreach (carga item in Carga)
            {
                total += item.PesoCarga;
            }
            return total;
        } 

    }
}
