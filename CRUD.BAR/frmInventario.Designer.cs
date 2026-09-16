namespace CRUD.UI
{
    partial class frmInventario
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
            label9 = new Label();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCombra = new TextBox();
            txtStockActual = new TextBox();
            txtStockMinimo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            btnRegistar = new Button();
            btnVer = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(9, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 122);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 15;
            label9.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(32, 32, 32);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.ImeMode = ImeMode.Disable;
            cmbProveedor.Location = new Point(126, 119);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(318, 33);
            cmbProveedor.TabIndex = 14;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(32, 32, 32);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.ImeMode = ImeMode.Disable;
            cmbCategoria.Location = new Point(126, 39);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(318, 33);
            cmbCategoria.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(32, 32, 32);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(163, 279);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(281, 112);
            txtDescripcion.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(32, 32, 32);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(161, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 31);
            txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 279);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 199);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Marca/ Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioVenta);
            groupBox2.Controls.Add(txtPrecioCombra);
            groupBox2.Controls.Add(txtStockActual);
            groupBox2.Controls.Add(txtStockMinimo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(488, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1001, 268);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stock y Producto";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = Color.FromArgb(32, 32, 32);
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.ForeColor = Color.White;
            txtPrecioVenta.Location = new Point(618, 132);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(350, 31);
            txtPrecioVenta.TabIndex = 10;
            // 
            // txtPrecioCombra
            // 
            txtPrecioCombra.BackColor = Color.FromArgb(32, 32, 32);
            txtPrecioCombra.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioCombra.ForeColor = Color.White;
            txtPrecioCombra.Location = new Point(604, 27);
            txtPrecioCombra.Name = "txtPrecioCombra";
            txtPrecioCombra.Size = new Size(364, 31);
            txtPrecioCombra.TabIndex = 9;
            // 
            // txtStockActual
            // 
            txtStockActual.BackColor = Color.FromArgb(32, 32, 32);
            txtStockActual.BorderStyle = BorderStyle.FixedSingle;
            txtStockActual.ForeColor = Color.White;
            txtStockActual.Location = new Point(147, 138);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(295, 31);
            txtStockActual.TabIndex = 8;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.BackColor = Color.FromArgb(32, 32, 32);
            txtStockMinimo.BorderStyle = BorderStyle.FixedSingle;
            txtStockMinimo.ForeColor = Color.White;
            txtStockMinimo.Location = new Point(147, 46);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(293, 31);
            txtStockMinimo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 135);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 6;
            label7.Text = "Precio Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 144);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 5;
            label6.Text = "Stock Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 33);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 33);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 3;
            label4.Text = "Stock Minimo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnCancelar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(488, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1001, 187);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtros de Busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Goldenrod;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(707, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(50, 34);
            btnBuscar.TabIndex = 14;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(32, 32, 32);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(177, 59);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(481, 31);
            txtBuscar.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 59);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 6;
            label8.Text = "Buscar por Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(832, 111);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(832, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 491);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1298, 342);
            dataGridView1.TabIndex = 2;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.Goldenrod;
            btnRegistar.Location = new Point(1344, 523);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(112, 34);
            btnRegistar.TabIndex = 3;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Goldenrod;
            btnVer.Location = new Point(66, 841);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Goldenrod;
            btnActualizar.Location = new Point(1344, 682);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoEllipsis = true;
            btnEliminar.BackColor = Color.Goldenrod;
            btnEliminar.Location = new Point(1195, 841);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1527, 892);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVer);
            Controls.Add(btnRegistar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmInventario";
            Text = "frmInventario";
            Load += frmInventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnCancelar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Button btnRegistar;
        private Button btnVer;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCombra;
        private TextBox txtStockActual;
        private TextBox txtStockMinimo;
        private TextBox txtBuscar;
        private Label label8;
        private ComboBox cmbCategoria;
        private Label label9;
        private ComboBox cmbProveedor;
        private Button btnBuscar;
    }
}