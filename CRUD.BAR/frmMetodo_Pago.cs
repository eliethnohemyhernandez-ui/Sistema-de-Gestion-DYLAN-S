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

    public partial class frmMetodo_Pago : Form
    {
        List<Metodo> ListaMetodoTem = new List<Metodo>();
        List<Metodo> ListaMetodo = new List<Metodo>();
        ServicioMetodo _servicioMetodo = new ServicioMetodo();
        int indiceseleccionado;
        public frmMetodo_Pago()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Metodo metodo = new Metodo();

            metodo.Nombre = txtNombre.Text;


            if (cmbEstado.Text == "Activa")
                metodo.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                metodo.Estado = false;

            // Agregamos a la lista categoria
            ListaMetodoTem.Add(metodo);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaMetodoTem;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            ListaMetodo = ListaMetodoTem;
            _servicioMetodo.RegistrarLista(ListaMetodo);

            MessageBox.Show("Registros guardados correctamente.");


            ListaMetodoTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbEstado.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Metodo
            Metodo metodo = new Metodo();

            metodo.IdMetodo = ListaMetodo[indiceseleccionado].IdMetodo;
            metodo.Nombre = txtNombre.Text;


            if (cmbEstado.Text == "Activa")
                metodo.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                metodo.Estado = false;
            // invocamos al servicio de Metodo
            _servicioMetodo.Actualizar(metodo);
        }

        private void btnVerRegistro_Click(object sender, EventArgs e)
        {
            ListaMetodo = _servicioMetodo.ObtenerList();

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaMetodo;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idMetodo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdMetodo"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioMetodo.EliminarPorid(idMetodo);

                // 5. Refrescamos 
                ListaMetodo = _servicioMetodo.ObtenerList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaMetodo;

                MessageBox.Show("Registro eliminado correctamente.");
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceseleccionado = e.RowIndex;
            Console.WriteLine(indiceseleccionado);

            txtNombre.Text = ListaMetodo[indiceseleccionado].Nombre.ToString();

            if (ListaMetodo[indiceseleccionado].Estado == true)
                cmbEstado.Text = "Activa";
            else cmbEstado.Text = "Inactiva";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
