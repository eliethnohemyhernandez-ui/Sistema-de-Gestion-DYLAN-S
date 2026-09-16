using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Usuario
    {
        int _idUsuario;
        
        

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public string Contraseña { get; set; }

        public int id_Rol { get; set; }
        public string NombreRol { get; set; }

        public string CreadoPor {  get; set; }











        public int IdUsuario
        {
            get
            {
                return _idUsuario;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdUsuario no debe de ser negativo");
                }
                _idUsuario = value;
            }



        }

    }


}


    

