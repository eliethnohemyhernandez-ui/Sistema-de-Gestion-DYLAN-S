namespace CRUD.UI
{
    partial class frmPersonal
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
            btnActualizar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtDireccion = new TextBox();
            label7 = new Label();
            btnVer = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cmbEstado = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupPersonales = new GroupBox();
            label9 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGoldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(1267, 871);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGoldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(611, 104);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(180, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1199, 487);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(311, 871);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(611, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkGoldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1136, 871);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(651, 27);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(269, 31);
            txtDireccion.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(547, 33);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 1;
            label7.Text = "Direccion:";
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(180, 871);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 16;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(141, 107);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(328, 31);
            txtCorreo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(139, 39);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(330, 31);
            txtTelefono.TabIndex = 6;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(47, 105);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 2;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 42);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 1;
            label5.Text = "Telefono:";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.ForeColor = Color.White;
            rbMasculino.Location = new Point(117, 242);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(109, 29);
            rbMasculino.TabIndex = 8;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Maculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.ForeColor = Color.White;
            rbFemenino.Location = new Point(117, 207);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(115, 29);
            rbFemenino.TabIndex = 7;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(117, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(398, 31);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(116, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 31);
            txtNombre.TabIndex = 5;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(116, 168);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(399, 33);
            cmbEstado.TabIndex = 4;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 225);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 168);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(32, 32, 32);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(599, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(914, 238);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formas de  Contactos";
            // 
            // groupPersonales
            // 
            groupPersonales.BackColor = Color.FromArgb(32, 32, 32);
            groupPersonales.Controls.Add(rbMasculino);
            groupPersonales.Controls.Add(rbFemenino);
            groupPersonales.Controls.Add(txtApellido);
            groupPersonales.Controls.Add(txtNombre);
            groupPersonales.Controls.Add(cmbEstado);
            groupPersonales.Controls.Add(label4);
            groupPersonales.Controls.Add(label3);
            groupPersonales.Controls.Add(label2);
            groupPersonales.Controls.Add(label1);
            groupPersonales.ForeColor = Color.White;
            groupPersonales.Location = new Point(12, 12);
            groupPersonales.Name = "groupPersonales";
            groupPersonales.Size = new Size(569, 286);
            groupPersonales.TabIndex = 8;
            groupPersonales.TabStop = false;
            groupPersonales.Text = "Datos Personales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(333, 321);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 16;
            label9.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1026, 318);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(432, 321);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(559, 31);
            txtBuscar.TabIndex = 13;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // frmPersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1525, 991);
            Controls.Add(btnBuscar);
            Controls.Add(label9);
            Controls.Add(txtBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnVer);
            Controls.Add(groupBox2);
            Controls.Add(groupPersonales);
            Name = "frmPersonal";
            Text = "frmPersonal";
            Load += frmPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupPersonales.ResumeLayout(false);
            groupPersonales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtDireccion;
        private Label label7;
        private Button btnVer;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label1;
        private Label label6;
        private Label label5;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cmbEstado;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupPersonales;
        private Label label9;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}