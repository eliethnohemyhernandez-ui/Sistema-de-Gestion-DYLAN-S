using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class Repocitorio_Metodo
    {
        //Registro de una lista de Metodo//
        public void RegistrarLista(List<Metodo> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var metodo in lista)
                    {
                        //Personalizar el Comando a enviar a la BD
                        string sql = "INSERT INTO Metodo_Pago (Nombre,Estado)VALUES(@Nombre,@Estado)";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        // Asignacion de valores a los Parametros de consusta
                        cmd.Parameters.AddWithValue("@Nombre", metodo.Nombre);
                        cmd.Parameters.AddWithValue("@Estado", metodo.Estado);


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

        public List<Metodo> ObtenerLista()
        {
            List<Metodo> ListaMetodo = new List<Metodo>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    string sql = "SELECT * FROM Metodo_Pago WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var metodo = new Metodo()
                        {
                            id_Metodo = (int)reader["id_Metodo"],
                            Nombre = reader["Nombre"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };

                        ListaMetodo.Add(metodo);
                    }

                    connection.Close();

                    return ListaMetodo;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Eliminar 
        public void EliminarPorid(int idMetodo)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Metodo_Pago SET Estado = 0 WHERE id_Metodo = @id_Metodo";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Metodo", idMetodo);

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

        public void Actualizar(Metodo metodo)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Metodo_Pago SET Nombre =@Nombre,Estado = @Estado WHERE id_Metodo = @id_Metodo";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@Nombre", metodo.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", metodo.Estado);
                    cmd.Parameters.AddWithValue("@id_Metodo",metodo.id_Metodo);

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
    

    

