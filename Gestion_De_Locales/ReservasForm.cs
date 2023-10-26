using System;
using System.Windows.Forms;
using Gestion_De_Locales.Service;

namespace Gestion_De_Locales
{
    public partial class ReservasForm : Form
    {
        public ReservasForm()
        {
            InitializeComponent();
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            AgregarReservaForm agregarReserva = new AgregarReservaForm();
            agregarReserva.ShowDialog();
            CargarReservas();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            int reservaId = (int)dgvReservas.SelectedRows[0].Cells["ID"].Value;
            EditarReservaForm editarReserva = new EditarReservaForm(reservaId);
            editarReserva.ShowDialog();
            CargarReservas();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            int reservaId = (int)dgvReservas.SelectedRows[0].Cells["ID"].Value;
            ReservaService reservaService = new ReservaService();
            reservaService.EliminarReserva(reservaId);
            CargarReservas();
        }

        private void CargarReservas()
        {
            ReservaService reservaService = new ReservaService();
            dgvReservas.DataSource = reservaService.ObtenerTodasLasReservas();
        }
    }
}

