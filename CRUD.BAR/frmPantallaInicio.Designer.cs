namespace CRUD.UI
{
    partial class frmPantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaInicio));
            panelMenuIzquierdo = new Panel();
            btnFactura = new Button();
            btnInicio = new Button();
            button2 = new Button();
            btnInventario = new Button();
            button1 = new Button();
            panelBarraSuperior = new Panel();
            btnICerrarSesion = new Button();
            label2 = new Label();
            label1 = new Label();
            panelControl = new Panel();
            btnReportes = new Button();
            label3 = new Label();
            panelContenedorPrincipal = new Panel();
            btnMasOpciones = new Button();
            panelMenuIzquierdo.SuspendLayout();
            panelBarraSuperior.SuspendLayout();
            panelControl.SuspendLayout();
            panelContenedorPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuIzquierdo
            // 
            panelMenuIzquierdo.BackColor = Color.FromArgb(43, 29, 20);
            panelMenuIzquierdo.Controls.Add(btnFactura);
            panelMenuIzquierdo.Controls.Add(btnInicio);
            panelMenuIzquierdo.Controls.Add(button2);
            panelMenuIzquierdo.Controls.Add(btnInventario);
            panelMenuIzquierdo.Controls.Add(button1);
            panelMenuIzquierdo.Location = new Point(0, 0);
            panelMenuIzquierdo.Name = "panelMenuIzquierdo";
            panelMenuIzquierdo.Size = new Size(403, 1044);
            panelMenuIzquierdo.TabIndex = 1;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(43, 29, 20);
            btnFactura.FlatAppearance.BorderColor = Color.DimGray;
            btnFactura.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFactura.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.ForeColor = Color.DarkGoldenrod;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(58, 853);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(321, 95);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Factura";
            btnFactura.TextAlign = ContentAlignment.MiddleLeft;
            btnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(43, 29, 20);
            btnInicio.FlatAppearance.BorderColor = Color.DimGray;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.DarkGoldenrod;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(59, 268);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(321, 97);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 29, 20);
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkGoldenrod;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(55, 419);
            button2.Name = "button2";
            button2.Size = new Size(321, 102);
            button2.TabIndex = 13;
            button2.Text = "{Ayuda}";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(43, 29, 20);
            btnInventario.FlatAppearance.BorderColor = Color.DimGray;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.DarkGoldenrod;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(59, 709);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(321, 94);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 29, 20);
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGoldenrod;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(54, 573);
            button1.Name = "button1";
            button1.Size = new Size(321, 91);
            button1.TabIndex = 12;
            button1.Text = "Compra";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(24, 24, 24);
            panelBarraSuperior.Controls.Add(btnICerrarSesion);
            panelBarraSuperior.Controls.Add(label2);
            panelBarraSuperior.Controls.Add(label1);
            panelBarraSuperior.Location = new Point(402, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(1520, 63);
            panelBarraSuperior.TabIndex = 2;
            // 
            // btnICerrarSesion
            // 
            btnICerrarSesion.BackColor = Color.FromArgb(0, 0, 0, 32);
            btnICerrarSesion.FlatAppearance.BorderColor = Color.DimGray;
            btnICerrarSesion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnICerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnICerrarSesion.FlatStyle = FlatStyle.Flat;
            btnICerrarSesion.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnICerrarSesion.ForeColor = Color.Goldenrod;
            btnICerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnICerrarSesion.Location = new Point(1277, 12);
            btnICerrarSesion.Name = "btnICerrarSesion";
            btnICerrarSesion.Size = new Size(219, 42);
            btnICerrarSesion.TabIndex = 14;
            btnICerrarSesion.Text = "Cerrar Sesion / Salida";
            btnICerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnICerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnICerrarSesion.UseVisualStyleBackColor = false;
            btnICerrarSesion.Click += btnICerrarSesion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 13);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 1;
            label2.Text = "Sucursal Norte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(197, 26);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido, Usuario -";
            // 
            // panelControl
            // 
            panelControl.Controls.Add(btnReportes);
            panelControl.Controls.Add(label3);
            panelControl.Location = new Point(402, 65);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1520, 69);
            panelControl.TabIndex = 3;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(43, 29, 20);
            btnReportes.FlatAppearance.BorderColor = Color.DimGray;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.DarkGoldenrod;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(33, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(194, 47);
            btnReportes.TabIndex = 14;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(793, 21);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 9;
            // 
            // panelContenedorPrincipal
            // 
            panelContenedorPrincipal.BackColor = Color.FromArgb(32, 32, 32);
            panelContenedorPrincipal.Controls.Add(btnMasOpciones);
            panelContenedorPrincipal.Location = new Point(402, 138);
            panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            panelContenedorPrincipal.Size = new Size(1537, 909);
            panelContenedorPrincipal.TabIndex = 4;
            panelContenedorPrincipal.Paint += panelContenedorPrincipal_Paint;
            // 
            // btnMasOpciones
            // 
            btnMasOpciones.BackColor = Color.FromArgb(43, 29, 20);
            btnMasOpciones.FlatAppearance.BorderColor = Color.DimGray;
            btnMasOpciones.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMasOpciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnMasOpciones.FlatStyle = FlatStyle.Flat;
            btnMasOpciones.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasOpciones.ForeColor = Color.DarkGoldenrod;
            btnMasOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasOpciones.Location = new Point(1296, 734);
            btnMasOpciones.Name = "btnMasOpciones";
            btnMasOpciones.Size = new Size(183, 56);
            btnMasOpciones.TabIndex = 15;
            btnMasOpciones.Text = "Mas Opiones";
            btnMasOpciones.TextAlign = ContentAlignment.MiddleLeft;
            btnMasOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMasOpciones.UseVisualStyleBackColor = false;
            btnMasOpciones.Click += btnMasOpciones_Click;
            // 
            // frmPantallaInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1920, 1046);
            Controls.Add(panelContenedorPrincipal);
            Controls.Add(panelControl);
            Controls.Add(panelBarraSuperior);
            Controls.Add(panelMenuIzquierdo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Name = "frmPantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LICORERIA DYLAN - Sistema de Gestion";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmPantallaInicio_FormClosed;
            Load += frmPantallaInicio_Load;
            panelMenuIzquierdo.ResumeLayout(false);
            panelBarraSuperior.ResumeLayout(false);
            panelBarraSuperior.PerformLayout();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            panelContenedorPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button frmMetodo;
        private Panel panelMenuIzquierdo;
        private Panel panelBarraSuperior;
        private Panel panelControl;
        private Panel panelContenedorPrincipal;
        private Button btnInicio;
        private Button btnInventario;
        private Button btnFactura;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button btnICerrarSesion;
        private Button btnMasOpciones;
        private Button btnReportes;
    }
}