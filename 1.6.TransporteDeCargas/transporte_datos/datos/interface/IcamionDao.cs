using System.Data;

namespace transporte_datos.datos
{
    public interface IcamionDao
    {
        void bajaLogica(int idCamion);
        bool maestroDetalle(camion oCamion);
        List<camion> reader();
    }
}