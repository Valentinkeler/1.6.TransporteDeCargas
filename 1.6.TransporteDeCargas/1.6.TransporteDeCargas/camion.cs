using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _1._6.TransporteDeCargas
{
    internal class camion
    {
        public string Patente { get; set; }
        public bool Estado { get; set; }
        public int PesoMaximo { get; set; }
        public List<carga> Carga { get; set; }
        public camion(string patente, bool estado, int pesoMaximo)
        {
            Patente = patente;
            Estado = false;
            PesoMaximo = pesoMaximo;
            Carga = new List<carga>();
        }
        public camion()
        {
            Patente = string.Empty;
            Estado = false;
            PesoMaximo = 0;
            Carga = new List<carga>();
        }
        public string cargarCamion(carga CargaM)
        {
            int total = 0;
            foreach (carga item in Carga)
            {
                if (PesoMaximo > total)
                {
                    Carga.Add(item);
                    total += item.PesoCarga;
                }
            }
            Estado = true;
            return "este camion carga " + total + "kg";
        }
        public void descargarCamion(int indice)
        {
            Carga.RemoveAt(indice);
            Estado = false;
        }

        public bool confirmar()
        {
            SqlConnection conexion = new    SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand("pa_insertarCamion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@patente", Patente);
            comando.Parameters.AddWithValue("@pesoMaximo", PesoMaximo);
            comando.Parameters.AddWithValue("@estado", Estado);

            SqlParameter param = new SqlParameter("@idCamion", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            conexion.Close();

            int IdCamion = Convert.ToInt32(param.Value);

            foreach (carga item in Carga)
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("pa_insertarCarga", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@peso",item.PesoCarga);
                cmd.Parameters.AddWithValue("@codigoTipoCarga",item.TipoCarga.TipoCarga);
                cmd.Parameters.AddWithValue("@idCamion",IdCamion);

                cmd.ExecuteNonQuery(); 


                conexion.Close();
            }
            return true;
        }
    }
}
