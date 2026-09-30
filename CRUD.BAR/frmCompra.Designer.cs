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
            dvDetalleCompra = new DataGridView();
            btnCancelar = new Button();
            btnVer = new Button();
            btnAgregar = new Button();
            btnRegistrar = new Button();
            label5 = new Label();
            label6 = new Label();
            cmbPersonal = new ComboBox();
            cmbProducto = new ComboBox();
            txtPrecio = new TextBox();
            txtMonto = new TextBox();
            txtCantidad = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            dateTime = new DateTimePicker();
            cmbProveedor = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvDetalleCompra).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvDetalleCompra);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbPersonal);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTime);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1417, 858);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Compra";
            // 
            // dvDetalleCompra
            // 
            dvDetalleCompra.AllowUserToAddRows = false;
            dvDetalleCompra.AllowUserToDeleteRows = false;
            dvDetalleCompra.BackgroundColor = Color.White;
            dvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvDetalleCompra.Location = new Point(557, 377);
            dvDetalleCompra.Name = "dvDetalleCompra";
            dvDetalleCompra.ReadOnly = true;
            dvDetalleCompra.RowHeadersWidth = 62;
            dvDetalleCompra.Size = new Size(821, 324);
            dvDetalleCompra.TabIndex = 2;
            dvDetalleCompra.CellContentClick += dvDetalleCompra_CellContentClick;
            dvDetalleCompra.CellContentDoubleClick += dvDetalleCompra_CellContentDoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(359, 509);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 47);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar Compra";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Goldenrod;
            btnVer.ForeColor = Color.Black;
            btnVer.Location = new Point(359, 601);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(159, 41);
            btnVer.TabIndex = 11;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(1031, 283);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(225, 45);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar al detalle";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(1208, 721);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(159, 47);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar Compra";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(816, 135);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 4;
            label5.Text = "Nueva Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(889, 187);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 5;
            label6.Text = "Precio ";
            // 
            // cmbPersonal
            // 
            cmbPersonal.BackColor = Color.White;
            cmbPersonal.ForeColor = Color.Black;
            cmbPersonal.FormattingEnabled = true;
            cmbPersonal.Location = new Point(192, 206);
            cmbPersonal.Name = "cmbPersonal";
            cmbPersonal.Size = new Size(352, 33);
            cmbPersonal.TabIndex = 8;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.White;
            cmbProducto.ForeColor = Color.Black;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(960, 66);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(348, 33);
            cmbProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(960, 198);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(352, 33);
            txtPrecio.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.White;
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.ForeColor = Color.Black;
            txtMonto.Location = new Point(183, 327);
            txtMonto.Multiline = true;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(183, 64);
            txtMonto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.White;
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.ForeColor = Color.Black;
            txtCantidad.Location = new Point(960, 134);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(348, 31);
            txtCantidad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(869, 66);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 206);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 7;
            label7.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 343);
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
            dateTime.Location = new Point(192, 69);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(352, 31);
            dateTime.TabIndex = 6;
            dateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.White;
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(192, 136);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(352, 33);
            cmbProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 69);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha Compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 140);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1527, 914);
            Controls.Add(groupBox1);
            Name = "frmCompra";
            Text = "frmCompra";
            Load += frmCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvDetalleCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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