using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Configuracion
{
    internal class BDConexion
    {
        private static string ConnectionString = "Data Source=DESKTOP-ALEXAND;Initial Catalog=RAFLABD;Integrated Security=True;Encrypt=False";



        public static SqlConnection connect()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
