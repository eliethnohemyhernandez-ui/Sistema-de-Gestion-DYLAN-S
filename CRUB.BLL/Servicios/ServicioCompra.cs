using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUB.BLL.Servicios
{
    public class ServicioCompra
    {
        private RepocitorioCompra _RepocitorioCompra;
        public ServicioCompra()
        {
            _RepocitorioCompra = new RepocitorioCompra();

        }

        public List<Detalle_Compra> ListaCompra()
        {
            RepocitorioCompra repocitorio = new RepocitorioCompra();
            return repocitorio.ObtenerLista();
        }
        public bool Registrar(Compra compra, List<Detalle_Compra> detallesCompra)
        {
            return _RepocitorioCompra.Registrar(compra, detallesCompra);
        }

    }
}


