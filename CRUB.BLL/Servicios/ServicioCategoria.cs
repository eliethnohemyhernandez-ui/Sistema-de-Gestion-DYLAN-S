using System;
using System.Collections.Generic;
using System.Text;
using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
namespace CRUB.BLL.Servicios
{
    public class Serviciocategoria
    {
        public RepocitorioCategoria _Repositorio;

        public Serviciocategoria()
        {
            // inyeccion de dependencia
            _Repositorio = new RepocitorioCategoria();

        }
        public void RegistrarLista(List<Categoria> List)
        {
            
                // Invocamos al metodo para rejistrar la lista de categorias//
                _Repositorio.RegistrarLista(List);
            
        }
        public List<Categoria> ObtenerList()
        {
            return _Repositorio.ObtenerLista();
        }
        public List<Categoria> ObtenerListaActiva()
        {
            return _Repositorio.ObtenerListaActiva();
        }
        

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA DESACTIVACION DE UNA CATEGORIA
        public void DesactivarPorid(int idCtegoria)
        {
            //VALIDACION DE ID NEGATIVO
            if (idCtegoria < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repositorio.DesactivarPorid(idCtegoria);
        }

        public void Actualizar(Categoria categoria)
        {
            if(string.IsNullOrEmpty(categoria.Nombre) || categoria.Estado == null) 
            {
                throw new Exception("No se admiten valores nulos en el Nombre Categoria y estado");

            }

            // invocamos al metodo rps
            _Repositorio.Actualizar(categoria);
        }

       
        

        
    }
}

    

