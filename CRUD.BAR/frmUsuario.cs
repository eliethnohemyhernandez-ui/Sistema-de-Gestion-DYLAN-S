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
    public partial class frmUsuario : Form
    {
        List<Usuario> ListaUsuarioTem = new List<Usuario>();
        List<Usuario> ListaUsuario = new List<Usuario>();
        ServicioUsuario _servicioUsuario = new ServicioUsuario();
        List<Usuario> ValidarUsuario = new List<Usuario>();
        ServicioUsuarioRol ServicioUsuarioRol = new ServicioUsuarioRol();
        int indiceseleccionado;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarComboboxs();
        }
        private void CargarComboboxs()
        {
            //Cargar el combobox
            cmbRol.DataSource = ServicioUsuarioRol.ObtenerList();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";






        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.id_Rol = Convert.ToInt32(cmbRol.SelectedValue);
            usuario.CreadoPor = "Jose Hernanadez";

            if (cmbEstado.Text == "Activo")
                usuario.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                usuario.Estado = false;


            // Agregamos a la lista categoria
            ListaUsuarioTem.Add(usuario);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView.DataSource = null;
            dataGridView.DataSource = ListaUsuarioTem;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            cmbEstado.Focus();
            cmbRol.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListaUsuario = ListaUsuarioTem;
            _servicioUsuario.RegistrarLista(ListaUsuario);

            MessageBox.Show("Registros guardados correctamente.");


            ListaUsuarioTem.Clear();

            // Refrescás la pantalla
            dataGridView.DataSource = null;
            dataGridView.DataSource = ListaUsuario;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idUsuario = Convert.ToInt32(dataGridView.CurrentRow.Cells["IdUsuario"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioUsuario.EliminarPorid(idUsuario);

                // 5. Refrescamos 
                ListaUsuario = _servicioUsuario.ObtenerList();
                dataGridView.DataSource = null;
                dataGridView.DataSource = ListaUsuario;

                MessageBox.Show("Registro eliminado correctamente.");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaUsuario = _servicioUsuario.ObtenerListaActiva();

            //Alimentar la dat griGrid con la lista
            dataGridView.DataSource = null;
            dataGridView.DataSource = ListaUsuario;



            dataGridView.Columns["id_Rol"].Visible = false;
            dataGridView.Columns["IdUsuario"].Visible = false;




        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de categoria
            Usuario usuario = new Usuario();

            usuario.id_Usuario = ListaUsuario[indiceseleccionado].id_Usuario;
            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.id_Rol = Convert.ToInt32(cmbRol.SelectedValue);


            if (cmbEstado.Text == "Activo")
                usuario.Estado = true;
            else if (cmbEstado.Text == "Inactivo")
                usuario.Estado = false;


            // invocamos al servicio de categoria
            _servicioUsuario.Actualizar(usuario);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceseleccionado = e.RowIndex;
            Console.WriteLine(indiceseleccionado);

            txtNombre.Text = ListaUsuario[indiceseleccionado].Nombre.ToString();
            txtCorreo.Text = ListaUsuario[indiceseleccionado].Correo.ToString();
            txtContraseña.Text = ListaUsuario[indiceseleccionado].Contraseña.ToString();
            cmbRol.Text = ListaUsuario[indiceseleccionado].id_Rol.ToString();
            if (ListaUsuario[indiceseleccionado].Estado == true)
                cmbRol.Text = "Administrador";
            else cmbRol.Text = "Personal";

            if (ListaUsuario[indiceseleccionado].Estado == true)
                cmbEstado.Text = "Activo";
            else cmbEstado.Text = "Inactivo";


        }

        private void frmUsuario_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
