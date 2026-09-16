namespace CRUD.UI
{
    partial class frmUsuarioRol
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
            groupPersonales = new GroupBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            cmbEstado = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnRegistrar = new Button();
            btnVer = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            groupPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupPersonales
            // 
            groupPersonales.BackColor = Color.FromArgb(32, 32, 32);
            groupPersonales.Controls.Add(btnCancelar);
            groupPersonales.Controls.Add(btnAgregar);
            groupPersonales.Controls.Add(txtDescripcion);
            groupPersonales.Controls.Add(txtNombre);
            groupPersonales.Controls.Add(cmbEstado);
            groupPersonales.Controls.Add(label3);
            groupPersonales.Controls.Add(label2);
            groupPersonales.Controls.Add(label1);
            groupPersonales.ForeColor = Color.White;
            groupPersonales.Location = new Point(16, 129);
            groupPersonales.Name = "groupPersonales";
            groupPersonales.Size = new Size(1462, 311);
            groupPersonales.TabIndex = 9;
            groupPersonales.TabStop = false;
            groupPersonales.Text = "Datos Personales";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGoldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(663, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 44);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGoldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(440, 226);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 44);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(32, 32, 32);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(941, 50);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(385, 210);
            txtDescripcion.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(116, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(408, 31);
            txtNombre.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(116, 131);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(408, 33);
            cmbEstado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(806, 52);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 471);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1053, 357);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGoldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1089, 520);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 46);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(1089, 688);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 41);
            btnVer.TabIndex = 17;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGoldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(44, 847);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(926, 847);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1462, 121);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(403, 39);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 17;
            label8.Text = "Buscar rol..";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(305, 39);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 16;
            label9.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(910, 30);
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
            textBox1.Location = new Point(389, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 41);
            textBox1.TabIndex = 13;
            // 
            // frmUsuarioRol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1490, 935);
            Controls.Add(groupBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVer);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView1);
            Controls.Add(groupPersonales);
            Name = "frmUsuarioRol";
            Text = "frmUsuarioRol";
            Load += frmUsuarioRol_Load;
            groupPersonales.ResumeLayout(false);
            groupPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupPersonales;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private ComboBox cmbEstado;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Button btnVer;
        private Button btnActualizar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private Button btnBuscar;
        private TextBox textBox1;
    }
}