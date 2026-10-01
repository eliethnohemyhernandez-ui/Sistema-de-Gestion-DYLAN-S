using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioProducto
    {
        public void RegistrarLista(List<Producto> lista)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    foreach (var producto in lista)
                    {
                        SqlCommand cmd = new SqlCommand("sp_InsertarProducto", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Asignacion de valores a los Parametros de consusta

                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@id_Categoria", producto.Categoria);
                      //  cmd.Parameters.AddWithValue("@id_Proveedor", producto.Proveedor);
                        cmd.Parameters.AddWithValue("@Contenido", producto.contenido);
                        cmd.Parameters.AddWithValue("@GradoAlcoholico", producto.Grado);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@Stock", producto.StockDisponible);
                        cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);
                        cmd.Parameters.AddWithValue("@Estado", producto.Estado);



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

        public List<Producto> ObtenerListaActiva()
        {
            List<Producto> ListaProducto = new List<Producto>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    //Personalizar el comando
                    SqlCommand cmd = new SqlCommand("USP_ListarProducto", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var producto = new Producto()
                        {
                            id_Producto = (int)reader["id_Producto"],
                            Nombre = reader["Nombre"].ToString(),
                            Categoria = (int)reader["id_Categoria"],
                           /// Proveedor = (int)reader["id_Proveedor"],
                            contenido = reader["Contenido"].ToString(),
                            Grado = reader["GradoAlcoholico"].ToString(),
                            Precio= Convert.ToDecimal(reader["Precio"]),
                            StockDisponible = (int)reader["Stock"],
                            StockMinimo = reader["StockMinimo"].ToString(),
                            Estado = (bool)reader["Estado"],
                          //  Empresa = reader["Empresa"].ToString(),
                          //  NombreCategoria = reader["Nombre"].ToString()
                           

                        };

                        ListaProducto.Add(producto);
                    }

                    connection.Close();

                    return ListaProducto;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public List<Producto> ObtenerLista()
        //{
        //    List<Producto> ListaProducto = new List<Producto>();

        //    try
        //    {
        //        using (SqlConnection connection = BDConexion.connect())
        //        {
        //            connection.Open(); 

        //            //Personalizar el comando
        //            string query = "SELECT P.id_Producto, P.Nombre,P.Contenido,P.Precio,P.id_Categoria,P.id_Proveedor,P.Stock,P.StockMinimo,P.GradoAlcoholico,P.Estado, c.NombreCategoria, Pr.Empresa FROM Producto p INNER JOIN Categoria c ON P.id_Categoria = c.id_Categoria INNER JOIN Proveedor pr ON P.id_Proveedor = pr.id_Proveedor";
        //            SqlCommand cmd = new SqlCommand(query, connection);

        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                var producto = new Producto()
        //                {
        //                    IdProducto = (int)reader["id_Producto"],
        //                    Nombre = reader["Nombre"].ToString(),
        //                    Categoria = (int)reader["id_Categoria"],
                        //    Proveedor = (int)reader["id_Proveedor"],
                        //    contenido = reader["Contenido"].ToString(),
                        //    Grado = reader["GradoAlcoholico"].ToString(),
                        //    Precio = Convert.ToDecimal(reader["Precio"]),
                        //    StockDisponible = (int)reader["Stock"],
                        //    StockMinimo = reader["StockMinimo"].ToString(),
                        //    Estado = (bool)reader["Estado"],
                        //    NombreCategoria = reader["NombreCategoria"].ToString(),
                        //    Empresa = reader["Empresa"].ToString(),
                        //};

                        //ListaProducto.Add(producto);
        //            }

        //            connection.Close();

        //            return ListaProducto;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}



        // Eliminar 
        public void EliminarPorid(int idProducto)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();

                    string sql = "UPDATE Producto SET Estado = 0 WHERE id_Producto = @id_Producto";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Producto", idProducto);

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
        public void Actualizar(Producto producto)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();
                    string sql = "UPDATE Producto SET Nombre = @Nombre,id_Categoria = @id_Categoria,id_Proveedor = @id_Proveedor,Contenido = @Contenido,GradoAlcoholico = @GradoAlcoholico,Precio = @Precio,Stock = @StockDisponible,StockMinimo = @StockMinimo,@Estado = @Estado WHERE id_Producto = @id_Producto";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id_Producto", producto.id_Producto);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@id_Categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@id_Proveedor", producto.Proveedor);
                    cmd.Parameters.AddWithValue("@Contenido", producto.contenido);
                    cmd.Parameters.AddWithValue("@GradoAlcoholico", producto.Grado);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@StockDisponible", producto.StockDisponible);
                    cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch (Exception)
            {
                throw;

            }

        }

        public int ObtenerStock(int id_Producto)
        {
            int stock = 0;

            using (SqlConnection connection = BDConexion.connect())
            {
                using (SqlCommand cmd = new SqlCommand("USP_ObtenerStockProducto", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_Producto", id_Producto);

                    connection.Open();

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        stock = Convert.ToInt32(resultado);
                    }
                }
            }

            return stock;
        }
    }
}
    

    

