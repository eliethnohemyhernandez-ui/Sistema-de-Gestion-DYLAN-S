using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioUsuarioRol
    {
        public void RegistrarLista(List<UsuarioRl> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var usuarioRl in lista)
                    {
                        //Personalizar el Comando a enviar a la BD
                        string sql = "INSERT INTO Rol (Nombre,Descripcion,Estado)VALUES(@Nombre,@Descrpcion,@Estado)";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@Nombre", usuarioRl.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", usuarioRl.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado",usuarioRl.Estado);


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
        // Obtener los registros  desde la base de datos//

        public List<UsuarioRl> ObtenerLista()
        {
            List<UsuarioRl> ListaUsuarioRol = new List<UsuarioRl>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Rol WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var UsuarioRl = new UsuarioRl()
                        {
                            IdRol = (int)reader["id_Rol"],
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };

                        ListaUsuarioRol.Add(UsuarioRl);
                    }

                    connection.Close();

                    return ListaUsuarioRol;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar 
        public void EliminarPorid(int idRol)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Rol SET Estado = 0 WHERE id_Rol = @id_Rol";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Rol", idRol);

                    cmd.ExecuteNonQuery();


                    connection.Close();



                }

            }
            catch
            {
                throw;
            }
        }
        //editar una metodo

        public void Actualizar(UsuarioRl usuarioRl)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Rol SET Nombre =@Nombre,Descripcion = @Descripcion, Estado = @Estado WHERE id_Rol = @id_Rol";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nombre", usuarioRl.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", usuarioRl.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", usuarioRl.Estado);
                    cmd.Parameters.AddWithValue("@id_Rol", usuarioRl.IdRol);

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
    

    

   
