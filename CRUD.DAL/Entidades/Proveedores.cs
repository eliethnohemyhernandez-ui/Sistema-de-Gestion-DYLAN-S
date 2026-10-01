using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Proveedores
    {
        int _id_Proveedor;

        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }
        public string CreadoPor { get; set; }


        public int id_Proveedor
        {
            get
            {
                return _id_Proveedor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdProveedor no debe de ser negativo");
                }
                _id_Proveedor = value;
            }

        }

    }


}

    

