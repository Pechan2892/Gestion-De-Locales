using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales.Service
{
    public class LoginService
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public Usuario Autenticar(string username, string password)
        {
            Usuario usuario = usuarioDAO.ObtenerUsuarioPorUsername(username);

            if (usuario != null)
            {
                bool isValidPassword = BCrypt.Net.BCrypt.Verify(password, usuario.Password);
                if (isValidPassword)
                {
                    return usuario; // Retorna el usuario si la autenticación es exitosa.
                }
            }
            return null; // Retorna null si la autenticación falla.
        }
    }
}
