using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Categoria
    {
        int _idCategoria;


        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string CreadoPor {  get; set; }

   

        public int IdCategoria
        {
            get
            {
                return _idCategoria;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdCategoria no debe de ser negativo");
                }
                _idCategoria = value;
            }
            
            

        }
    }
}
    

