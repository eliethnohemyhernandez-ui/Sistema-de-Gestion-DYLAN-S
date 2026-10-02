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
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Telefono, Empresa, Estado });
            dataGridView1.Location = new Point(219, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(1141, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
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
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(173, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(404, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(173, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(404, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = Color.White;
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.ForeColor = Color.Black;
            txtEmpresa.Location = new Point(884, 144);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(378, 31);
            txtEmpresa.TabIndex = 9;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.ForeColor = Color.Black;
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
            btnCancelar.BackColor = Color.Silver;
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
            btnRegistrar.Location = new Point(1248, 760);
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
            btnVer.Location = new Point(219, 760);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(dataGridView1);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1487, 879);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(381, 252);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 18;
            label2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1135, 247);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(455, 250);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(652, 31);
            textBox1.TabIndex = 13;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 270;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 270;
            // 
            // Empresa
            // 
            Empresa.DataPropertyName = "Empresa";
            Empresa.HeaderText = "Empresa";
            Empresa.MinimumWidth = 8;
            Empresa.Name = "Empresa";
            Empresa.Width = 270;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.Width = 270;
            // 
            // frmProveedore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1588, 935);
            Controls.Add(groupBox1);
            Name = "frmProveedore";
            Text = "frmProveedore";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Estado;
    }
}