using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Inventario
    {
        int _idInventario;
       


        public string Producto { get; set; }
        public decimal Precio_Unitario { get; set; }

        public int Stock { get; set; }
        public int Stock_Minimo { get; set; }
        public string Estado { get; set; }


        public int idInventario
        {
            get
            {
                return _idInventario;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdCategoria no debe de ser negativo");
                }
                _idInventario = value;

            }


        }
    }
}