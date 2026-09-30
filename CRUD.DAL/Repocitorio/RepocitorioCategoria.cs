using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
                        SqlCommand cmd = new SqlCommand("USP_AgregarCategoria", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
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
                    SqlCommand cmd = new SqlCommand("USP_VerCategoria", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var categoria = new Categoria()
                        {
                            id_Categoria = (int)reader["id_Categoria"],
                            Nombre = reader["Nombre"].ToString(),
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
                            id_Categoria = (int)reader["id_Categoria"],
                            Nombre = reader["Nombre"].ToString(),
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

        // Desactivar 
        public void DesactivarPorid(int idCategoria)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("USP_DesactivarCategoria", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_Categoria", idCategoria);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
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
                    SqlCommand cmd = new SqlCommand("USP_EditarCategoria", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                    cmd.Parameters.AddWithValue("@id_Categoria", categoria.id_Categoria);

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
    

