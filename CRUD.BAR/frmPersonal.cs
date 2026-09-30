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
    public partial class frmPersonal : Form
    {
        List<Personal> ListaPersonalTem = new List<Personal>();
        List<Personal> ListaPersonal = new List<Personal>();
        ServicioPersonal _servicioPersonal = new ServicioPersonal();
        int indiceSeleccionado;
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();

            personal.Nombre = txtNombre.Text;
            personal.Apellido = txtApellido.Text;
            personal.Telefono = txtTelefono.Text;
            personal.Correo = txtCorreo.Text;
            personal.Direccion = txtDireccion.Text;

            if (cmbEstado.Text == "Activo")
                personal.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                personal.Estado = false;



            // Agregamos a la lista categoria
            ListaPersonalTem.Add(personal);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaPersonalTem;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            ListaPersonal = ListaPersonalTem;
            _servicioPersonal.RegistrarLista(ListaPersonal);

            MessageBox.Show("Registros guardados correctamente.");


            ListaPersonalTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaPersonal = _servicioPersonal.ObtenerLista();

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaPersonal;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Personal
            Personal personal = new Personal();

            personal.id_Personal = ListaPersonal[indiceSeleccionado].id_Personal;
            personal.Nombre = txtNombre.Text;
            personal.Apellido = txtApellido.Text;
            personal.Telefono = txtTelefono.Text;
            personal.Correo = txtCorreo.Text;
            personal.Direccion = txtDireccion.Text;

            if (cmbEstado.Text == "Activo")
                personal.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                personal.Estado = false;


            // invocamos al servicio de Personl
            _servicioPersonal.Actualizar(personal);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idPersonal = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdPersonal"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioPersonal.EliminarPorid(idPersonal);

                // 5. Refrescamos 
                ListaPersonal = _servicioPersonal.ObtenerLista();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaPersonal;

                MessageBox.Show("Registro eliminado correctamente.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            cmbEstado.Focus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;
            Console.WriteLine(indiceSeleccionado);

            txtNombre.Text = ListaPersonal[indiceSeleccionado].Nombre.ToString();
            txtApellido.Text = ListaPersonal[indiceSeleccionado].Apellido.ToString();
            txtTelefono.Text = ListaPersonal[indiceSeleccionado].Telefono.ToString();
            txtCorreo.Text = ListaPersonal[indiceSeleccionado].Correo.ToString();
            txtDireccion.Text = ListaPersonal[indiceSeleccionado].Direccion.ToString();

            if (ListaPersonal[indiceSeleccionado].Estado == true)
                cmbEstado.Text = "Activo";
            else cmbEstado.Text = "Inactivo";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { 
        
        }

            
    }
}
        
    


