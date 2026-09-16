using CRUB.BLL.Servicios;
using CRUD.DAL.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmProveedore : Form
    {
        List<Proveedores> ListaProveedoresTem = new List<Proveedores>();
        List<Proveedores> ListaProveedores = new List<Proveedores>();
        ServicioProveedores _servicioProveedores = new ServicioProveedores();
        int indiceSeleccionado;
        public frmProveedore()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();

            proveedores.Nombre = txtNombre.Text;
            proveedores.Telefono = txtTelefono.Text;
            proveedores.Empresa = txtEmpresa.Text;
            proveedores.CreadoPor = "Jose Hernanadez";

            if (cmbEstado.Text == "Activo")
                proveedores.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                proveedores.Estado = false;

            // Agregamos a la lista categoria
            ListaProveedoresTem.Add(proveedores);

            //Alimentar la dat griGrid con la lista proveedore
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaProveedoresTem;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmpresa.Clear();
            cmbEstado.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListaProveedores = ListaProveedoresTem;
            _servicioProveedores.RegistrarLista(ListaProveedores);

            MessageBox.Show("Registros guardados correctamente.");


            ListaProveedoresTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaProveedores = _servicioProveedores.ObtenerList();

            //Alimentar la dat griGrid con la lista proveedores
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaProveedores;

            dataGridView1.Columns["IdProveedor"].Visible = false;


        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de proveedores
            Proveedores proveedores = new Proveedores();

            proveedores.IdProveedor = ListaProveedores[indiceSeleccionado].IdProveedor;
            proveedores.Nombre = txtNombre.Text;
            proveedores.Telefono = txtTelefono.Text;
            proveedores.Empresa = txtEmpresa.Text;
            proveedores.CreadoPor = "Jose Hernanadez";

            if (cmbEstado.Text == "Activo")
                proveedores.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                proveedores.Estado = false;
            // invocamos al servicio de proveedor
            _servicioProveedores.Actualizar(proveedores);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProveedor"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioProveedores.EliminarPorid(idProveedor);

                // 5. Refrescamos 
                ListaProveedores = _servicioProveedores.ObtenerList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaProveedores;

                MessageBox.Show("Registro eliminado correctamente.");
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;
            Console.WriteLine(indiceSeleccionado);

            txtNombre.Text = ListaProveedores[indiceSeleccionado].Nombre.ToString();
            txtTelefono.Text = ListaProveedores[indiceSeleccionado].Telefono.ToString();
            txtEmpresa.Text = ListaProveedores[indiceSeleccionado].Empresa.ToString();
            if (ListaProveedores[indiceSeleccionado].Estado == true)
                cmbEstado.Text = "Activo";
            else cmbEstado.Text = "Inactivo";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


        }
    }
}

