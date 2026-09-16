using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioCategoria
    {
        //Registro de una lista de categorias//
        public void RegistrarLista(List<Categoria> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var categoria in lista)
                    {
                        SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@NombreCategoria", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                        cmd.Parameters.AddWithValue("@CreadoPor", categoria.CreadoPor ?? "Add");
                       
                       

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

        public List<Categoria> ObtenerListaActiva()
        {
            List<Categoria> ListaCategorias = new List<Categoria>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Categoria WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var categoria = new Categoria()
                        {
                            IdCategoria = (int)reader["id_Categoria"],
                            Nombre = reader["NombreCategoria"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"],
                            CreadoPor = reader["CreadoPor"].ToString(),
                        };

                        ListaCategorias.Add(categoria);
                    }

                    connection.Close();

                    return ListaCategorias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Categoria> ObtenerLista()
        {
            List<Categoria> ListaCategorias = new List<Categoria>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Categoria WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var categoria = new Categoria()
                        {
                            IdCategoria = (int)reader["id_Categoria"],
                            Nombre = reader["NombreCategoria"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"],
                            CreadoPor = reader["CreadoPor"].ToString(),
                        };

                        ListaCategorias.Add(categoria);
                    }

                    connection.Close();

                    return ListaCategorias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar 
        public void EliminarPorid(int idCategoria)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Categoria SET Estado = 0 WHERE id_Categoria = @id_Categoria";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Categoria",idCategoria);

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
        public void Actualizar(Categoria categoria)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Categoria SET NombreCategoria =@NombreCategoria,Descripcion = @Descripcion,Estado = @Estado WHERE id_Categoria = @id_Categoria";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@NombreCategoria", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                    cmd.Parameters.AddWithValue("@id_Categoria", categoria.IdCategoria);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch(Exception) 
            {
                throw;
            
            }

        }
    }
}
    

