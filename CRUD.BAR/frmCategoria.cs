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
    public class frmCategoria : Form
    {
        List<Categoria> ListaCategoriaTem = new List<Categoria>();
        List<Categoria> ListaCategoria = new List<Categoria>();
        Serviciocategoria _servicioCategoria = new Serviciocategoria();
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label4;
        private Button btnEliminar;
        private Button btnVerRegistro;
        private DataGridView dataGridView1;
        private Button btnActualizar;
        private Button btnRegistrar;

        int indiceseleccionado;
        public frmCategoria()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            cmbEstado = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            label1 = new Label();
            btnEliminar = new Button();
            btnVerRegistro = new Button();
            dataGridView1 = new DataGridView();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnVerRegistro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(txtNombreCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 868);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(325, 394);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(717, 233);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(32, 32, 32);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(429, 380);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(656, 39);
            txtBuscar.TabIndex = 13;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.FlatStyle = FlatStyle.System;
            cmbEstado.Font = new Font("Segoe UI", 9F);
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbEstado.Location = new Point(102, 147);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(364, 33);
            cmbEstado.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(772, 52);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(374, 123);
            txtDescripcion.TabIndex = 4;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.BackColor = Color.White;
            txtNombreCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCategoria.ForeColor = Color.Black;
            txtNombreCategoria.Location = new Point(102, 67);
            txtNombreCategoria.Multiline = true;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(364, 38);
            txtNombreCategoria.TabIndex = 3;
            txtNombreCategoria.TextChanged += txtNombreCategoria_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 150);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Goldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1091, 382);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(153, 37);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(662, 54);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(901, 233);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 69);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Goldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1132, 765);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVerRegistro
            // 
            btnVerRegistro.BackColor = Color.Goldenrod;
            btnVerRegistro.ForeColor = Color.Black;
            btnVerRegistro.Location = new Point(248, 755);
            btnVerRegistro.Name = "btnVerRegistro";
            btnVerRegistro.Size = new Size(112, 34);
            btnVerRegistro.TabIndex = 6;
            btnVerRegistro.Text = "Ver Registro";
            btnVerRegistro.UseVisualStyleBackColor = false;
            btnVerRegistro.Click += btnVerRegistro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 64, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 64, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 64, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(234, 457);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(1140, 292);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Goldenrod;
            btnActualizar.BackgroundImageLayout = ImageLayout.Center;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(1250, 765);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1064, 233);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(149, 46);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmCategoria
            // 
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1498, 913);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmCategoria";
            Text = " frmCategoria";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        private void button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private GroupBox groupBox1;
        private ComboBox cmbEstado;
        private TextBox txtDescripcion;
        private TextBox txtNombreCategoria;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAgregar;


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que realmente haya una fila seleccionada
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un registro de la lista.");
                return;
            }


            int idCategoria = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCategoria"].Value);


            DialogResult resultado = MessageBox.Show("¿Está seguro de desactivar el registro?", "Eliminación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {

                _servicioCategoria.EliminarPorid(idCategoria);

                // 5. Refrescamos 
                ListaCategoria = _servicioCategoria.ObtenerList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaCategoria;

                MessageBox.Show("Registro eliminado correctamente.");
            }
        }






        private void btnVerRegistro_Click(object sender, EventArgs e)
        {
            ListaCategoria = _servicioCategoria.ObtenerList();

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaCategoria;

            dataGridView1.Columns["IdCategoria"].Visible = false;






        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de categoria
            Categoria categoria = new Categoria();

            categoria.IdCategoria = ListaCategoria[indiceseleccionado].IdCategoria;
            categoria.Nombre = txtNombreCategoria.Text;
            categoria.Descripcion = txtDescripcion.Text;
            categoria.CreadoPor = "Jose Hernanadez";

            if (cmbEstado.Text == "Activa")
                categoria.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                categoria.Estado = false;
            // invocamos al servicio de categoria
            _servicioCategoria.Actualizar(categoria);


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceseleccionado = e.RowIndex;
            Console.WriteLine(indiceseleccionado);

            txtNombreCategoria.Text = ListaCategoria[indiceseleccionado].Nombre.ToString();
            txtDescripcion.Text = ListaCategoria[indiceseleccionado].Descripcion.ToString();
            if (ListaCategoria[indiceseleccionado].Estado == true)
                cmbEstado.Text = "Activa";
            else cmbEstado.Text = "Inactiva";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtNombreCategoria.Clear();
            txtDescripcion.Clear();
            cmbEstado.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.Nombre = txtNombreCategoria.Text;
            categoria.Descripcion = txtDescripcion.Text;
            categoria.CreadoPor = "Jose Hernanadez";

            if (cmbEstado.Text == "Activa")
                categoria.Estado = true;
            else if (cmbEstado.Text == "Inactiva")
                categoria.Estado = false;

            // Agregamos a la lista categoria
            ListaCategoriaTem.Add(categoria);

            //Alimentar la dat griGrid con la lista categoria
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaCategoriaTem;



        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            if (textoBusqueda == "Buscar Categoria..") textoBusqueda = "";

            
            dataGridView1.DataSource = BuscarCategoria(textoBusqueda);
        }

     
        public DataTable BuscarCategoria(string nombre)
        {
            DataTable dt = new DataTable();

            // Reemplaza con tu cadena de conexión real a SQL Server
            string conexionString = "Server=DESKTOP-FCVSIDG\\SQLEXPRESS;Database=INVT;Trusted_Connection=true;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_BuscarCategoria", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreCategoria", nombre);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListaCategoria = ListaCategoriaTem;
            _servicioCategoria.RegistrarLista(ListaCategoria);

            MessageBox.Show("Registros guardados correctamente.");


            ListaCategoriaTem.Clear();

            // Refrescás la pantalla
            dataGridView1.DataSource = null;

        }
    }
}



