using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Cliente
    {
        int _idCliente;


        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public string Cedula { get; set; }

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdCliente no debe de ser negativo");
                }
                _idCliente = value;
            }

        }
    }
}
    

   

