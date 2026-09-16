namespace CRUD.UI
{
    partial class frmMetodo_Pago
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
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            cmbEstado = new ComboBox();
            txtNombre = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            label1 = new Label();
            btnVerRegistro = new Button();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 354);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Metodo de Pago";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(90, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbEstado.Location = new Point(141, 169);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(329, 33);
            cmbEstado.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(147, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 31);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(373, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnVerRegistro
            // 
            btnVerRegistro.BackColor = Color.Goldenrod;
            btnVerRegistro.ForeColor = Color.Black;
            btnVerRegistro.Location = new Point(850, 695);
            btnVerRegistro.Name = "btnVerRegistro";
            btnVerRegistro.Size = new Size(112, 34);
            btnVerRegistro.TabIndex = 12;
            btnVerRegistro.Text = "Ver Registro";
            btnVerRegistro.UseVisualStyleBackColor = false;
            btnVerRegistro.Click += btnVerRegistro_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(719, 695);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Goldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1333, 685);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Goldenrod;
            btnActualizar.BackgroundImageLayout = ImageLayout.Center;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(1211, 685);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(695, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 463);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(textBox1);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1443, 153);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 18;
            label2.Text = "Buscar";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(520, 60);
            label6.Name = "label6";
            label6.Size = new Size(210, 25);
            label6.TabIndex = 17;
            label6.Text = "Buscar Metodo de Pago..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.SteelBlue;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(6, 45);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Goldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1082, 59);
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
            textBox1.Location = new Point(456, 57);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 31);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmMetodo_Pago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1467, 767);
            Controls.Add(btnRegistrar);
            Controls.Add(btnVerRegistro);
            Controls.Add(groupBox3);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmMetodo_Pago";
            Text = "frmMetodo_Pago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregar;
        private ComboBox cmbEstado;
        private TextBox txtNombre;
        private Label label3;
        private Button btnCancelar;
        private Label label1;
        private Button btnVerRegistro;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label2;
    }
}