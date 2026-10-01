using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioCliente
    {
        public RepocitorioCliente _Repocitorio;

        public ServicioCliente()
        {
            // inyeccion de dependencia
            _Repocitorio = new RepocitorioCliente();

        }
        public void RegistrarLista(List<Cliente> List)
        {
            //Validacion
            foreach (var Cliente in List)
            {
                


                // Invocamos al metodo para rejistrar la lista de categorias//
                _Repocitorio.RegistrarLista(List);
            }
        }
        public List<Cliente> ObtenerLista()
        {
            return _Repocitorio.ObtenerLista();
        }

        // VALIDACIONES DE NEGOCIO RELACIONADA A LA ELIMINACION DE UNA CATEGORIA
        public void EliminarPorid(int idCliente)
        {
            //VALIDACION DE ID NEGATIVO
            if (idCliente < 0)
                throw new ArgumentException("Error: id no debe ser negativo");

            _Repocitorio.EliminarPorid(idCliente);
        }

        public void Actualizar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre) || cliente.Telefono == null)
            {
                throw new Exception("No se admiten valores nulos en el Nombre Cliente y Apellido");

            }

            // invocamos al metodo rps
            _Repocitorio.Actualizar(cliente);
        }





    }
}

    

    

