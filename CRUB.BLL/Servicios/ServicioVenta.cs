using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUB.BLL.Servicios
{
    public class ServicioVenta
    {
        private RepositorioVenta _RepositorioVenta;
        public ServicioVenta()
        {
            _RepositorioVenta = new RepositorioVenta();

        }

        public List<DetalleVenta> ObtenerLista()
        {
            RepositorioVenta repositorio = new RepositorioVenta();
            return repositorio.ObtenerLista();
        }
        public bool Registrar(Venta venta, List<DetalleVenta> detallesVenta)
        {
            return _RepositorioVenta.Registrar(venta, detallesVenta);
        }
    }
}
