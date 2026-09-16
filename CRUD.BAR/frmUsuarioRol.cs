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
    public partial class frmUsuarioRol : Form
    {
        List<UsuarioRl> ListaUsuarioRolTem = new List<UsuarioRl>();
        List<UsuarioRl> ListaUsuarioRol = new List<UsuarioRl>();
        ServicioUsuarioRol _servicioUsuarioRol = new ServicioUsuarioRol();
        int indiceSeleccionado;
        public frmUsuarioRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioRl usuarioRl = new UsuarioRl();

            usuarioRl.Nombre = txtNombre.Text;
            usuarioRl.Descripcion = txtDescripcion.Text;


            if (cmbEstado.Text == "Activo")
                usuarioRl.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                usuarioRl.Estado = false;

            // Agregamos a la lista categoria
            ListaUsuarioRolTem.Add(usuarioRl);

            //Alimentar la dat griGrid con la lista proveedore
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaUsuarioRolTem;

        }

        private void frmUsuarioRol_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            cmbEstado.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListaUsuarioRol = ListaUsuarioRolTem;
            _servicioUsuarioRol.RegistrarLista(ListaUsuarioRol);

            MessageBox.Show("Registros guardados correctamente.");


            ListaUsuarioRolTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaUsuarioRol = _servicioUsuarioRol.ObtenerList();

            //Alimentar la dat griGrid con la lista proveedores
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaUsuarioRol;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de proveedores
            UsuarioRl usuarioRol = new UsuarioRl();

            usuarioRol.IdRol = ListaUsuarioRol[indiceSeleccionado].IdRol;
            usuarioRol.Nombre = txtNombre.Text;
            usuarioRol.Descripcion = txtDescripcion.Text;


            if (cmbEstado.Text == "Activo")
                usuarioRol.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                usuarioRol.Estado = false;
            // invocamos al servicio de proveedor
            _servicioUsuarioRol.Actualizar(usuarioRol);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idRol= Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdRol"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioUsuarioRol.EliminarPorid(idRol);

                // 5. Refrescamos 
                ListaUsuarioRol = _servicioUsuarioRol.ObtenerList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaUsuarioRol;

                MessageBox.Show("Registro eliminado correctamente.");
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;
            Console.WriteLine(indiceSeleccionado);

            txtNombre.Text = ListaUsuarioRol[indiceSeleccionado].Nombre.ToString();
            txtDescripcion.Text = ListaUsuarioRol[indiceSeleccionado].Descripcion.ToString();
            
            if (ListaUsuarioRol[indiceSeleccionado].Estado == true)
                cmbEstado.Text = "Activo";
            else cmbEstado.Text = "Inactivo";

        }
    }
}
