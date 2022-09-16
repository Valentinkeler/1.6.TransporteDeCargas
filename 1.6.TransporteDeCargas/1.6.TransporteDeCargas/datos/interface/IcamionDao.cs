using System.Data;

namespace _1._6.TransporteDeCargas.datos
{
    internal interface IcamionDao
    {
        void bajaLogica(string SP, int idCamion);
        bool maestroDetalle(camion oCamion);
        DataTable reader(string SP);
    }
}