using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL.Repocitorio
{
    public class RepositorioVenta
    {
        // Registrar una venta con sus detalles
        public bool Registrar(Venta venta, List<DetalleVenta> detallesVenta)
        {
            try
            {
                using (SqlConnection connection = BDConexion.connect())
                {
                    // Abrir conexión a la BD
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("USP_InsertarVenta", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asignación de valores a los parámetros
                    cmd.Parameters.AddWithValue("@Fecha_venta", venta.Fecha_venta);
                    cmd.Parameters.AddWithValue("@id_Cliente", venta.id_Cliente);
                    cmd.Parameters.AddWithValue("@id_Personal", venta.id_Personal);
                    cmd.Parameters.AddWithValue("@id_Metodo", venta.id_Metodo);
                    cmd.Parameters.AddWithValue("@Monto_Recibido", venta.Monto_Recibido);
                    cmd.Parameters.AddWithValue("@CreadoPor", venta.CreadoPor);

                    // Parámetro de resultado
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;


                    // Crear DataTable para los detalles
                    var tablaDetalles = new DataTable();

                    tablaDetalles.Columns.Add("id_Producto", typeof(int));
                    tablaDetalles.Columns.Add("Cantidad", typeof(int));
                    tablaDetalles.Columns.Add("Precio_Unitario", typeof(decimal));


                    // Agregar los detalles al DataTable
                    foreach (var item in detallesVenta)
                    {
                        tablaDetalles.Rows.Add(
                            item.id_Producto,
                            item.Cantidad,
                            item.Precio_Unitario
                        );
                    }


                    // Enviar el DataTable al procedimiento almacenado
                    SqlParameter parametroDetalles =
                        cmd.Parameters.AddWithValue("@DetallesVenta", tablaDetalles);

                    parametroDetalles.SqlDbType = SqlDbType.Structured;
                    parametroDetalles.TypeName = "DetallesVentaType";


                    // Ejecutar procedimiento
                    cmd.ExecuteNonQuery();


                    // Obtener resultado
                    var resultado =
                        Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

                    connection.Close();

                    return resultado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<DetalleVenta> ObtenerLista()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection connection = BDConexion.connect())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("USP_VerCompras", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DetalleVenta detalle = new DetalleVenta();

                    detalle.NombreProducto = reader["Producto"].ToString();
                    detalle.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    detalle.Precio_Unitario = Convert.ToDecimal(reader["precio_unitario"]);
                    detalle.Subtotal = Convert.ToDecimal(reader["subtotal"]);
                    detalle.Fecha = Convert.ToDateTime(reader["Fecha_venta"]);

                    lista.Add(detalle);
                }

                return lista;
            }
        }

    }
}
    

