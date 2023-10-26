using Gestion_De_Locales.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Locales.Service
{
    public class ClienteService
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public Cliente ObtenerClientePorID(int id)
        {
            return clienteDAO.ObtenerClientePorID(id);
        }

        public bool AgregarNuevoCliente(Cliente cliente)
        {
            // Validaciones adicionales
            if (string.IsNullOrEmpty(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            return clienteDAO.AgregarNuevoCliente(cliente);
        }

        // Otros métodos según las necesidades de tu proyecto...
    }

}
