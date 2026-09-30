using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Metodo
    {
        int _id_Metodo;


        public string Nombre { get; set; }
        
        public bool Estado { get; set; }

        public int id_Metodo
        {
            get
            {
                return _id_Metodo;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdMetodo no debe de ser negativo");
                }
                _id_Metodo= value;
            }

        }
    }
}
    


    

