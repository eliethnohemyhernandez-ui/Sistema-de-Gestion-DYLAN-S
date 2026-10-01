using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Configuracion
{
    internal class BDConexion
    {
        private static string ConnectionString = "Data Source=localhost;Initial Catalog=RAFLABD;Integrated Security=True;Trust Server Certificate=True";




        public static SqlConnection connect()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
