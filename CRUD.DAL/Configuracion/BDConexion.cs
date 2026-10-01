using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Configuracion
{
    internal class BDConexion
    {
<<<<<<< HEAD
        private static string ConnectionString = "Data Source=localhost;Initial Catalog=RAFLABD;Integrated Security=True;Trust Server Certificate=True";

=======
        private static string ConnectionString = "Data Source=DESKTOP-ALEXAND;Initial Catalog=RAFLABD;Integrated Security=True;Encrypt=False";
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5



        public static SqlConnection connect()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
