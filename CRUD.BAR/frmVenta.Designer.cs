namespace CRUD.UI
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            cbCliente = new ComboBox();
            cbPersonal = new ComboBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label9 = new Label();
            label13 = new Label();
            button3 = new Button();
            button2 = new Button();
            label8 = new Label();
            dgvDetalleVenta = new DataGridView();
            groupBox1 = new GroupBox();
            button4 = new Button();
            txtVuelto = new TextBox();
            button1 = new Button();
            label10 = new Label();
            txtMontoRecibido = new TextBox();
            label4 = new Label();
            cbMetodo = new ComboBox();
            label7 = new Label();
            txtStock = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            txtTotal = new TextBox();
            label11 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            cbProducto = new ComboBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgvDetalleVenta);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(11, -72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 849);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(32, 32, 32);
            groupBox2.Controls.Add(cbCliente);
            groupBox2.Controls.Add(cbPersonal);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtpFecha);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(601, 19);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(750, 210);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Factura";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.ItemHeight = 26;
            cbCliente.Location = new Point(213, 100);
            cbCliente.Margin = new Padding(3, 4, 3, 4);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(331, 34);
            cbCliente.TabIndex = 41;
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.ItemHeight = 26;
            cbPersonal.Location = new Point(213, 161);
            cbPersonal.Margin = new Padding(3, 4, 3, 4);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new Size(331, 34);
            cbPersonal.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 39;
            label2.Text = "Personal";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(213, 51);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(513, 32);
            dtpFecha.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(98, 106);
            label9.Name = "label9";
            label9.Size = new Size(87, 26);
            label9.TabIndex = 31;
            label9.Text = "Cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 55);
            label13.Name = "label13";
            label13.Size = new Size(175, 26);
            label13.TabIndex = 4;
            label13.Text = "Fecha de venta";
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(740, 750);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(184, 51);
            button3.TabIndex = 39;
            button3.Text = "Registrar Venta";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1024, 751);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(183, 48);
            button2.TabIndex = 38;
            button2.Text = "Facturar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(136, 15);
            label8.Name = "label8";
            label8.Size = new Size(348, 41);
            label8.TabIndex = 37;
            label8.Text = "Venta de Productos";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(600, 242);
            dgvDetalleVenta.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.RowTemplate.Height = 28;
            dgvDetalleVenta.Size = new Size(757, 481);
            dgvDetalleVenta.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(32, 32, 32);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtVuelto);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtMontoRecibido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbMetodo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbProducto);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(19, 71);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(569, 769);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la venta ";
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(204, 674);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(145, 60);
            button4.TabIndex = 42;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = false;
            // 
            // txtVuelto
            // 
            txtVuelto.BorderStyle = BorderStyle.FixedSingle;
            txtVuelto.Location = new Point(148, 597);
            txtVuelto.Margin = new Padding(3, 4, 3, 4);
            txtVuelto.Multiline = true;
            txtVuelto.Name = "txtVuelto";
            txtVuelto.ReadOnly = true;
            txtVuelto.Size = new Size(206, 44);
            txtVuelto.TabIndex = 41;
//            txtVuelto.TextChanged += txtVuelto_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(376, 674);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(170, 60);
            button1.TabIndex = 35;
            button1.Text = "Cancelar Venta";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 603);
            label10.Name = "label10";
            label10.Size = new Size(80, 26);
            label10.TabIndex = 40;
            label10.Text = "Vuelto";
            // 
            // txtMontoRecibido
            // 
            txtMontoRecibido.BorderStyle = BorderStyle.FixedSingle;
            txtMontoRecibido.Location = new Point(148, 521);
            txtMontoRecibido.Margin = new Padding(3, 4, 3, 4);
            txtMontoRecibido.Multiline = true;
            txtMontoRecibido.Name = "txtMontoRecibido";
            txtMontoRecibido.Size = new Size(206, 43);
            txtMontoRecibido.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 512);
            label4.Name = "label4";
            label4.Size = new Size(96, 52);
            label4.TabIndex = 39;
            label4.Text = "Monto \r\nrecibido";
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.ItemHeight = 26;
            cbMetodo.Location = new Point(148, 448);
            cbMetodo.Margin = new Padding(3, 4, 3, 4);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(318, 34);
            cbMetodo.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 430);
            label7.Name = "label7";
            label7.Size = new Size(97, 52);
            label7.TabIndex = 36;
            label7.Text = "Metodo \r\nde pago";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(148, 198);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(206, 44);
            txtStock.TabIndex = 34;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 204);
            label1.Name = "label1";
            label1.Size = new Size(79, 26);
            label1.TabIndex = 31;
            label1.Text = "Stock ";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(22, 674);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 60);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(148, 356);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(206, 44);
            txtTotal.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(57, 362);
            label11.Name = "label11";
            label11.Size = new Size(64, 26);
            label11.TabIndex = 7;
            label11.Text = "Total";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(148, 281);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(206, 42);
            txtPrecio.TabIndex = 32;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(148, 118);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(206, 43);
            txtCantidad.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 287);
            label6.Name = "label6";
            label6.Size = new Size(87, 26);
            label6.TabIndex = 33;
            label6.Text = "Precio ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 125);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 24;
            label5.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 51);
            label3.Name = "label3";
            label3.Size = new Size(107, 26);
            label3.TabIndex = 23;
            label3.Text = "Producto";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.ItemHeight = 26;
            cbProducto.Location = new Point(148, 47);
            cbProducto.Margin = new Padding(3, 4, 3, 4);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(342, 34);
            cbProducto.TabIndex = 10;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1439, 785);
            Controls.Add(panel1);
            Name = "frmVenta";
            Text = "frmVenta";
            Load += frmVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox cbMetodo;
        private Label label7;
        private TextBox txtStock;
        private Button btnAgregar;
        private Label label6;
        private TextBox txtPrecio;
        private Label label1;
        private ComboBox cbProducto;
        private Label label5;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        private Label label3;
        private Label label11;
        private DataGridView dgvDetalleVenta;
        private Label label8;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private DateTimePicker dtpFecha;
        private Label label9;
        private Label label13;
        private ComboBox cbPersonal;
        private Label label2;
        private TextBox txtMontoRecibido;
        private Label label4;
        private TextBox txtVuelto;
        private Label label10;
        private Button button4;
        private ComboBox cbCliente;
    }
}