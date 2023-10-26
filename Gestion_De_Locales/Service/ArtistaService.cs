using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;
using System;
using System.Collections.Generic;

namespace Gestion_De_Locales.Service
{
    public class ArtistaService
    {
        private ArtistaDAO artistaDAO = new ArtistaDAO();

        public List<Artista> ObtenerTodosLosArtistas()
        {
            try
            {
                return artistaDAO.ObtenerTodosLosArtistas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los artistas: " + ex.Message);
            }
        }

        public Artista ObtenerArtistaPorID(int id)
        {
            try
            {
                return artistaDAO.ObtenerArtistaPorID(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el artista por ID: " + ex.Message);
            }
        }

        public bool AgregarArtista(Artista artista)
        {
            try
            {
                artistaDAO.AgregarArtista(artista);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar artista: " + ex.Message);
            }
        }

        public bool ActualizarArtista(Artista artista)
        {
            try
            {
                artistaDAO.ActualizarArtista(artista);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar artista: " + ex.Message);
            }
        }

        public bool EliminarArtista(int id)
        {
            try
            {
                artistaDAO.EliminarArtista(id);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar artista: " + ex.Message);
            }
        }
    }
}
