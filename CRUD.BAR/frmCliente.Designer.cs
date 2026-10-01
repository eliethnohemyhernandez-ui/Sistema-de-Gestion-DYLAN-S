namespace CRUD.UI
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnVer = new Button();
            groupBox3 = new GroupBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            cbEstado = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            btnRegistrar = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1483, 877);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rgistro de clientes";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(933, 767);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Goldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(37, 767);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(132, 34);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(1144, 545);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(121, 34);
            btnVer.TabIndex = 6;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtNombre);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cbEstado);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnCancelar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(9, 157);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1460, 205);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 51);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 19;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(112, 48);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(373, 39);
            txtNombre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(491, 57);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cbEstado.BorderStyle = BorderStyle.FixedSingle;
            cbEstado.ForeColor = Color.White;
            cbEstado.Location = new Point(574, 49);
            cbEstado.Multiline = true;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(368, 38);
            cbEstado.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(32, 32, 32);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(1070, 49);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(368, 37);
            txtTelefono.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(994, 55);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Cedula";
            label3.Click += label3_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGoldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(808, 141);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGoldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(543, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 34);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGoldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1144, 426);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(121, 38);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(textBox1);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(9, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1460, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(288, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 18;
            label1.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1135, 53);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(392, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(719, 41);
            textBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Cedula });
            dataGridView1.Location = new Point(22, 383);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(1098, 378);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 250;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 250;
            // 
            // Cedula
            // 
            Cedula.DataPropertyName = "Cedula";
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 8;
            Cedula.Name = "Cedula";
            Cedula.Width = 250;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1579, 901);
            Controls.Add(groupBox1);
            Name = "frmCliente";
            Text = "frmCliente";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVer;
        private Button btnCancelar;
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtTelefono;
        private TextBox cbEstado;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label4;
        private Label label1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
    }
}