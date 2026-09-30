using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepocitorioCompra
    {

        //Registro de una lista 
        public bool Registrar(Compra compra, List<Detalle_Compra> detallesCompra)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexion ala BD//
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("USP_InsertarCompra", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Asignacion de valores a los Parametros de consusta
                    cmd.Parameters.AddWithValue("@id_Proveedor", compra.id_Proveedor);
                    cmd.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                    cmd.Parameters.AddWithValue("@id_Personal", compra.id_Personal);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    //Crear un objeto de tipo Datatable
                    var tablaDetalles = new DataTable();
                    tablaDetalles.Columns.Add("id_Producto", typeof(int));
                    tablaDetalles.Columns.Add("Cantidad", typeof(int));
                    tablaDetalles.Columns.Add("PrecioUnitario", typeof(decimal));

                    foreach (var item in detallesCompra)
                    {
                        tablaDetalles.Rows.Add(item.id_Producto, item.Cantidad, item.PrecioUnitario);
                    }

                    cmd.Parameters.AddWithValue("@DetallesCompra", tablaDetalles);

                    cmd.ExecuteNonQuery();

                    var resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    connection.Close();

                    return resultado;

                }
            }
            catch (Exception)
            {
                throw;


            }
        }



        public List<Detalle_Compra> ObtenerLista()
        {
            List<Detalle_Compra> detalle_Compras = new List<Detalle_Compra>();

            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("USP_VerCompras", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Detalle_Compra detalle_Compra = new Detalle_Compra();

                        detalle_Compra.NombreProducto = reader["Producto"].ToString();
                        detalle_Compra.Cantidad = Convert.ToInt32(reader["cantidad"]);
                        detalle_Compra.PrecioUnitario = Convert.ToInt32(reader["Precio_Unitario"]);
                        detalle_Compra.Subtotal = Convert.ToDecimal(reader["Subtotal"]);
                        detalle_Compra.Fecha = Convert.ToDateTime(reader["fecha_Compra"]);






                        detalle_Compras.Add(detalle_Compra);
                    }

                    connection.Close();

                    return detalle_Compras;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
