using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Configuracion
{
    internal class BDConexion
    {
        private static string ConnectionString = "Server=DESKTOP-FCVSIDG\\SQLEXPRESS;Database=INVT;Trusted_Connection=true;TrustServerCertificate=True";



        public static SqlConnection connect()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
