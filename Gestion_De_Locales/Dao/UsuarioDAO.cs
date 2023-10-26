using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales.DAO
{
    public class UsuarioDAO
    {
        // ... [Método ObtenerTodosLosUsuarios y ObtenerUsuarioPorID] ...

        public void Agregar(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO usuarios(usuario, password, nombre, id_tipo) VALUES(@usuario, @password, @nombre, @id_tipo)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@password", usuario.Password);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@id_tipo", usuario.IdTipo);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
        }


        public void Actualizar(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE usuarios SET usuario=@usuario, password=@password, nombre=@nombre, id_tipo=@id_tipo WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@password", usuario.Password);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@id_tipo", usuario.IdTipo);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM usuarios WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }
        public Usuario ObtenerUsuarioPorID(int id)
        {
            Usuario usuario = null;

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM usuarios WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        IdUsuario = reader.GetInt32("id"),
                        Nombre = reader.GetString("nombre"),
                        // ... (asignar los demás campos del usuario)
                    };
                }

                reader.Close();
                conexion.Close();
            }

            return usuario;
        }
        public void AgregarNuevoUsuario(Usuario usuario)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "INSERT INTO usuarios(usuario, password, nombre, id_tipo) VALUES (@usuario, @password, @nombre, @idTipo)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@password", usuario.Password);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@idTipo", usuario.IdTipo);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public Usuario ObtenerUsuarioPorUsername(string username)
        {
            Usuario usuario = null;

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM usuarios WHERE usuario = @username";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@username", username);

                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        IdUsuario = reader.GetInt32("id"),
                        NombreUsuario = reader.GetString("usuario"),
                        Password = reader.GetString("password"),
                        Nombre = reader.GetString("nombre"),
                        IdTipo = reader.GetInt32("id_tipo")
                    };
                }
                else
                {
                    throw new Exception("No se encontró ningún usuario con ese nombre.");
                }

                reader.Close();
                conexion.Close();
            }

            if (usuario == null)
            {
                throw new Exception("El usuario es nulo después de intentar obtenerlo de la base de datos.");
            }

            return usuario;
        }


    }
}

