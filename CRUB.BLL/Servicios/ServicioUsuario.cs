using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioUsuario
    {
        public Repocitorio_Usuario _Repositorio;

        public ServicioUsuario()
        {
            // inyeccion de dependencia
            _Repositorio = new Repocitorio_Usuario();

        }

        public Usuario Login(string Nombre, string Contraseña)
        {
            return _Repositorio.ValidarUsuario(Nombre, Contraseña);

        }
            
        public void RegistrarLista(List<Usuario> List)
        {
            //Validacion
            foreach (var usuario in List)
            {
              

                // Invocamos al metodo para rejistrar la lista de categorias//
                _Repositorio.RegistrarLista(List);
            }
        }
        public List<Usuario> ObtenerList()
        {
            return _Repositorio.ObtenerLista();
        }
        public List<Usuario> ObtenerListaActiva()
        {
            return _Repositorio.ObtenerListaActiva();
        }


        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA Usuario
        public void EliminarPorid(int idUsuario)
        {
            //VALIDACION DE ID NEGATIVO
            if (idUsuario < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.EliminarPorid(idUsuario);
        }

        public void Actualizar(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nombre) || usuario.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Categoria y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(usuario);
        }





    }
}

    

    

