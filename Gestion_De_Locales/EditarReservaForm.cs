using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;
using Gestion_De_Locales.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_De_Locales
{
    public partial class EditarReservaForm : Form
    {
        private Reserva reservaActual;
        private ReservaService reservaService = new ReservaService();
        private LocalService localService = new LocalService();
        private ArtistaService artistaService = new ArtistaService();

        public EditarReservaForm(int reservaId)
        {
            InitializeComponent();
            reservaActual = reservaService.ObtenerReservaPorID(reservaId);
            CargarDatosReserva();
        }

        private void CargarDatosReserva()
        {
            txtFecha.Text = reservaActual.Fecha.ToString();
            txtHoraInicio.Text = reservaActual.HoraInicio.ToString();
            txtHoraFin.Text = reservaActual.HoraFin.ToString();
            txtCosto.Text = reservaActual.Costo.ToString();

            CargarLocalesYArtistas();

            cmbLocales.SelectedValue = reservaActual.IdLocal;
            cmbArtistas.SelectedValue = reservaActual.IdArtista;
        }

        private void CargarLocalesYArtistas()
        {
            List<Local> locales = localService.ObtenerTodosLosLocales();
            cmbLocales.DataSource = locales;
            cmbLocales.DisplayMember = "NombreLocal";
            cmbLocales.ValueMember = "IdLocal";

            List<Artista> artistas = artistaService.ObtenerTodosLosArtistas();
            cmbArtistas.DataSource = artistas;
            cmbArtistas.DisplayMember = "NombreArtista";
            cmbArtistas.ValueMember = "IdArtista";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            reservaActual.Fecha = DateTime.Parse(txtFecha.Text);
            reservaActual.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            reservaActual.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            reservaActual.Costo = decimal.Parse(txtCosto.Text);
            reservaActual.IdLocal = (int)cmbLocales.SelectedValue;
            reservaActual.IdArtista = (int)cmbArtistas.SelectedValue;

            reservaService.ActualizarReserva(reservaActual);

            MessageBox.Show("Reserva actualizada con éxito!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
