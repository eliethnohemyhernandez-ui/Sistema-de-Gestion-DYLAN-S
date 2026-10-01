using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Detalle_Compra
    {
        int _id_Detalle;
        int _id_Compra;
        int _id_Producto;

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public DateTime Fecha { get; set; }


        public int id_Detalle
        {
            get
            {
                return _id_Detalle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _id_Detalle = value;
            }


        }
        public int id_Compra
        {
            get
            {
                return _id_Compra;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _id_Compra = value;
            }

        }
        public int id_Producto
        {
            get
            {
                return _id_Producto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _id_Producto = value;
            }

        }
    }
}
 
