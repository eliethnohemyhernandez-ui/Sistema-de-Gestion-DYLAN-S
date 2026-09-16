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
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panelCentro = new Panel();
            panelCentro.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(220, 170, 85);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.FromArgb(30, 20, 10);
            btnIniciar.Location = new Point(245, 417);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(250, 54);
            btnIniciar.TabIndex = 22;
            btnIniciar.Text = "Iniciar Sesion";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 22, 17);
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 67);
            label1.Name = "label1";
            label1.Size = new Size(316, 56);
            label1.TabIndex = 17;
            label1.Text = "Iniciar Sesion";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(35, 27, 21);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(137, 306);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(477, 42);
            txtContraseña.TabIndex = 21;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(35, 27, 21);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(137, 191);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(482, 42);
            txtUsuario.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(35, 27, 21);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 163);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 19;
            label2.Text = "Usuario o Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(35, 27, 21);
            label3.ForeColor = Color.White;
            label3.Location = new Point(148, 271);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 18;
            label3.Text = "Contraseña";
            // 
            // panelCentro
            // 
            panelCentro.BackColor = Color.Transparent;
            panelCentro.BackgroundImage = (Image)resources.GetObject("panelCentro.BackgroundImage");
            panelCentro.Controls.Add(btnIniciar);
            panelCentro.Controls.Add(label1);
            panelCentro.Controls.Add(label2);
            panelCentro.Controls.Add(txtContraseña);
            panelCentro.Controls.Add(label3);
            panelCentro.Controls.Add(txtUsuario);
            panelCentro.Location = new Point(307, 95);
            panelCentro.Name = "panelCentro";
            panelCentro.Size = new Size(776, 623);
            panelCentro.TabIndex = 0;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 22, 17);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1216, 763);
            Controls.Add(panelCentro);
            Name = "FrmInicioSesion";
            Text = "FrmInicioSesion";
            WindowState = FormWindowState.Maximized;
            Load += FrmInicioSesion_Load;
            SizeChanged += FrmInicioSesion_SizeChanged;
            panelCentro.ResumeLayout(false);
            panelCentro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnIniciar;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private Panel panelCentro;
    }
}