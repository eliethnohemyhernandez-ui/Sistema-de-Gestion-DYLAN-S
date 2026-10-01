using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioPersonal
    {
        public RepocitorioPersonal _Repositorio;

        public ServicioPersonal()
        {
            // inyeccion de dependencia
            _Repositorio = new RepocitorioPersonal();

        }
        public void RegistrarLista(List<Personal> List)
        {
            //Validacion
            foreach (var Personal in List)
            {
                


                // Invocamos al metodo para rejistrar la lista personal//
                _Repositorio.RegistrarLista(List);
            }
        }
        public List<Personal> ObtenerLista()
        {
            return _Repositorio.ObtenerLista();
        }

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UN personal
        public void EliminarPorid(int idPersonal)
        {
            //VALIDACION DE ID NEGATIVO
            if (idPersonal < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.EliminarPorid(idPersonal);
        }

        public void Actualizar(Personal personal)
        {
            if (string.IsNullOrEmpty(personal.Nombre) || personal.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Personal y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(personal);
        }





    }
}

    

    

