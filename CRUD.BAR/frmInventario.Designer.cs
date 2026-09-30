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
            dataGridView1 = new DataGridView();
            btnVer = new Button();
            btnActualizar = new Button();
            BusquedaInventario = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            Producto = new DataGridViewTextBoxColumn();
            Precio_Unitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Stock_Minimo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio_Unitario, Stock, Stock_Minimo, Estado });
            dataGridView1.Location = new Point(73, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1315, 539);
            dataGridView1.TabIndex = 2;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Goldenrod;
            btnVer.Location = new Point(67, 705);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 34);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Goldenrod;
            btnActualizar.Location = new Point(1339, 705);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // BusquedaInventario
            // 
            BusquedaInventario.BackColor = Color.FromArgb(32, 32, 32);
            BusquedaInventario.ForeColor = Color.White;
            BusquedaInventario.Location = new Point(351, 48);
            BusquedaInventario.Multiline = true;
            BusquedaInventario.Name = "BusquedaInventario";
            BusquedaInventario.PlaceholderText = "           Buscar Producto...";
            BusquedaInventario.Size = new Size(749, 43);
            BusquedaInventario.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(199, 52);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 13;
            label1.Text = "Buscar Producto.";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkGoldenrod;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(1172, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 8;
            Producto.Name = "Producto";
            Producto.Width = 250;
            // 
            // Precio_Unitario
            // 
            Precio_Unitario.DataPropertyName = "Precio_Unitario";
            Precio_Unitario.HeaderText = "Precio_Unitario";
            Precio_Unitario.MinimumWidth = 8;
            Precio_Unitario.Name = "Precio_Unitario";
            Precio_Unitario.Width = 250;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.Width = 250;
            // 
            // Stock_Minimo
            // 
            Stock_Minimo.DataPropertyName = "Stock_Minimo";
            Stock_Minimo.HeaderText = "Stock_Minimo";
            Stock_Minimo.MinimumWidth = 8;
            Stock_Minimo.Name = "Stock_Minimo";
            Stock_Minimo.Width = 250;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.Width = 250;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1527, 892);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(BusquedaInventario);
            Controls.Add(btnActualizar);
            Controls.Add(btnVer);
            Controls.Add(dataGridView1);
            Name = "frmInventario";
            Text = "frmInventario";
            Load += frmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnVer;
        private Button btnActualizar;
        private TextBox BusquedaInventario;
        private Label label1;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio_Unitario;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Stock_Minimo;
        private DataGridViewTextBoxColumn Estado;
    }
}