using System;
using MySql.Data.MySqlClient;

namespace Gestion_De_Locales
{
    public static class ConexionBD
    {
        private static string servidor = "localhost";
        private static string puerto = "3306";
        private static string usuario = "root";
        private static string password = "pass123";
        private static string db = "db_reservacion";

        private static string cadenaConexion = $"Server={servidor};Port={puerto};Database={db};User ID={usuario};Password={password};";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
