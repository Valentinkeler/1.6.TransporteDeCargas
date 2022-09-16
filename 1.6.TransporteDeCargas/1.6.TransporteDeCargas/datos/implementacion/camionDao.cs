using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.TransporteDeCargas.datos
{
    internal class camionDao : IcamionDao
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-EU00IF5;Initial Catalog=113151-Keler-TransporteDeCarga;Integrated Security=True");



        public DataTable reader(string SP)
        {
            return  helperDao.obtenerInstancia().reader(SP);
        }

        public bool maestroDetalle(camion oCamion)
        {
            bool Estado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand("pa_insertarCamion", cnn);
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
                    SqlCommand cmd = new SqlCommand("pa_insertarCarga", cnn);
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
        public void bajaLogica(string SP, int idCamion)
        {
           helperDao.obtenerInstancia().BajaLogica(SP, idCamion);
        }
        //public void cargarGrilla(string SP,DataGridView grilla)
        //{
        //    List<camion> lCamion = new List<camion>();
        //    //DataTable tabla = new DataTable();
        //    cnn.Open();
        //    SqlCommand comando = new SqlCommand(SP, cnn);
        //    comando.CommandType = CommandType.StoredProcedure;

        //    SqlDataReader   reader  = comando.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        oCamion.Patente=reader.GetString(1);
        //        oCamion.PesoMaximo = reader.GetInt32(2);

        //        lCamion.Add(oCamion);
        //    }
        //    reader.Close();
        //    cnn.Close();

        //    grilla.Rows.Add(new object  });

        //}
    }
}
