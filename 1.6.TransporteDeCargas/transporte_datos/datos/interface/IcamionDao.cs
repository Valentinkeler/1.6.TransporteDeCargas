using System.Data;

namespace transporte_datos.datos
{
    public interface IcamionDao
    {
        void bajaLogica(string SP, int idCamion);
        bool maestroDetalle(camion oCamion);
        DataTable reader(string SP);
    }
}