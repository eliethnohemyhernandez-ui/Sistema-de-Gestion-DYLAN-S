using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioMetodo
    {
        public Repocitorio_Metodo _Repositorio;

        public ServicioMetodo()
        {
            // inyeccion de dependencia
            _Repositorio = new Repocitorio_Metodo();

        }
        public void RegistrarLista(List<Metodo> List)
        {
            //Validacion
            foreach (var metodo in List)
            {
                if (string.IsNullOrEmpty(metodo.Nombre))
                {
                    throw new Exception("Error");

                }


                // Invocamos al metodo para rejistrar la lista de categorias//
                _Repositorio.RegistrarLista(List);
            }
        }
        public List<Metodo> ObtenerList()
        {
            return _Repositorio.ObtenerLista();
        }

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA CATEGORIA
        public void EliminarPorid(int idMetodo)
        {
            //VALIDACION DE ID NEGATIVO
            if (idMetodo < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.EliminarPorid(idMetodo);
        }

        public void Actualizar(Metodo metodo)
        {
            if (string.IsNullOrEmpty(metodo.Nombre) || metodo.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Metodo y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(metodo);
        }





    }
}

    

    

