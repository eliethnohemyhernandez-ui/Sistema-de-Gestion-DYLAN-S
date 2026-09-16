namespace CRUD.UI
{
    partial class frmFactura
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnAgregar = new Button();
            btnMetodo = new ComboBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            rtbVistaPrevia = new RichTextBox();
            cmbProducto = new ComboBox();
            textBox6 = new TextBox();
            label7 = new Label();
            btnCancelar = new Button();
            btnFactura = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "No. Factura.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(114, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 31);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(32, 32, 32);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 33);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(525, 14);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 0;
            label5.Text = " Producto";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 135);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 2;
            label6.Text = "Cant:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(32, 32, 32);
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(116, 135);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 31);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Goldenrod;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(500, 164);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMetodo
            // 
            btnMetodo.BackColor = Color.FromArgb(32, 32, 32);
            btnMetodo.ForeColor = Color.White;
            btnMetodo.FormattingEnabled = true;
            btnMetodo.Location = new Point(565, 612);
            btnMetodo.Name = "btnMetodo";
            btnMetodo.Size = new Size(306, 33);
            btnMetodo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(546, 561);
            label9.Name = "label9";
            label9.Size = new Size(97, 33);
            label9.TabIndex = 8;
            label9.Text = "Metodo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(944, 277);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cmbProducto);
            splitContainer1.Panel2.Controls.Add(textBox6);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(btnCancelar);
            splitContainer1.Panel2.Controls.Add(btnFactura);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(btnAgregar);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(btnMetodo);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(numericUpDown1);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1518, 810);
            splitContainer1.SplitterDistance = 503;
            splitContainer1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rtbVistaPrevia);
            panel1.Location = new Point(29, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 578);
            panel1.TabIndex = 0;
            // 
            // rtbVistaPrevia
            // 
            rtbVistaPrevia.BorderStyle = BorderStyle.None;
            rtbVistaPrevia.Dock = DockStyle.Fill;
            rtbVistaPrevia.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbVistaPrevia.ForeColor = Color.Black;
            rtbVistaPrevia.Location = new Point(0, 0);
            rtbVistaPrevia.Name = "rtbVistaPrevia";
            rtbVistaPrevia.ReadOnly = true;
            rtbVistaPrevia.Size = new Size(300, 578);
            rtbVistaPrevia.TabIndex = 0;
            rtbVistaPrevia.Text = "";
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.FromArgb(32, 32, 32);
            cmbProducto.ForeColor = Color.White;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(617, 14);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(343, 33);
            cmbProducto.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(32, 32, 32);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(641, 108);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 31);
            textBox6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(546, 114);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 18;
            label7.Text = "Cagero";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(73, 743);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 55);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.Goldenrod;
            btnFactura.ForeColor = Color.Black;
            btnFactura.Location = new Point(742, 743);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(161, 55);
            btnFactura.TabIndex = 16;
            btnFactura.Text = "Imprimir";
            btnFactura.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(32, 32, 32);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(73, 652);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(287, 51);
            textBox5.TabIndex = 15;
            textBox5.Text = "VUELTO";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(32, 32, 32);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(190, 580);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 31);
            textBox4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 582);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 13;
            label4.Text = "Monto_Resivido";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 32, 32);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(190, 503);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 511);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 12;
            label3.Text = "Total de venta";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1518, 810);
            Controls.Add(splitContainer1);
            Name = "frmFactura";
            Text = "frmFactura";
            Load += frmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Button btnAgregar;
        private NumericUpDown numericUpDown1;
        private ComboBox btnMetodo;
        private Label label9;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox textBox3;
        private Button btnFactura;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox6;
        private Label label7;
        private Button btnCancelar;
        private Panel panel1;
        private RichTextBox rtbVistaPrevia;
        private ComboBox cmbProducto;
    }
}