using CRUD.DAL.Configuracion;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace CRUD.DAL.Repocitorio
{
    public class RepositorioInventario
    {
        public List<Inventario> ObtenerInventario()
        {
            List<Inventario> lista = new List<Inventario>();

            using(SqlConnection connection = BDConexion.connect())
            {
                connection.Open();

                     SqlCommand cmd = new SqlCommand("USP_MostrarInventario", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    lista.Add(new Inventario()
                    {
                        Producto = reader["Producto"].ToString(),
                        Precio_Unitario = Convert.ToDecimal(reader["Precio"]),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Stock_Minimo = Convert.ToInt32(reader["Stock_Minimo"]),
                        Estado = reader["EstadoStock"].ToString()


                    });
                }
                return lista;


            }


        }
    }
}
