using System;
using System.Windows.Forms;
using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales
{
    public partial class ArtistasForm : Form
    {
        ArtistaDAO artistaDAO = new ArtistaDAO();

        public ArtistasForm()
        {
            InitializeComponent();
            CargarArtistas();
        }

        private void CargarArtistas()
        {
            dgvArtistas.DataSource = artistaDAO.ObtenerTodosLosArtistas();
        }

        private void btnAgregarArtista_Click(object sender, EventArgs e)
        {
            // Lógica similar a la de LocalesForm
            CargarArtistas();
        }

        private void btnEditarArtista_Click(object sender, EventArgs e)
        {
            // Lógica similar a la de LocalesForm
            CargarArtistas();
        }

        private void btnEliminarArtista_Click(object sender, EventArgs e)
        {
            int idArtistaSeleccionado = Convert.ToInt32(dgvArtistas.CurrentRow.Cells["Id"].Value);
            artistaDAO.EliminarArtista(idArtistaSeleccionado);
            CargarArtistas();
        }
    }
}
