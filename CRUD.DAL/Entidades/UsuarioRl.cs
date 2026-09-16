using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class UsuarioRl
    {
        int _idRol;


        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        
        



        public int IdRol
        {
            get
            {
                return _idRol;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdRol no debe de ser negativo");
                }
                _idRol = value;
            }

        }

    }


}


    


    

