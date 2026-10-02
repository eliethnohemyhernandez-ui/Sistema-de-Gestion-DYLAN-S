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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nmStockMinimo);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(btnAgreagar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnRegistra);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtGrado);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtContenido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(6, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1459, 835);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkGoldenrod;
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(1179, 618);
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
            btnVer.Location = new Point(569, 629);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(1297, 618);
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
            btnRegistra.Location = new Point(371, 778);
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
            btnAgreagar.Location = new Point(85, 778);
            btnAgreagar.Name = "btnAgreagar";
            btnAgreagar.Size = new Size(112, 34);
            btnAgreagar.TabIndex = 2;
            btnAgreagar.Text = "Agregar";
            btnAgreagar.UseVisualStyleBackColor = false;
            btnAgreagar.Click += btnAgreagar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(218, 778);
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
            label10.Location = new Point(96, 236);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 13;
            label10.Text = "Estado";
            label10.Click += label10_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.ForeColor = Color.Black;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cmbEstado.Location = new Point(190, 236);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(309, 33);
            cmbEstado.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(51, 314);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 11;
            label9.Text = "Proveedores";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.White;
            cmbProveedor.ForeColor = Color.Black;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(189, 306);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(309, 33);
            cmbProveedor.TabIndex = 10;
            // 
            // nmStockMinimo
            // 
            nmStockMinimo.BackColor = Color.White;
            nmStockMinimo.BorderStyle = BorderStyle.FixedSingle;
            nmStockMinimo.ForeColor = Color.Black;
            nmStockMinimo.Location = new Point(190, 697);
            nmStockMinimo.Name = "nmStockMinimo";
            nmStockMinimo.Size = new Size(309, 31);
            nmStockMinimo.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.ForeColor = Color.Black;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(189, 159);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(309, 33);
            cmbCategoria.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.White;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(189, 618);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(309, 31);
            txtStock.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(190, 541);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(309, 31);
            txtPrecio.TabIndex = 4;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtGrado
            // 
            txtGrado.BackColor = Color.White;
            txtGrado.BorderStyle = BorderStyle.FixedSingle;
            txtGrado.ForeColor = Color.Black;
            txtGrado.Location = new Point(189, 462);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(309, 31);
            txtGrado.TabIndex = 5;
            // 
            // txtContenido
            // 
            txtContenido.BackColor = Color.White;
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.ForeColor = Color.Black;
            txtContenido.Location = new Point(189, 383);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(309, 31);
            txtContenido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(189, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 31);
            txtNombre.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(65, 389);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 7;
            label8.Text = "Contenido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 699);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 6;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 618);
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
            label5.Location = new Point(95, 547);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 468);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "Grado %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 159);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre producto";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 32, 32);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(609, 60);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "           Buscar Producto...";
            textBox3.Size = new Size(682, 43);
            textBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(544, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(879, 451);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(535, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 12;
            label1.Text = "Buscar ";
            label1.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(1325, 69);
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
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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