namespace CRUD.UI
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            btnIniciar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(201, 162, 39);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.FromArgb(30, 20, 10);
            btnIniciar.Location = new Point(1196, 698);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(600, 61);
            btnIniciar.TabIndex = 22;
            btnIniciar.Text = "Iniciar Sesion";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(35, 27, 21);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(1196, 577);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "      Contraseña";
            txtContraseña.Size = new Size(600, 72);
            txtContraseña.TabIndex = 21;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(35, 27, 21);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(1196, 479);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "          Usuario";
            txtUsuario.Size = new Size(600, 73);
            txtUsuario.TabIndex = 20;
            txtUsuario.UseWaitCursor = true;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1356, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1396, 804);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 24;
            label1.Text = "¿Olvidastes tu contraseña?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(1364, 272);
            label2.Name = "label2";
            label2.Size = new Size(275, 69);
            label2.TabIndex = 25;
            label2.Text = "LICORERIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(1331, 342);
            label3.Name = "label3";
            label3.Size = new Size(369, 30);
            label3.TabIndex = 26;
            label3.Text = "Buenas bebidas, mejores momentos ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(1357, 916);
            label4.Name = "label4";
            label4.Size = new Size(405, 30);
            label4.TabIndex = 27;
            label4.Text = "Sistema  de  Gestion _____________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1791, 987);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 39, 35);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1802, 993);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox2);
            Name = "FrmInicioSesion";
            Text = "FrmInicioSesion";
            WindowState = FormWindowState.Maximized;
            Load += FrmInicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}