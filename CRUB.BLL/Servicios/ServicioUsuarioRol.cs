using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioUsuarioRol
    {
        public RepocitorioUsuarioRol _Repositorio;

        public ServicioUsuarioRol()
        {
            // inyeccion de dependencia
            _Repositorio = new RepocitorioUsuarioRol();

        }
        public void RegistrarLista(List<UsuarioRl> List)
        {
            //Validacion
            foreach (var usuarioRl in List)
            {
                if (string.IsNullOrEmpty(usuarioRl.Nombre))
                {
                    throw new Exception("Error");

                }


                // Invocamos al metodo para rejistrar la lista de categorias//
                _Repositorio.RegistrarLista(List);
            }
        }
        public List<UsuarioRl> ObtenerList()
        {
            return _Repositorio.ObtenerLista();
        }

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA CATEGORIA
        public void EliminarPorid(int idRol)
        {
            //VALIDACION DE ID NEGATIVO
            if (idRol < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.EliminarPorid(idRol);
        }

        public void Actualizar(UsuarioRl usuarioRl)
        {
            if (string.IsNullOrEmpty(usuarioRl.Nombre) || usuarioRl.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Metodo y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(usuarioRl);
        }





    }
}

    

    

    

