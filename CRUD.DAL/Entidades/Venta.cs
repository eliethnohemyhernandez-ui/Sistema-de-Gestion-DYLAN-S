using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL.Entidades
{
    public class Venta
    {
        int _id_Venta;
        int _id_Cliente;
        int _id_Personal;
        int _id_Metodo;
        int _CreadoPor;

        public DateTime Fecha_venta { get; set; }
        public decimal Total { get; set; }
        public decimal Monto_Recibido { get; set; }
        public decimal Vuelto { get; set; }

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
                    throw new ArgumentException("Error");
                }
                _id_Cliente = value;
            }
        }

        public int id_Personal
        {
            get
            {
                return _id_Personal;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _id_Personal = value;
            }
        }

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
                    throw new ArgumentException("Error");
                }
                _id_Metodo = value;
            }
        }

        public int CreadoPor
        {
            get
            {
                return _CreadoPor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _CreadoPor = value;
            }
        }
    }
}

