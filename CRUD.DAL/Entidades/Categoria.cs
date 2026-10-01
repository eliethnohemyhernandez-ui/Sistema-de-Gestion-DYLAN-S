using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Categoria
    {
        int _id_Categoria;


        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string CreadoPor {  get; set; }

   

        public int id_Categoria
        {
            get
            {
                return _id_Categoria;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: IdCategoria no debe de ser negativo");
                }
                _id_Categoria = value;
            }
            
            

        }
    }
}
    

