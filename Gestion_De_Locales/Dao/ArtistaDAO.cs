using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales.DAO
{
    public class ArtistaDAO
    {
        public List<Artista> ObtenerTodosLosArtistas()
        {
            List<Artista> artistas = new List<Artista>();

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM artista";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        artistas.Add(new Artista
                        {
                            IdArtista = reader.GetInt32("id_artista"),
                            NombreArtista = reader.GetString("nombre"),
                            GeneroMusical = reader.GetString("genero"),
                            // ... Agregar otros campos aquí ...
                        });
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener artistas: " + ex.Message);
            }

            return artistas;
        }

        public Artista ObtenerArtistaPorID(int id)
        {
            Artista artista = null;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM artista WHERE id_artista = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        artista = new Artista
                        {
                            IdArtista = reader.GetInt32("id_artista"),
                            NombreArtista = reader.GetString("nombre"),
                            GeneroMusical = reader.GetString("genero"),
                            // ... Agregar otros campos aquí ...
                        };
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el artista: " + ex.Message);
            }

            return artista;
        }

        public void AgregarArtista(Artista artista)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO artista(nombre, genero, ...) VALUES(@nombre, @genero, ...)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", artista.NombreArtista);
                    cmd.Parameters.AddWithValue("@genero", artista.GeneroMusical);
                    // ... Agregar otros campos aquí ...
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar artista: " + ex.Message);
            }
        }

        public void ActualizarArtista(Artista artista)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE artista SET nombre=@nombre, genero=@genero, ... WHERE id_artista=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", artista.IdArtista);
                    cmd.Parameters.AddWithValue("@nombre", artista.NombreArtista);
                    cmd.Parameters.AddWithValue("@genero", artista.GeneroMusical);
                    // ... Agregar otros campos aquí ...
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar artista: " + ex.Message);
            }
        }

        public void EliminarArtista(int id)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM artista WHERE id_artista=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar artista: " + ex.Message);
            }
        }
    }
}
