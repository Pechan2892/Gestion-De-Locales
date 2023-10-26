using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;
using System;
using System.Collections.Generic;

namespace Gestion_De_Locales.Service
{
    public class TipoUsuarioService
    {
        private TipoUsuarioDAO tipoUsuarioDAO = new TipoUsuarioDAO();

        public List<TipoUsuario> ObtenerTodosLosTiposUsuarios()
        {
            return tipoUsuarioDAO.ObtenerTodosLosTiposUsuarios();
        }

        public TipoUsuario ObtenerTipoUsuarioPorID(int id)
        {
            return tipoUsuarioDAO.ObtenerTipoUsuarioPorID(id);
        }

        public bool AgregarTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                tipoUsuarioDAO.AgregarTipoUsuario(tipoUsuario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TipoUsuarioService: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                tipoUsuarioDAO.ActualizarTipoUsuario(tipoUsuario);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TipoUsuarioService: " + ex.Message);
                return false;
            }
        }

        public bool EliminarTipoUsuario(int id)
        {
            try
            {
                tipoUsuarioDAO.EliminarTipoUsuario(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en TipoUsuarioService: " + ex.Message);
                return false;
            }
        }
    }
}
