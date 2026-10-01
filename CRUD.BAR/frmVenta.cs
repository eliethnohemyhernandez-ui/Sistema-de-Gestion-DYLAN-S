using CRUB.BLL.Servicios;
using CRUD.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmVenta : Form
    {

        ServicioVenta _servicioVenta = new ServicioVenta();
        ServicioProducto _ServicioProducto = new ServicioProducto();
        ServicioCliente _ServicioCliente = new ServicioCliente();
        ServicioPersonal _ServicioPersonal = new ServicioPersonal();
        ServicioMetodo _ServicioMetodo = new ServicioMetodo();

        List<DetalleVenta> listaDetalle = new List<DetalleVenta>();

        decimal MontoTotal = 0;

        public frmVenta()
        {
            InitializeComponent();
        }


        private void frmVenta_Load(object sender, EventArgs e)
        {
            MontoTotal = 0;

            txtTotal.Text = "C$" + MontoTotal;
            txtVuelto.Text = "C$0";

            CargarComboBoxs();
        }


        private void CargarComboBoxs()
        {
            // Productos
            cbProducto.DataSource = _ServicioProducto.ObtenerListaActiva();
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "id_Producto";


            // Clientes
            cbCliente.DataSource = _ServicioCliente.ObtenerLista();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "id_Cliente";


            // Personal
            cbPersonal.DataSource = _ServicioPersonal.ObtenerLista();
            cbPersonal.DisplayMember = "Nombre";
            cbPersonal.ValueMember = "id_Personal";


            // Métodos de pago
            cbMetodo.DataSource = _ServicioMetodo.ObtenerLista();
            cbMetodo.DisplayMember = "Nombre";
            cbMetodo.ValueMember = "id_Metodo";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var NuevaCantidad = Convert.ToInt32(txtCantidad.Text);
            var Precio = Convert.ToDecimal(txtPrecio.Text);

            MontoTotal += NuevaCantidad * Precio;

            DetalleVenta detalle = new DetalleVenta();

            detalle.id_Producto = Convert.ToInt32(cbProducto.SelectedValue);
            detalle.NombreProducto = cbProducto.Text;
            detalle.Cantidad = NuevaCantidad;
            detalle.Precio_Unitario = Precio;
            detalle.Subtotal = NuevaCantidad * Precio;

            listaDetalle.Add(detalle);

            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = listaDetalle;

            // Ocultar identificadores

            dgvDetalleVenta.Columns["id_Detalle"].Visible = false;
            dgvDetalleVenta.Columns["id_Venta"].Visible = false;
            dgvDetalleVenta.Columns["id_Producto"].Visible = false;

            // Orden de columnas
            dgvDetalleVenta.Columns["NombreProducto"].DisplayIndex = 0;
            dgvDetalleVenta.Columns["Cantidad"].DisplayIndex = 1;
            dgvDetalleVenta.Columns["Precio_Unitario"].DisplayIndex = 2;
            dgvDetalleVenta.Columns["Subtotal"].DisplayIndex = 3;

            txtTotal.Text = "C$" + MontoTotal;

            txtCantidad.Clear();
        }
        private void txtMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }


        private void CalcularVuelto()
        {
            if (decimal.TryParse(txtMontoRecibido.Text, out decimal montoRecibido))
            {
                decimal vuelto = montoRecibido - MontoTotal;

                if (vuelto >= 0)
                    txtVuelto.Text = "C$" + vuelto.ToString("N2");
                else
                    txtVuelto.Text = "C$0.00";
            }
            else
            {
                txtVuelto.Text = "C$0.00";
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (listaDetalle.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto a la venta",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Venta venta = new Venta();

            venta.Fecha_venta = dtpFecha.Value;
            venta.id_Cliente = Convert.ToInt32(cbCliente.SelectedValue);
            venta.id_Personal = Convert.ToInt32(cbPersonal.SelectedValue);
            venta.id_Metodo = Convert.ToInt32(cbMetodo.SelectedValue);
            venta.Monto_Recibido = Convert.ToDecimal(txtMontoRecibido.Text);

            venta.CreadoPor = 1;

            var resultado = _servicioVenta.Registrar(venta, listaDetalle);

            if (resultado)
            {
                MessageBox.Show(
                    "Venta Registrada",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Fallo al registrar la venta",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            MontoTotal = 0;
            listaDetalle.Clear();

            dgvDetalleVenta.DataSource = null;

            txtTotal.Text = "C$" + MontoTotal;
            txtMontoRecibido.Clear();
            txtVuelto.Text = "C$0";
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento para actualizar el stock cuando se selecciona un producto
        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedValue == null)
                return;

            try
            {
                int idProducto = Convert.ToInt32(cbProducto.SelectedValue);

                int stock = _ServicioProducto.ObtenerStock(idProducto);

                txtStock.Text = stock.ToString();

                txtCantidad.Clear();
            }
            catch
            {
                txtStock.Clear();
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var NuevaCantidad = Convert.ToInt32(txtCantidad.Text);
            var Precio = Convert.ToDecimal(txtPrecio.Text);

            MontoTotal += NuevaCantidad * Precio;

            DetalleVenta detalle = new DetalleVenta();

            detalle.id_Producto = Convert.ToInt32(cbProducto.SelectedValue);
            detalle.NombreProducto = cbProducto.Text;
            detalle.Cantidad = NuevaCantidad;
            detalle.Precio_Unitario = Precio;
            detalle.Subtotal = NuevaCantidad * Precio;

            listaDetalle.Add(detalle);

            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = listaDetalle;

            // Ocultar identificadores

            dgvDetalleVenta.Columns["id_Detalle"].Visible = false;
            dgvDetalleVenta.Columns["id_Venta"].Visible = false;
            dgvDetalleVenta.Columns["id_Producto"].Visible = false;

            // Orden de columnas
            dgvDetalleVenta.Columns["NombreProducto"].DisplayIndex = 0;
            dgvDetalleVenta.Columns["Cantidad"].DisplayIndex = 1;
            dgvDetalleVenta.Columns["Precio_Unitario"].DisplayIndex = 2;
            dgvDetalleVenta.Columns["Subtotal"].DisplayIndex = 3;

            txtTotal.Text = "C$" + MontoTotal;

            txtCantidad.Clear();
        }

      
    }
}
