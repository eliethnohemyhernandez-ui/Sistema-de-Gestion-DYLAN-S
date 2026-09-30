using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Cliente
    {
        int _id_Cliente;


        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public bool Estado { get; set; }

        public int id_Cliente
        {
            get
            {
                return _id_Cliente;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdCliente no debe de ser negativo");
                }
                _id_Cliente = value;
            }

        }
    }
}
    

   

