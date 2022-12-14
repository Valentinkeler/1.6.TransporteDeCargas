using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte_datos.datos
{
    public class helperDao
    {
        private static  helperDao instancia;
        private SqlConnection cnn;
        private helperDao()
        {
            cnn.ConnectionString = "Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True";
        }
        public  static  helperDao obtenerInstancia()
        {
            if (instancia!=null)
            {
                instancia=new   helperDao();
            }
            return instancia;
        }
        public  DataTable reader(string SP)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand comando = new SqlCommand(SP, cnn);
            comando.CommandType = CommandType.StoredProcedure;

            tabla.Load(comando.ExecuteReader());

            cnn.Close();
            return tabla;
        }
        public  void BajaLogica(string  SP,int  idCamion)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand(SP, cnn);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCamion", idCamion);


            comando.ExecuteNonQuery();

            cnn.Close();
        }
        public  bool maestroDetalle(camion  oCamion,string spMaestro,string spDetalle)
        {
            bool Estado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(spMaestro, cnn);
                t = cnn.BeginTransaction();
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@patente", oCamion.Patente);
                comando.Parameters.AddWithValue("@pesoMaximo", oCamion.PesoMaximo);
                comando.Parameters.AddWithValue("@estado", "A");

                SqlParameter param = new SqlParameter("@idCamion", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);

                comando.ExecuteNonQuery();

                int IdCamion = Convert.ToInt32(param.Value);

                foreach (carga item in oCamion.Carga)
                {
                    SqlCommand cmd = new SqlCommand(spDetalle, cnn);
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
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return Estado;
        }
    }
}
