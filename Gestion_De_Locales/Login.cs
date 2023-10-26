using System;
using System.Windows.Forms;
using Gestion_De_Locales.Service;
using MySql.Data.MySqlClient;

namespace Gestion_De_Locales
{
    public partial class Login : Form
    {
        private LoginService loginService = new LoginService(); // Instancia del servicio de inicio de sesión

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            try
            {
                Usuario usuarioAutenticado = loginService.Autenticar(txtUsuario.Text, txtPassword.Text);

                if (usuarioAutenticado != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso!");

                    // Aquí puedes abrir el siguiente formulario después del inicio de sesión.
                    // Por ejemplo, si el usuario es admin, abrir el formulario de admin, de lo contrario abrir el formulario estándar.
                    if (usuarioAutenticado.EsAdmin())
                    {
                        // Abrir ventana de administrador
                        // Ejemplo: new AdminForm().Show();
                    }
                    else
                    {
                        // Abrir ventana de usuario normal
                        // Ejemplo: new UserForm().Show();
                    }

                    this.Close();
                }
                else
                {
                    lblMensajeError.Text = "Usuario o contraseña incorrectos.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Registro de errores
                System.IO.File.AppendAllText(@"C:\path\to\log.txt", DateTime.Now + ": " + ex.ToString() + Environment.NewLine);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    conn.Open();  // Intenta abrir la conexión.
                    var cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios", conn);
                    var count = cmd.ExecuteScalar();  // Ejecuta la consulta.
                    MessageBox.Show($"Hay {count} usuarios en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, se mostrará en un mensaje.
                MessageBox.Show("Error al intentar conectarse: " + ex.Message);
            }
        }
    }
}
