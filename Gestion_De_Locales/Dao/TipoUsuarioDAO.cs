using Gestion_De_Locales.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Locales.DAO
{
    public class TipoUsuarioDAO
    {
        public List<TipoUsuario> ObtenerTodosLosTiposUsuarios()
        {
            List<TipoUsuario> tiposUsuarios = new List<TipoUsuario>();

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM tipo_usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tiposUsuarios.Add(new TipoUsuario
                        {
                            IdTipo = reader.GetInt32("id_tipo"),
                            Nombre = reader.GetString("nombre")
                        });
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tipos de usuarios: " + ex.Message);
            }

            return tiposUsuarios;
        }

        public TipoUsuario ObtenerTipoUsuarioPorID(int id)
        {
            TipoUsuario tipoUsuario = null;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM tipo_usuario WHERE id_tipo = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tipoUsuario = new TipoUsuario
                        {
                            IdTipo = reader.GetInt32("id_tipo"),
                            Nombre = reader.GetString("nombre")
                        };
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el tipo de usuario: " + ex.Message);
            }

            return tipoUsuario;
        }

        public void AgregarTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO tipo_usuario(nombre) VALUES(@nombre)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", tipoUsuario.Nombre);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar tipo de usuario: " + ex.Message);
            }
        }

        public void ActualizarTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE tipo_usuario SET nombre=@nombre WHERE id_tipo=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", tipoUsuario.IdTipo);
                    cmd.Parameters.AddWithValue("@nombre", tipoUsuario.Nombre);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar tipo de usuario: " + ex.Message);
            }
        }

        public void EliminarTipoUsuario(int id)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM tipo_usuario WHERE id_tipo=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar tipo de usuario: " + ex.Message);
            }
        }
    }
}

