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

        public bool confirmar()
        {
            Estado = true;

            SqlConnection conexion = new    SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True");
            SqlTransaction t =  null;

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("pa_insertarCamion", conexion);
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@patente", Patente);
                comando.Parameters.AddWithValue("@pesoMaximo", PesoMaximo);
                comando.Parameters.AddWithValue("@estado", Estado);

                SqlParameter param = new SqlParameter("@idCamion", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();    

                int IdCamion = Convert.ToInt32(param.Value);

                foreach (carga item in Carga)
                {
                    SqlCommand cmd = new SqlCommand("pa_insertarCarga", conexion);
                    cmd.Transaction = t;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peso", item.PesoCarga);
                    cmd.Parameters.AddWithValue("@codigoTipoCarga", item.TipoCarga.TipoCarga);
                    cmd.Parameters.AddWithValue("@idCamion", IdCamion);

                    cmd.ExecuteNonQuery();
                    
                }
                t.Commit();
                Estado = true;
            }
            catch (Exception)
            {
                t.Rollback();
                Estado = false;
            }
            finally
            {
                if (conexion != null && conexion.State==ConnectionState.Open)
                    conexion.Close();
            }
            return Estado;
        }
    }
}
