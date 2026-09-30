using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL.Entidades
{
    public class DetalleVenta
    {
        int _id_Detalle;
        int _id_Venta;
        int _id_Producto;

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
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

        public int id_Venta
        {
            get
            {
                return _id_Venta;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _id_Venta = value;
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

