using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioInventario
    {
        private RepositorioInventario _repocitorio;

        public ServicioInventario()
        {
            _repocitorio = new RepositorioInventario();
        }

        public List<Inventario> ObtenerInventario()
        {
            return _repocitorio.ObtenerInventario();
        }
}
}
