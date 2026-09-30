using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class Repocitorio_Usuario
    {
      

        //Registro de una lista de categorias//
        public void RegistrarLista(List<Usuario> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var usuario in lista)
                    {
                        SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;


                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                        cmd.Parameters.AddWithValue("@id_Rol", usuario.id_Rol);
                        cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                        cmd.Parameters.AddWithValue("@CreadoPor", usuario.CreadoPor ?? "Jose Hernandez");


                        //Ejecutar el comando
                        cmd.ExecuteNonQuery();

                    }
                    //cierre de conexion a la base de datos
                    connection.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public Usuario ValidarUsuario(string Nombre, string contraseña)
        {
            Usuario usuario = null;
            using (SqlConnection connection = BDConexion.connect())
            {
                connection.Open();
                // Convertir la contraseña escrita a SHA-256
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                    byte[] hash = sha256.ComputeHash(bytes);

                    StringBuilder resultado = new StringBuilder();

                    foreach (byte b in hash)
                    {
                        resultado.Append(b.ToString("X2"));
                    }

                    contraseña = resultado.ToString();
                }

                string sql = @"SELECT * FROM Usuario 
                       WHERE NombreUsuario = @NombreUsuario 
                       AND Contraseña_Hash = @Contraseña_Hash";

                SqlCommand cmd = new SqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@NombreUsuario", Nombre);
                cmd.Parameters.AddWithValue("@Contraseña_Hash", contraseña);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        id_Usuario = Convert.ToInt32(reader["id_Usuario"]),
                        Nombre = reader["NombreUsuario"].ToString(),
                        id_Rol = Convert.ToInt32(reader["id_Rol"])
                    };
                }
            }

            return usuario;
        }
        // Obtener los registros  desde la base de datos//

        public List<Usuario> ObtenerListaActiva()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string query = "SELECT * FROM uv_MostrarUsuarios";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var usuario = new Usuario()
                        {
                            id_Usuario = (int)reader["id_Usuario"],
                            Nombre = reader["NombreUsuario"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            id_Rol = (int)reader["id_Rol"],
                            Estado = (bool)reader["Estado"],
                            NombreRol = reader["NombreRol"].ToString(),
                            CreadoPor = reader["CreadoPor"].ToString(),
                            
                        };

                        ListaUsuario.Add(usuario);
                    }

                    connection.Close();

                    return ListaUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Usuario> ObtenerLista()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Usuario WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Usuario= new Usuario()
                        {
                            id_Usuario = (int)reader["id_Usuario"],
                            Nombre = reader["NombreUsuario"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            id_Rol = (int)reader["id_Rol"],
                            Estado = (bool)reader["Estado"]

                        };

                        ListaUsuario.Add(Usuario);
                    }

                    connection.Close();

                    return ListaUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar 
        public void EliminarPorid(int idUsuario)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Usuario SET Estado = 0 WHERE id_Usuario = @id_Usuario";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Usuario", idUsuario);

                    cmd.ExecuteNonQuery();


                    connection.Close();



                }

            }
            catch
            {
                throw;
            }
        }
        //editar una categoria
        public void Actualizar(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Categoria SET Nombre =@Nombre,Correo = @Correo,Contraseña = @Contraseña,Rol = @Rol,Estado = @Estado WHERE id_Usuario = @id_Usuario";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@Rol", usuario.id_Rol);
                    cmd.Parameters.AddWithValue("@Estado", usuario.Estado);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch (Exception)
            {
                throw;

            }

           

        }
    }
}
    

    

