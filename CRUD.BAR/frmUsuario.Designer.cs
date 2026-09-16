namespace CRUD.UI
{
    partial class frmUsuario
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
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            groupPersonales = new GroupBox();
            cmbRol = new ComboBox();
            btnAgregar = new Button();
            label5 = new Label();
            btnCancelar = new Button();
            txtContraseña = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            cmbEstado = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVer = new Button();
            btnRegistrar = new Button();
            dataGridView = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            Nombre = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            id_Rol = new DataGridViewTextBoxColumn();
            CreadoPor = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(356, 50);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 17;
            label8.Text = "Buscar Categoria..";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(262, 50);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 16;
            label9.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(346, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(659, 41);
            textBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1495, 113);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultas";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1028, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // groupPersonales
            // 
            groupPersonales.BackColor = Color.FromArgb(32, 32, 32);
            groupPersonales.Controls.Add(cmbRol);
            groupPersonales.Controls.Add(btnAgregar);
            groupPersonales.Controls.Add(label5);
            groupPersonales.Controls.Add(btnCancelar);
            groupPersonales.Controls.Add(txtContraseña);
            groupPersonales.Controls.Add(label4);
            groupPersonales.Controls.Add(txtCorreo);
            groupPersonales.Controls.Add(txtNombre);
            groupPersonales.Controls.Add(cmbEstado);
            groupPersonales.Controls.Add(label3);
            groupPersonales.Controls.Add(label2);
            groupPersonales.Controls.Add(label1);
            groupPersonales.ForeColor = Color.White;
            groupPersonales.Location = new Point(12, 131);
            groupPersonales.Name = "groupPersonales";
            groupPersonales.Size = new Size(1495, 312);
            groupPersonales.TabIndex = 19;
            groupPersonales.TabStop = false;
            groupPersonales.Text = "Datos Personales";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(32, 32, 32);
            cmbRol.ForeColor = Color.White;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Personal" });
            cmbRol.Location = new Point(599, 164);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(358, 33);
            cmbRol.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGoldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(481, 249);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(527, 172);
            label5.Name = "label5";
            label5.Size = new Size(37, 25);
            label5.TabIndex = 9;
            label5.Text = "Rol";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGoldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(784, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(32, 32, 32);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(1116, 56);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(358, 31);
            txtContraseña.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(1009, 58);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(32, 32, 32);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(599, 50);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(358, 31);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += txtApellido_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(98, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 31);
            txtNombre.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(98, 164);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(358, 33);
            cmbEstado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 167);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(527, 52);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(1352, 652);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 25;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGoldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1352, 500);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.Menu;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Nombre, Contraseña, Correo, Estado, id_Rol, CreadoPor });
            dataGridView.Location = new Point(22, 474);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1299, 343);
            dataGridView.TabIndex = 22;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            dataGridView.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1184, 823);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGoldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(22, 823);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 26;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 8;
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            Contraseña.Width = 150;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
            // 
            // id_Rol
            // 
            id_Rol.DataPropertyName = "id_Rol";
            id_Rol.HeaderText = "id_Rol";
            id_Rol.MinimumWidth = 8;
            id_Rol.Name = "id_Rol";
            id_Rol.ReadOnly = true;
            id_Rol.Width = 150;
            // 
            // CreadoPor
            // 
            CreadoPor.DataPropertyName = "CreadoPor";
            CreadoPor.HeaderText = "CreadoPor";
            CreadoPor.MinimumWidth = 8;
            CreadoPor.Name = "CreadoPor";
            CreadoPor.ReadOnly = true;
            CreadoPor.Width = 150;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1600, 862);
            Controls.Add(groupBox1);
            Controls.Add(groupPersonales);
            Controls.Add(btnVer);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            DoubleClick += frmUsuario_DoubleClick;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupPersonales.ResumeLayout(false);
            groupPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private GroupBox groupPersonales;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private ComboBox cmbEstado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVer;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnRegistrar;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnActualizar;
        private ComboBox cmbRol;
        private Label label5;
        private TextBox txtContraseña;
        private Label label4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn id_Rol;
        private DataGridViewTextBoxColumn CreadoPor;
    }
}