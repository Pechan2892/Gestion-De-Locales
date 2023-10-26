using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Locales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestionarReservas_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de reservas.
            ReservasForm reservasForm = new ReservasForm();
            reservasForm.ShowDialog();
        }

        private void btnGestionarLocales_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de locales.
            LocalesForm localesForm = new LocalesForm();
            localesForm.ShowDialog();
        }

        private void btnGestionarArtistas_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de artistas.
            ArtistasForm artistasForm = new ArtistasForm();
            artistasForm.ShowDialog();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de clientes.
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.ShowDialog();
        }

        private void salido_Click(object sender, EventArgs e)
        {
            // Cierra el formulario principal.
            this.Close();
        }

        private void txtRegistroUsuarios_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro de usuarios.
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
        }
    }
}

