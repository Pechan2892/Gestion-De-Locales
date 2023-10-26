using System;
using System.Windows.Forms;
using Gestion_De_Locales.DAO;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales
{
    public partial class ClientesForm : Form
    {
        ClienteDAO clienteDAO = new ClienteDAO();

        public ClientesForm()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = clienteDAO.ObtenerTodosLosClientes();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Lógica similar a la de LocalesForm
            CargarClientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            // Lógica similar a la de LocalesForm
            CargarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int idClienteSeleccionado = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
            clienteDAO.EliminarCliente(idClienteSeleccionado);
            CargarClientes();
        }
    }
}
