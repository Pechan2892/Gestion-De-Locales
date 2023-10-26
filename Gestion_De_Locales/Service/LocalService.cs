using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;
using System.Collections.Generic;

namespace Gestion_De_Locales.Service
{
    public class LocalService
    {
        private LocalDAO localDAO = new LocalDAO();

        public List<Local> ObtenerTodosLosLocales()
        {
            return localDAO.ObtenerTodosLosLocales();
        }

        public Local ObtenerLocalPorID(int id)
        {
            return localDAO.ObtenerLocalPorID(id);
        }

        public void AgregarLocal(Local local)
        {
            localDAO.AgregarLocal(local);
        }

        public void ActualizarLocal(Local local)
        {
            localDAO.ActualizarLocal(local);
        }

        public void EliminarLocal(int id)
        {
            localDAO.EliminarLocal(id);
        }
    }
}
