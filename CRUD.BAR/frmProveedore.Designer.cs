namespace CRUD.UI
{
    partial class frmProveedore
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmpresa = new TextBox();
            cmbEstado = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnVer = new Button();
            btnActulizar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label6 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Telefono, Empresa, Estado });
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(1158, 436);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 190;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 190;
            // 
            // Empresa
            // 
            Empresa.DataPropertyName = "Empresa";
            Empresa.HeaderText = "Empresa";
            Empresa.MinimumWidth = 8;
            Empresa.Name = "Empresa";
            Empresa.Width = 190;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.Width = 190;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(775, 45);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 144);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 4;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(775, 146);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 5;
            label5.Text = "Empresa";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(173, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(404, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(32, 32, 32);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(173, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(404, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.ForeColor = Color.White;
            txtEmpresa.Location = new Point(884, 144);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(378, 31);
            txtEmpresa.TabIndex = 9;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(884, 43);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(378, 33);
            cmbEstado.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGoldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(1318, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGoldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(1318, 119);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGoldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1217, 66);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(1217, 250);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnActulizar
            // 
            btnActulizar.BackColor = Color.DarkGoldenrod;
            btnActulizar.ForeColor = Color.Black;
            btnActulizar.Location = new Point(41, 472);
            btnActulizar.Name = "btnActulizar";
            btnActulizar.Size = new Size(112, 34);
            btnActulizar.TabIndex = 15;
            btnActulizar.Text = "Actualizar";
            btnActulizar.UseVisualStyleBackColor = false;
            btnActulizar.Click += btnActulizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1021, 472);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(30, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1487, 215);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnVer);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnActulizar);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(30, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1487, 550);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(textBox1);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(30, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1487, 121);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(238, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(382, 49);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 17;
            label6.Text = "Buscar Categoria..";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1072, 44);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(361, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(652, 31);
            textBox1.TabIndex = 13;
            // 
            // frmProveedore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1588, 935);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmProveedore";
            Text = "frmProveedore";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtEmpresa;
        private ComboBox cmbEstado;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Button btnVer;
        private Button btnActulizar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Estado;
    }
}