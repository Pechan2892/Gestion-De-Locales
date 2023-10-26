using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Locales.DAO
{
    public class ReservaDAO
    {
        public List<Reserva> ObtenerTodasLasReservas()
        {
            List<Reserva> reservas = new List<Reserva>();

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM reserva";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        reservas.Add(new Reserva
                        {
                            IdReserva = reader.GetInt32("id_reserva"),
                            IdLocal = reader.GetInt32("id_local"),
                            IdArtista = reader.GetInt32("id_artista"),
                            Fecha = reader.GetDateTime("fecha"),
                            HoraInicio = reader.GetTimeSpan("hora_inicio"),
                            HoraFin = reader.GetTimeSpan("hora_fin"),
                            Costo = reader.GetDecimal("costo")
                        });
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener reservas: " + ex.Message);
            }

            return reservas;
        }

        public Reserva ObtenerReservaPorID(int id)
        {
            Reserva reserva = null;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM reserva WHERE id_reserva = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reserva = new Reserva
                        {
                            IdReserva = reader.GetInt32("id_reserva"),
                            IdLocal = reader.GetInt32("id_local"),
                            IdArtista = reader.GetInt32("id_artista"),
                            Fecha = reader.GetDateTime("fecha"),
                            HoraInicio = reader.GetTimeSpan("hora_inicio"),
                            HoraFin = reader.GetTimeSpan("hora_fin"),
                            Costo = reader.GetDecimal("costo")
                        };
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la reserva: " + ex.Message);
            }

            return reserva;
        }

        public void AgregarReserva(Reserva reserva)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO reserva(id_local, id_artista, fecha, hora_inicio, hora_fin, costo) VALUES(@idLocal, @idArtista, @fecha, @horaInicio, @horaFin, @costo)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idLocal", reserva.IdLocal);
                    cmd.Parameters.AddWithValue("@idArtista", reserva.IdArtista);
                    cmd.Parameters.AddWithValue("@fecha", reserva.Fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", reserva.HoraInicio);
                    cmd.Parameters.AddWithValue("@horaFin", reserva.HoraFin);
                    cmd.Parameters.AddWithValue("@costo", reserva.Costo);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar reserva: " + ex.Message);
            }
        }

        public void ActualizarReserva(Reserva reserva)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE reserva SET id_local=@idLocal, id_artista=@idArtista, fecha=@fecha, hora_inicio=@horaInicio, hora_fin=@horaFin, costo=@costo WHERE id_reserva=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", reserva.IdReserva);
                    cmd.Parameters.AddWithValue("@idLocal", reserva.IdLocal);
                    cmd.Parameters.AddWithValue("@idArtista", reserva.IdArtista);
                    cmd.Parameters.AddWithValue("@fecha", reserva.Fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", reserva.HoraInicio);
                    cmd.Parameters.AddWithValue("@horaFin", reserva.HoraFin);
                    cmd.Parameters.AddWithValue("@costo", reserva.Costo);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar reserva: " + ex.Message);
            }
        }

        public void EliminarReserva(int id)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM reserva WHERE id_reserva=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar reserva: " + ex.Message);
            }
        }
        public void AgregarNuevaReserva(Reserva reserva)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO reserva(id_local, id_artista, fecha, hora_inicio, hora_fin, costo) VALUES (@idLocal, @idArtista, @fecha, @horaInicio, @horaFin, @costo)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idLocal", reserva.IdLocal);
                cmd.Parameters.AddWithValue("@idArtista", reserva.IdArtista);
                cmd.Parameters.AddWithValue("@fecha", reserva.Fecha);
                cmd.Parameters.AddWithValue("@horaInicio", reserva.HoraInicio);
                cmd.Parameters.AddWithValue("@horaFin", reserva.HoraFin);
                cmd.Parameters.AddWithValue("@costo", reserva.Costo);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
    }
}
