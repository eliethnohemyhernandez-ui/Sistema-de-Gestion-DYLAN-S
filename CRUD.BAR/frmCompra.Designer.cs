namespace CRUD.UI
{
    partial class frmCompra
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
            cmbPersonal = new ComboBox();
            txtMonto = new TextBox();
            label7 = new Label();
            label3 = new Label();
            dateTime = new DateTimePicker();
            cmbProveedor = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtPrecio = new TextBox();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dvDetalleCompra = new DataGridView();
            btnRegistrar = new Button();
            btnVer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvDetalleCompra).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPersonal);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTime);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(20, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 455);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos deCompra";
            // 
            // cmbPersonal
            // 
            cmbPersonal.BackColor = Color.FromArgb(32, 32, 32);
            cmbPersonal.ForeColor = Color.White;
            cmbPersonal.FormattingEnabled = true;
            cmbPersonal.Location = new Point(161, 160);
            cmbPersonal.Name = "cmbPersonal";
            cmbPersonal.Size = new Size(352, 33);
            cmbPersonal.TabIndex = 8;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(32, 32, 32);
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.ForeColor = Color.White;
            txtMonto.Location = new Point(325, 369);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(164, 31);
            txtMonto.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 163);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 7;
            label7.Text = "Personal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 371);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Monto Total";
            // 
            // dateTime
            // 
            dateTime.CalendarForeColor = Color.Black;
            dateTime.CalendarTitleBackColor = SystemColors.ControlText;
            dateTime.CalendarTitleForeColor = Color.White;
            dateTime.Location = new Point(161, 69);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(352, 31);
            dateTime.TabIndex = 6;
            dateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(32, 32, 32);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(161, 273);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(352, 33);
            cmbProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha Compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 273);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(774, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(731, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Compra detalle";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(135, 379);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 47);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar al detalle";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(450, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 47);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(32, 32, 32);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(208, 281);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(309, 31);
            txtPrecio.TabIndex = 7;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.FromArgb(32, 32, 32);
            cmbProducto.ForeColor = Color.White;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(208, 71);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(309, 33);
            cmbProducto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(32, 32, 32);
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(208, 177);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(309, 31);
            txtCantidad.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 281);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 5;
            label6.Text = "Precio ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 179);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 4;
            label5.Text = "Nueva Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 75);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Producto";
            // 
            // dvDetalleCompra
            // 
            dvDetalleCompra.AllowUserToAddRows = false;
            dvDetalleCompra.AllowUserToDeleteRows = false;
            dvDetalleCompra.BackgroundColor = Color.White;
            dvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDetalleCompra.Location = new Point(20, 488);
            dvDetalleCompra.Name = "dvDetalleCompra";
            dvDetalleCompra.ReadOnly = true;
            dvDetalleCompra.RowHeadersWidth = 62;
            dvDetalleCompra.Size = new Size(912, 374);
            dvDetalleCompra.TabIndex = 2;
            dvDetalleCompra.CellContentClick += dvDetalleCompra_CellContentClick;
            dvDetalleCompra.CellContentDoubleClick += dvDetalleCompra_CellContentDoubleClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1018, 551);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(159, 47);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar Compra";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Goldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(1018, 681);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(159, 47);
            btnVer.TabIndex = 11;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1527, 914);
            Controls.Add(btnVer);
            Controls.Add(dvDetalleCompra);
            Controls.Add(groupBox2);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox1);
            Name = "frmCompra";
            Text = "frmCompra";
            Load += frmCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvDetalleCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dvDetalleCompra;
        private TextBox txtCantidad;
        private ComboBox cmbProveedor;
        private ComboBox cmbProducto;
        private DateTimePicker dateTime;
        private TextBox txtMonto;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ComboBox cmbCategoria;
        private Label label7;
        private ComboBox cmbPersonal;
        private Button btnVer;
    }
}