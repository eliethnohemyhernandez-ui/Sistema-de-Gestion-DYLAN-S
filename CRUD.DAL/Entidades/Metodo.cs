using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Metodo
    {
        int _idMetodo;


        public string Nombre { get; set; }
        
        public bool Estado { get; set; }

        public int IdMetodo
        {
            get
            {
                return _idMetodo;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdMetodo no debe de ser negativo");
                }
                _idMetodo= value;
            }

        }
    }
}
    


    

