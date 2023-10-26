using System;
using System.Windows.Forms;
using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales
{
    public partial class LocalesForm : Form
    {
        LocalDAO localDAO = new LocalDAO();

        public LocalesForm()
        {
            InitializeComponent();
            CargarLocales();
        }

        private void CargarLocales()
        {
            dgvLocales.DataSource = localDAO.ObtenerTodosLosLocales();
        }

        private void btnAgregarLocal_Click(object sender, EventArgs e)
        {
            // Aquí, por ejemplo, podrías abrir un formulario de AgregarLocal y, 
            // después de agregarlo exitosamente, recargar la lista.
            CargarLocales();
        }

        private void btnEditarLocal_Click(object sender, EventArgs e)
        {
            // Lógica similar a agregar, pero cargando el formulario de edición con datos del local seleccionado.
            CargarLocales();
        }

        private void btnEliminarLocal_Click(object sender, EventArgs e)
        {
            int idLocalSeleccionado = Convert.ToInt32(dgvLocales.CurrentRow.Cells["Id"].Value);
            localDAO.EliminarLocal(idLocalSeleccionado);
            CargarLocales();
        }
    }
}

