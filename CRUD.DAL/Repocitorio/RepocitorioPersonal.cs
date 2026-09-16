using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioPersonal
    {
        //Registro de una lista de Personal//
        public void RegistrarLista(List<Personal> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var categoria in lista)
                    {
                        SqlCommand cmd = new SqlCommand("sp_InsertarPersonal", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;


                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido",categoria.Apellido);
                        cmd.Parameters.AddWithValue("@Estado", categoria.Estado);
                        cmd.Parameters.AddWithValue("@Sexo", categoria.Sexo);
                        cmd.Parameters.AddWithValue("@Telefono", categoria.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", categoria.Correo);
                        cmd.Parameters.AddWithValue("@Direccion", categoria.Direccion);
                        cmd.Parameters.AddWithValue("@CreadoPor", categoria.CreadoPor ?? "ADD");


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

        public List<Personal> ObtenerLista()
        {
            List<Personal> ListaPersonal = new List<Personal>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Personal WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Personal = new Personal()
                        {
                            IdPersonal = (int)reader["id_Personal"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Estado = (bool)reader["Estado"],
                            Sexo = (bool)reader["Sexo"],
                            Telefono = reader["Telefono"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Direccion = reader["Correo"].ToString(),
                        };

                        ListaPersonal.Add(Personal);
                    }

                    connection.Close();

                    return ListaPersonal;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar 
        public void EliminarPorid(int idPersonal)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Personal SET Estado = 0 WHERE id_Personal = @id_Personal";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Personal", idPersonal);

                    cmd.ExecuteNonQuery();


                    connection.Close();



                }

            }
            catch
            {
                throw;
            }
        }
        //Actualizar personal
        public void Actualizar(Personal personal)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Personal SET Nombre = @Nombre,Apellido = @Apellido,Estado = @Estado,Telefono = @Telefono,Correo = @Correo, Direccion =@Direccion  WHERE id_Personal = @id_Personal";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nombre", personal.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", personal.Apellido);
                    cmd.Parameters.AddWithValue("@Estado", personal.Estado);
                    cmd.Parameters.AddWithValue("@Telefono", personal.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", personal.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", personal.Direccion);
                    cmd.Parameters.AddWithValue("@id_Personal", personal.IdPersonal);

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
    


    

