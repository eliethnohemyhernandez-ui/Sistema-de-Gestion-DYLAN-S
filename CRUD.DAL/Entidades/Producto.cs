using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.DAL.Entidades
{
    public class Producto
    {
        //Atributos
        //Campos
        int _id_Producto;
        decimal _precio;
        int _stockDisponible;
        internal int idProveedor;


        //Propiedades autoimplementadas
        public string Nombre { get; set; }
        public int Proveedor { get; set; }
        public bool Estado { get; set; }
        public int Categoria { get; set; }
        public string contenido { get; set; }
        public string Grado { get; set; }
        public string StockMinimo { get; set; }
        public string Empresa { get; set; }
        public string NombreCategoria{ get; set; }

        //Propiedades
        public int id_Producto
        {
            get
            {
                return _id_Producto;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: Id no puede ser negativo");
                }
                _id_Producto = value;
            }
        }


        public decimal Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: Precio no puede ser negativo");
                }
                _precio = (int)value;
            }
        }

        public int StockDisponible
        {
            get
            {
                return _stockDisponible;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: Stock no debe recibir valores negativos");
                }
                _stockDisponible = value;
            }
        }



        //Metodos
        public int VerificarStockDisponible()
        {
            return _stockDisponible;
        }


        public bool ActualizarStock(int cantidad, bool accion)
        {
            bool banderaActualizacion = false;

            if (cantidad > 0)
            {
                if (accion == true)
                {
                    StockDisponible += cantidad;
                    banderaActualizacion = true;
                }
                else
                {
                    StockDisponible -= cantidad;
                    banderaActualizacion = true;
                }
            }

            return banderaActualizacion;

        }

        public bool ActualizarPrecio(decimal nuevoPrecio)
        {
            if (nuevoPrecio > _precio)
            {
                _precio = (int)nuevoPrecio;
                return true;
            }
            else
                return false;
        }

        public void Actualizar(string Nombre,  string contenido, int Categoria, decimal Precio, string Grado, int StockDisponible, string StockMinimo)
        {
            this.StockMinimo = StockMinimo;
            
            this.StockDisponible = StockDisponible;
            this.Grado = Grado;
            this.Nombre = Nombre;
            this.Categoria = Categoria;
            this.contenido = contenido;
            this.Precio = Precio;







        }

    }
}

