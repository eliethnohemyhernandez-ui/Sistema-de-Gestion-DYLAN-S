using CRUB.BLL.Servicios;
using CRUD.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmProducto : Form
    {
        List<Producto> ListaProductoTem = new List<Producto>();
        List<Producto> ListaProducto = new List<Producto>();
        ServicioProducto _servicioProducto = new ServicioProducto();


        int indiceseleccionado;
        Serviciocategoria _serviciocategoria = new Serviciocategoria();
        ServicioProveedores _servicioProveedores = new ServicioProveedores();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CargarComboboxs();


        }
        private void CargarComboboxs()
        {
            //Cargar el combobox
            cmbCategoria.DataSource = _serviciocategoria.ObtenerListaActiva();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "id_Categoria";


            //Cargar el cmb Proveedor
            cmbProveedor.DataSource = _servicioProveedores.ObtenerProveedoresActivos();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "id_Proveedor";




        }

        private void label6_Click(object sender, EventArgs e)
        {


        }




        private void btnAgreagar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();


            producto.Nombre = txtNombre.Text;
            producto.Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            producto.Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            producto.contenido = txtContenido.Text;
            producto.Grado = txtGrado.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.StockDisponible = Convert.ToInt32(txtStock.Text);
            producto.StockMinimo = (nmStockMinimo.Text);




            if (cmbEstado.Text == "Activa")
                producto.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                producto.Estado = false;

            // Agregamos a la lista categoria
            ListaProductoTem.Add(producto);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaProductoTem;

        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbCategoria.Focus();
            cmbProveedor.Focus();
            txtContenido.Clear();
            txtGrado.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            nmStockMinimo.Focus();


        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            if (ListaProductoTem.Count == 0)
            {
                MessageBox.Show("No hay Productos en la lista para registrar.");

            }
            try
            {
                _servicioProducto.RegistrarLista(ListaProductoTem);

                MessageBox.Show("Registros guardados Correctamente");

                ListaProductoTem.Clear();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaProductoTem;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message);

            }

        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaProducto = _servicioProducto.ObtenerListaActiva();

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaProducto;

            dataGridView1.Columns["NombreCategoria"].Visible = true;
            dataGridView1.Columns["Empresa"].Visible = true;
            dataGridView1.Columns["id_Producto"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;
            dataGridView1.Columns["Proveedor"].Visible = false;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de categoria
            Producto producto = new Producto();

            producto.id_Producto = ListaProducto[indiceseleccionado].id_Producto;

            producto.Nombre = txtNombre.Text;
            producto.Categoria = (int)cmbCategoria.SelectedValue;
            producto.Proveedor = (int)cmbProveedor.SelectedValue;
            producto.contenido = txtContenido.Text;
            producto.Grado = txtGrado.Text;
            producto.Precio = Convert.ToInt32(txtPrecio.Text);
            producto.StockDisponible = Convert.ToInt32(txtStock.Text);
            producto.StockMinimo = (nmStockMinimo.Text);


            if (cmbEstado.Text == "Activa")
                producto.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                producto.Estado = false;
            // invocamos al servicio de categoria
            _servicioProducto.Actualizar(producto);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioProducto.EliminarPorid(idProducto);

                // 5. Refrescamos 
                ListaProducto = _servicioProducto.ObtenerListaActiva();
                dataGridView1.DataSource = null;


                MessageBox.Show("Registro eliminado correctamente.");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceseleccionado = e.RowIndex;
            Console.WriteLine(indiceseleccionado);

            txtNombre.Text = ListaProducto[indiceseleccionado].Nombre.ToString();
            cmbCategoria.SelectedValue = Convert.ToInt32(ListaProducto[indiceseleccionado].Categoria);
            cmbProveedor.SelectedValue = Convert.ToInt32(ListaProducto[indiceseleccionado].Proveedor);
            txtContenido.Text = ListaProducto[indiceseleccionado].contenido.ToString();
            txtPrecio.Text = ListaProducto[indiceseleccionado].Precio.ToString();
            txtStock.Text = ListaProducto[indiceseleccionado].StockDisponible.ToString();
            nmStockMinimo.Text = ListaProducto[indiceseleccionado].StockMinimo.ToString();
            txtGrado.Text = ListaProducto[indiceseleccionado].Grado.ToString();

            if (ListaProducto[indiceseleccionado].Estado == true)
                cmbEstado.Text = "Activo";
            else cmbEstado.Text = "Inactivo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
