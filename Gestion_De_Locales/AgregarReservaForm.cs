using System;
using System.Windows.Forms;
using Gestion_De_Locales.Service;

namespace Gestion_De_Locales
{
    public partial class AgregarReservaForm : Form
    {
        private ReservaService reservaService = new ReservaService();
        private LocalService localService = new LocalService();
        private ArtistaService artistaService = new ArtistaService();

        public AgregarReservaForm()
        {
            InitializeComponent();
            CargarLocalesYArtistas();
        }

        private void CargarLocalesYArtistas()
        {
            cmbLocales.DataSource = localService.ObtenerTodosLosLocales();
            cmbLocales.DisplayMember = "NombreLocal";
            cmbLocales.ValueMember = "IdLocal";

            cmbArtistas.DataSource = artistaService.ObtenerTodosLosArtistas();
            cmbArtistas.DisplayMember = "NombreArtista";
            cmbArtistas.ValueMember = "IdArtista";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Reserva nuevaReserva = new Reserva
            {
                IdLocal = (int)cmbLocales.SelectedValue,
                IdArtista = (int)cmbArtistas.SelectedValue,
                Fecha = Convert.ToDateTime(txtFecha.Text),
                HoraInicio = TimeSpan.Parse(txtHoraInicio.Text),
                HoraFin = TimeSpan.Parse(txtHoraFin.Text),
                Costo = Convert.ToDecimal(txtCosto.Text)
            };

            bool resultado = reservaService.AgregarNuevaReserva(nuevaReserva);

            if (resultado)
            {
                MessageBox.Show("Reserva agregada exitosamente!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la reserva.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

