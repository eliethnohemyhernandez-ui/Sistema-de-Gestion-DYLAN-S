using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Usuario
    {
        int _id_Usuario;
        
        

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public string Contraseña { get; set; }

        public int id_Rol { get; set; }
        public string NombreRol { get; set; }

        public string CreadoPor {  get; set; }











        public int id_Usuario
        {
            get
            {
                return _id_Usuario;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdUsuario no debe de ser negativo");
                }
                _id_Usuario = value;
            }



        }

    }


}


    

