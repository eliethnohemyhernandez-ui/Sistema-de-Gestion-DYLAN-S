using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioProveedores
    {
        //Registro de una lista de categorias//
        public void RegistrarLista(List<Proveedores> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var proveedores in lista)
                    {
                         SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;



                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
                        cmd.Parameters.AddWithValue("@Estado", proveedores.Estado);
                        cmd.Parameters.AddWithValue("@Empresa", proveedores.Empresa);
                        cmd.Parameters.AddWithValue("@CreadoPor",proveedores.CreadoPor ?? "Add");


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

        public List<Proveedores> ObtenerLista()
        {
            List<Proveedores> ListaProveedores= new List<Proveedores>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Proveedor WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Proveedores = new Proveedores()
                        {
                            IdProveedor = (int)reader["id_Proveedor"],
                            Nombre = reader["Nombre"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Empresa = reader["Empresa"].ToString(),
                            Estado = (bool)reader["Estado"],
                            CreadoPor = reader["CreadoPor"].ToString(),
                        };

                        ListaProveedores.Add(Proveedores);
                    }

                    connection.Close();

                    return ListaProveedores;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Proveedores> ObtenerListaActivo()
        {
            List<Proveedores> ListaProveedores = new List<Proveedores>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Proveedor WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Proveedores = new Proveedores()
                        {
                            IdProveedor = (int)reader["id_Proveedor"],
                            Nombre = reader["Nombre"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Empresa = reader["Empresa"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };

                        ListaProveedores.Add(Proveedores);
                    }

                    connection.Close();

                    return ListaProveedores;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Eliminar 
        public void EliminarPorid(int idProveedor)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Proveedor SET Estado = 0 WHERE id_Proveedor = @id_Proveedor";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Proveedor", idProveedor);

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
        public void Actualizar(Proveedores proveedores)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Proveedor SET Nombre =@Nombre,Telefono = @Telefono,Empresa = @Empresa, Estado = @Estado WHERE id_Proveedor = @id_Proveedor";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
                    cmd.Parameters.AddWithValue("@Empresa", proveedores.Empresa);
                    cmd.Parameters.AddWithValue("@Estado", proveedores.Estado);
                    cmd.Parameters.AddWithValue("@id_Proveedor", proveedores.IdProveedor);

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
    

    

