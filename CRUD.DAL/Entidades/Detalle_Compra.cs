using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Detalle_Compra
    {
        int _idDetalle;
        int _idCompra;
        int _idProducto;

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public DateTime Fecha { get; set; }


        public int idDetalle
        {
            get
            {
                return _idDetalle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _idDetalle = value;
            }


        }
        public int idCompra
        {
            get
            {
                return _idCompra;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _idCompra = value;
            }

        }
        public int idProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _idProducto = value;
            }

        }
    }
}
 
