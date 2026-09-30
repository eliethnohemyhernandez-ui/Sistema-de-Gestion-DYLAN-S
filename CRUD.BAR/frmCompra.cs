using CRUB.BLL.Servicios;
using CRUD.DAL.Entidades;
using CRUD.DAL.Repocitorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmCompra : Form
    {
        ServicioCompra _servicioCompra = new ServicioCompra();
        ServicioProducto _ServicioProducto = new ServicioProducto();
        ServicioProveedores _ServicioProveedores = new ServicioProveedores();
        ServicioPersonal _ServicioPersonal = new ServicioPersonal();

        List<Detalle_Compra> listaDetalle = new List<Detalle_Compra>();
        decimal MontoTotal = 0;

        public frmCompra()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var NuevaCantidad = Convert.ToInt32(txtCantidad.Text);
            var Precio = Convert.ToInt32(txtPrecio.Text);
            MontoTotal += NuevaCantidad * Precio;

            Detalle_Compra detalle = new Detalle_Compra();

            detalle.id_Producto = Convert.ToInt32(cmbProducto.SelectedValue);
            detalle.NombreProducto = cmbProducto.Text;
            detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalle.PrecioUnitario = Convert.ToInt32(txtPrecio.Text);
            detalle.Subtotal = NuevaCantidad * Precio;

            listaDetalle.Add(detalle);

            dvDetalleCompra.DataSource = null;
            dvDetalleCompra.DataSource = listaDetalle;

            dvDetalleCompra.Columns["idDetalle"].Visible = false;
            dvDetalleCompra.Columns["id_Producto"].Visible = false;
            dvDetalleCompra.Columns["idCompra"].Visible = false;

            dvDetalleCompra.Columns["NombreProducto"].DisplayIndex = 1;
            dvDetalleCompra.Columns["Cantidad"].DisplayIndex = 2;
            dvDetalleCompra.Columns["PrecioUnitario"].DisplayIndex = 3;
            dvDetalleCompra.Columns["Subtotal"].DisplayIndex = 4;

            txtMonto.Text = "C$" + MontoTotal;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.id_Personal = Convert.ToInt32(cmbPersonal.SelectedValue);
            compra.id_Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            compra.FechaCompra = dateTime.Value;



            var resultado = _servicioCompra.Registrar(compra, listaDetalle);

            if (resultado)
                MessageBox.Show("Compra Registrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Fallo al registrar la compra", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MontoTotal = 0;
            listaDetalle.Clear();
            dvDetalleCompra.DataSource = null;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            MontoTotal = 0;
            txtMonto.Text = "C$" + MontoTotal;
            CargarComboBoxs();
        }

        private void CargarComboBoxs()
        {
            cmbProveedor.DataSource = _ServicioProveedores.ObtenerProveedoresActivos();
            cmbProveedor.DisplayMember = "Empresa";
            cmbProveedor.ValueMember = "id_Proveedor";

            cmbProducto.DataSource = _ServicioProducto.ObtenerListaActiva();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "id_Producto";
            cmbPersonal.DataSource = _ServicioPersonal.ObtenerLista();
            cmbPersonal.DisplayMember = "Nombre";
            cmbPersonal.ValueMember = "id_Personal";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            dvDetalleCompra.DataSource = null;
            dvDetalleCompra.DataSource = _servicioCompra.ListaCompra();
            dvDetalleCompra.Columns["id_Producto"].Visible = false;
            dvDetalleCompra.Columns["id_Compra"].Visible = false;
            dvDetalleCompra.Columns["id_Detalle"].Visible = false;

        }
        

        private void dvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvDetalleCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
