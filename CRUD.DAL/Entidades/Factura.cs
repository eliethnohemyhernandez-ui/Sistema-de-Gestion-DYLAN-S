using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Factura
    {
        int _idFactura;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public bool Sexo { get; set; }
        public string Correo { get; set; }

        public int IdPersonal
        {
            get
            {
                return _idFactura;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdPersonal no debe de ser negativo");
                }
                _idFactura = value;
            }

        }

    }


}
    

