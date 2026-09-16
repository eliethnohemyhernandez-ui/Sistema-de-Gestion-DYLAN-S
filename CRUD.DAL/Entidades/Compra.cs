using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Compra
    {
        int _idCompra;
        int _idProveedor;
        int _idPersonal;



        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }

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
        public int idProveedor
        {
            get
            {
                return _idProveedor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _idProveedor = value;
            }




        }
        public int idPersonal
        {
            get
            {
                return _idPersonal;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error");
                }
                _idPersonal = value;
            }

        }
    }
}