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
    public partial class frmCliente : Form
    {
        List<Cliente> ListaClienteTem = new List<Cliente>();
        List<Cliente> ListaCliente = new List<Cliente>();
        ServicioCliente _servicioCliente = new ServicioCliente();
        int indiceseleccionado;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Cedula = txtCedula.Text;

            // Agregamos a la lista categoria
            ListaClienteTem.Add(cliente);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaClienteTem;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListaCliente = ListaClienteTem;
            _servicioCliente.RegistrarLista(ListaCliente);

            MessageBox.Show("Registros guardados correctamente.");


            ListaClienteTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaCliente = _servicioCliente.ObtenerList();

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaCliente;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de categoria
            Cliente cliente = new Cliente();

            cliente.IdCliente = ListaCliente[indiceseleccionado].IdCliente;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Cedula = txtCedula.Text;


            // invocamos al servicio de categoria
            _servicioCliente.Actualizar(cliente);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCliente"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioCliente.EliminarPorid(idCliente);

                // 5. Refrescamos 
                ListaCliente = _servicioCliente.ObtenerList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaCliente;

                MessageBox.Show("Registro eliminado correctamente.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
