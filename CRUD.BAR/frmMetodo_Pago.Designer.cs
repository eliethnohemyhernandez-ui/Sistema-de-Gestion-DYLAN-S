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
            label2 = new Label();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnVerRegistro);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1433, 743);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Metodo de Pago";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(141, 293);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbEstado.Location = new Point(141, 169);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(329, 33);
            cmbEstado.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.Black;
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
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(296, 293);
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
            btnVerRegistro.Location = new Point(663, 503);
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
            btnRegistrar.Location = new Point(1181, 503);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(781, 502);
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
            btnActualizar.Location = new Point(1299, 503);
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
            dataGridView1.Location = new Point(654, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 365);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 59);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 18;
            label2.Text = "Buscar";
            label2.Click += label2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Goldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1313, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 34);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(723, 53);
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
            Controls.Add(groupBox1);
            Name = "frmMetodo_Pago";
            Text = "frmMetodo_Pago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label2;
    }
}