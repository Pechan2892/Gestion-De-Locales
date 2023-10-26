using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales.Service
{
    public class UsuarioService
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public bool EsUsuarioAdmin(Usuario usuario)
        {
            return usuario.IdTipo == 1; // Suponiendo que 1 es el tipo para Administrador.
        }

        public Usuario ObtenerUsuarioPorID(int id)
        {
            return usuarioDAO.ObtenerUsuarioPorID(id);
        }

        public bool AgregarNuevoUsuario(Usuario usuario)
        {
            try
            {
                usuarioDAO.AgregarNuevoUsuario(usuario);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para autenticar usuario
        public Usuario Autenticar(string username, string password)
        {
            var usuario = usuarioDAO.ObtenerUsuarioPorUsername(username);

            if (usuario != null && usuario.Password == password) // En un escenario real, deberías verificar el hash
            {
                return usuario;
            }

            return null;
        }
    }
}
