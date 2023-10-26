using System;
using System.Windows.Forms;
using Gestion_De_Locales.Service; // Importa el namespace del servicio

namespace Gestion_De_Locales
{
    public partial class Registro : Form
    {
        private UsuarioService usuarioService = new UsuarioService();

        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Crea una instancia de la clase Usuarios y asigna los valores desde los cuadros de texto
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Password = BCrypt.Net.BCrypt.HashPassword(txtPasword.Text);

            // Verificar que las contraseñas coincidan
            if (!usuario.Password.Equals(BCrypt.Net.BCrypt.HashPassword(txtConfirmar.Text)))
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el tipo de usuario a int
            if (!int.TryParse(txtTipoUsuario.Text, out int idTipo))
            {
                MessageBox.Show("Por favor, ingrese un tipo de usuario válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usuario.IdTipo = idTipo;

            try
            {
                // Usar el servicio de usuario para agregar el nuevo usuario
                bool registroExitoso = usuarioService.AgregarNuevoUsuario(usuario);

                if (registroExitoso)
                {
                    MessageBox.Show("Usuario registrado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error al registrar el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // En caso de excepción, muestra un cuadro de diálogo con el mensaje de la excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
