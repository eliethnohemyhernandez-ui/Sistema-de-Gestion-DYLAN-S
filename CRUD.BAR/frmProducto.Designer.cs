namespace CRUD.UI
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnActualizar = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            btnRegistra = new Button();
            btnAgreagar = new Button();
            btnLimpiar = new Button();
            label10 = new Label();
            cmbEstado = new ComboBox();
            label9 = new Label();
            cmbProveedor = new ComboBox();
            nmStockMinimo = new NumericUpDown();
            cmbCategoria = new ComboBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtGrado = new TextBox();
            txtContenido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnRegistra);
            groupBox1.Controls.Add(btnAgreagar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(nmStockMinimo);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtGrado);
            groupBox1.Controls.Add(txtContenido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 831);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGoldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(359, 552);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkGoldenrod;
            btnVer.ForeColor = SystemColors.ActiveCaptionText;
            btnVer.Location = new Point(191, 708);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkGoldenrod;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(220, 597);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistra
            // 
            btnRegistra.BackColor = Color.DarkGoldenrod;
            btnRegistra.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistra.Location = new Point(334, 719);
            btnRegistra.Name = "btnRegistra";
            btnRegistra.Size = new Size(112, 34);
            btnRegistra.TabIndex = 4;
            btnRegistra.Text = "Registrar";
            btnRegistra.UseVisualStyleBackColor = false;
            btnRegistra.Click += btnRegistra_Click;
            // 
            // btnAgreagar
            // 
            btnAgreagar.BackColor = Color.DarkGoldenrod;
            btnAgreagar.ForeColor = Color.Black;
            btnAgreagar.Location = new Point(83, 759);
            btnAgreagar.Name = "btnAgreagar";
            btnAgreagar.Size = new Size(112, 34);
            btnAgreagar.TabIndex = 2;
            btnAgreagar.Text = "Agregar";
            btnAgreagar.UseVisualStyleBackColor = false;
            btnAgreagar.Click += btnAgreagar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGoldenrod;
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(298, 759);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(42, 220);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 13;
            label10.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(32, 32, 32);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbEstado.Location = new Point(145, 217);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(333, 33);
            cmbEstado.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 309);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 11;
            label9.Text = "Proveedores";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(32, 32, 32);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(141, 309);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(333, 33);
            cmbProveedor.TabIndex = 10;
            // 
            // nmStockMinimo
            // 
            nmStockMinimo.BackColor = Color.FromArgb(32, 32, 32);
            nmStockMinimo.BorderStyle = BorderStyle.FixedSingle;
            nmStockMinimo.ForeColor = Color.White;
            nmStockMinimo.Location = new Point(289, 646);
            nmStockMinimo.Name = "nmStockMinimo";
            nmStockMinimo.Size = new Size(191, 31);
            nmStockMinimo.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(32, 32, 32);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(144, 136);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(333, 33);
            cmbCategoria.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(32, 32, 32);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(42, 637);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(188, 31);
            txtStock.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(32, 32, 32);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(289, 515);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(189, 31);
            txtPrecio.TabIndex = 4;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.FromArgb(32, 32, 32);
            txtGrado.BorderStyle = BorderStyle.FixedSingle;
            txtGrado.ForeColor = Color.White;
            txtGrado.Location = new Point(42, 512);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(188, 31);
            txtGrado.TabIndex = 5;
            // 
            // txtContenido
            // 
            txtContenido.BackColor = Color.FromArgb(32, 32, 32);
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.ForeColor = Color.White;
            txtContenido.Location = new Point(138, 387);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(333, 31);
            txtContenido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(191, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 31);
            txtNombre.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 379);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 7;
            label8.Text = "Contenido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(289, 607);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 6;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 597);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 5;
            label6.Text = "Stock Actual";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(289, 487);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 472);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "Grado %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 139);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 59);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre producto";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 32, 32);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(574, 385);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "           Buscar Producto...";
            textBox3.Size = new Size(609, 43);
            textBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(526, 446);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(915, 339);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(560, 357);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 12;
            label1.Text = "Buscar Producto.";
            label1.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(1212, 402);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1587, 856);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            ForeColor = Color.Black;
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCodigo;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtContenido;
        private TextBox txtGrado;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private NumericUpDown nmStockMinimo;
        private ComboBox cmbCategoria;
        private Button btnAgreagar;
        private Button btnLimpiar;
        private Label label9;
        private ComboBox cmbProveedor;
        private ComboBox cmbEstado;
        private Label label10;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnVer;
        private Button btnEliminar;
        private Button btnRegistra;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Label label1;
    }
}