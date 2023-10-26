using System;

public class Reserva
{
    public int IdReserva { get; set; }
    public int IdLocal { get; set; }
    public int IdArtista { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public decimal Costo { get; set; }

    // Métodos adicionales:
    public TimeSpan Duracion()
    {
        return HoraFin - HoraInicio;
    }

    public bool EsEventoNocturno()
    {
        return HoraInicio.Hours >= 20 || HoraFin.Hours <= 6;
    }
}
