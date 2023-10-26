using Gestion_De_Locales.DAO;
using System;
using System.Collections.Generic;

namespace Gestion_De_Locales.Service
{
    public class ReservaService
    {
        private ReservaDAO reservaDAO = new ReservaDAO();

        public Reserva ObtenerReservaPorID(int id)
        {
            return reservaDAO.ObtenerReservaPorID(id);
        }

        public bool AgregarNuevaReserva(Reserva reserva)
        {
            try
            {
                reservaDAO.AgregarNuevaReserva(reserva);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarReserva(int reservaId)
        {
            try
            {
                reservaDAO.EliminarReserva(reservaId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Reserva> ObtenerTodasLasReservas()
        {
            return reservaDAO.ObtenerTodasLasReservas();
        }

        public void ActualizarReserva(Reserva reservaActual)
        {
            try
            {
                reservaDAO.ActualizarReserva(reservaActual); // Llama al método correspondiente en ReservaDAO
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la reserva: " + ex.Message);
            }
        }
    }
}

