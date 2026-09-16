using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioProveedores
    {
        public RepocitorioProveedores _Repositorio;

        public ServicioProveedores()
        {
            // inyeccion de dependencia
            _Repositorio = new RepocitorioProveedores();

        }
        public void RegistrarLista(List<Proveedores> List)
        {
            //Validacion
            foreach (var Proveedores  in List)
            {
               


                // Invocamos al metodo para rejistrar la lista de Proveedores//
                _Repositorio.RegistrarLista(List);
            }
        }
        public List<Proveedores> ObtenerList()
        {
            return _Repositorio.ObtenerLista();
        }
        public List<Proveedores> ObtenerProveedoresActivos()
        {
            return _Repositorio.ObtenerListaActivo();
        }
        

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA Proveedores
        public void EliminarPorid(int idProveedor)
        {
            //VALIDACION DE ID NEGATIVO
            if (idProveedor < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.EliminarPorid(idProveedor);
        }

        public void Actualizar(Proveedores proveedores)
        {
            if (string.IsNullOrEmpty(proveedores.Nombre) || proveedores.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Proveedores y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(proveedores);
        }





    }
}

    

    

