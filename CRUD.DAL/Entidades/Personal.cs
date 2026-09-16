using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Personal
    {
       int _idPersonal;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public  bool Sexo {  get; set; }
        public string Correo { get; set; }

        public string CreadoPor {  get; set; }

        public int IdPersonal
            {
            get
            {
               return _idPersonal;
            }
            set
            {
               if (value < 0)
               {
                  throw new ArgumentException("Error: IdPersonal no debe de ser negativo");
               }
                  _idPersonal = value;
            }

        }
        
    }


}

