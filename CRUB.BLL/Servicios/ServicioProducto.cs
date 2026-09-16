using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioProducto
    {
        private RepocitorioProducto _RepositorioProducto;

        public ServicioProducto()
        {
            // inyeccion de dependencia
            _RepositorioProducto = new RepocitorioProducto();

        }
        public void RegistrarLista(List<Producto> ListaProducto)
        {
           
            


                // Invocamos al metodo para rejistrar la lista de categorias//
                _RepositorioProducto.RegistrarLista(ListaProducto);
            
        }
        public List<Producto> ObtenerList()
        {
            return _RepositorioProducto.ObtenerLista();
        }
        public List<Producto> ObtenerListaActiva()
        {
            return _RepositorioProducto.ObtenerListaActiva();
        }

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA CATEGORIA
        public void EliminarPorid(int idProducto)
        {
            //VALIDACION DE ID NEGATIVO
            if (idProducto < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _RepositorioProducto.EliminarPorid(idProducto);
        }

        public void Actualizar(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre) || producto.Estado == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Producto y estado");

            }

            // invocamos al metodo rps
            _RepositorioProducto.Actualizar(producto);
        }





    }
}

    

    

