using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using Gestion_De_Locales.Modelos;

namespace Gestion_De_Locales.DAO
{
    public class LocalDAO
    {
        public List<Local> ObtenerTodosLosLocales()
        {
            List<Local> locales = new List<Local>();

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM local";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        locales.Add(new Local
                        {
                            IdLocal = reader.GetInt32("id_local"),
                            NombreLocal = reader.GetString("nombre"),
                            Capacidad = reader.GetInt32("capacidad"),
                            Direccion = reader.GetString("direccion"),
                            DistribucionFisica = reader.GetString("distribucion_fisica"),
                            Iluminacion = reader.GetString("iluminacion") == "si",
                            Sonido = reader.GetString("sonido") == "si",
                            Sillas = reader.GetString("sillas") == "si",
                            Tipo = reader.GetString("tipo") == "abierto" ? TipoLocal.Abierto : TipoLocal.Cerrado
                        });
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener locales: " + ex.Message);
            }

            return locales;
        }

        public Local ObtenerLocalPorID(int id)
        {
            Local local = null;

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "SELECT * FROM local WHERE id_local = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        local = new Local
                        {
                            IdLocal = reader.GetInt32("id_local"),
                            NombreLocal = reader.GetString("nombre"),
                            Capacidad = reader.GetInt32("capacidad"),
                            Direccion = reader.GetString("direccion"),
                            DistribucionFisica = reader.GetString("distribucion_fisica"),
                            Iluminacion = reader.GetString("iluminacion") == "si",
                            Sonido = reader.GetString("sonido") == "si",
                            Sillas = reader.GetString("sillas") == "si",
                            Tipo = reader.GetString("tipo") == "abierto" ? TipoLocal.Abierto : TipoLocal.Cerrado
                        };
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el local: " + ex.Message);
            }

            return local;
        }

        public void AgregarLocal(Local local)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "INSERT INTO local(nombre, capacidad, direccion, distribucion_fisica, iluminacion, sonido, sillas, tipo) VALUES(@nombre, @capacidad, @direccion, @distribucion, @iluminacion, @sonido, @sillas, @tipo)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", local.NombreLocal);
                    cmd.Parameters.AddWithValue("@capacidad", local.Capacidad);
                    cmd.Parameters.AddWithValue("@direccion", local.Direccion);
                    cmd.Parameters.AddWithValue("@distribucion", local.DistribucionFisica);
                    cmd.Parameters.AddWithValue("@iluminacion", local.Iluminacion ? "si" : "no");
                    cmd.Parameters.AddWithValue("@sonido", local.Sonido ? "si" : "no");
                    cmd.Parameters.AddWithValue("@sillas", local.Sillas ? "si" : "no");
                    cmd.Parameters.AddWithValue("@tipo", local.Tipo == TipoLocal.Abierto ? "abierto" : "cerrado");
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar local: " + ex.Message);
            }
        }

        public void ActualizarLocal(Local local)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "UPDATE local SET nombre=@nombre, capacidad=@capacidad, direccion=@direccion, distribucion_fisica=@distribucion, iluminacion=@iluminacion, sonido=@sonido, sillas=@sillas, tipo=@tipo WHERE id_local=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", local.IdLocal);
                    cmd.Parameters.AddWithValue("@nombre", local.NombreLocal);
                    cmd.Parameters.AddWithValue("@capacidad", local.Capacidad);
                    cmd.Parameters.AddWithValue("@direccion", local.Direccion);
                    cmd.Parameters.AddWithValue("@distribucion", local.DistribucionFisica);
                    cmd.Parameters.AddWithValue("@iluminacion", local.Iluminacion ? "si" : "no");
                    cmd.Parameters.AddWithValue("@sonido", local.Sonido ? "si" : "no");
                    cmd.Parameters.AddWithValue("@sillas", local.Sillas ? "si" : "no");
                    cmd.Parameters.AddWithValue("@tipo", local.Tipo == TipoLocal.Abierto ? "abierto" : "cerrado");
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar local: " + ex.Message);
            }
        }

        public void EliminarLocal(int id)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string query = "DELETE FROM local WHERE id_local=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar local: " + ex.Message);
            }
        }
    }
}
