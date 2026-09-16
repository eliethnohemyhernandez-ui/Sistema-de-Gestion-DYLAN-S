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
            usuarioRl = new Button();
            btnInventario = new Button();
            btnProveedor = new Button();
            btnFactura = new Button();
            btnPersonal = new Button();
            btnCliente = new Button();
            btnInicio = new Button();
            panelBarraSuperior = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelControl = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnRol = new Button();
            label3 = new Label();
            btnCategoria = new Button();
            btnGestionU = new Button();
            btnMetodo = new Button();
            btnCatalogoProducto = new Button();
            panelContenedorPrincipal = new Panel();
            btnICerrarSesion = new Button();
            panelMenuIzquierdo.SuspendLayout();
            panelBarraSuperior.SuspendLayout();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuIzquierdo
            // 
            panelMenuIzquierdo.BackColor = Color.FromArgb(43, 29, 20);
            panelMenuIzquierdo.Controls.Add(usuarioRl);
            panelMenuIzquierdo.Controls.Add(btnInventario);
            panelMenuIzquierdo.Controls.Add(btnProveedor);
            panelMenuIzquierdo.Controls.Add(btnFactura);
            panelMenuIzquierdo.Controls.Add(btnPersonal);
            panelMenuIzquierdo.Controls.Add(btnCliente);
            panelMenuIzquierdo.Controls.Add(btnInicio);
            panelMenuIzquierdo.Location = new Point(0, 0);
            panelMenuIzquierdo.Name = "panelMenuIzquierdo";
            panelMenuIzquierdo.Size = new Size(403, 1044);
            panelMenuIzquierdo.TabIndex = 1;
            // 
            // usuarioRl
            // 
            usuarioRl.BackColor = Color.FromArgb(43, 29, 20);
            usuarioRl.FlatAppearance.BorderColor = Color.DimGray;
            usuarioRl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            usuarioRl.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            usuarioRl.FlatStyle = FlatStyle.Flat;
            usuarioRl.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuarioRl.ForeColor = Color.DarkGoldenrod;
            usuarioRl.Image = (Image)resources.GetObject("usuarioRl.Image");
            usuarioRl.ImageAlign = ContentAlignment.MiddleLeft;
            usuarioRl.Location = new Point(44, 884);
            usuarioRl.Name = "usuarioRl";
            usuarioRl.Size = new Size(321, 96);
            usuarioRl.TabIndex = 6;
            usuarioRl.Text = "Usuario";
            usuarioRl.TextAlign = ContentAlignment.MiddleLeft;
            usuarioRl.TextImageRelation = TextImageRelation.ImageBeforeText;
            usuarioRl.UseVisualStyleBackColor = false;
            usuarioRl.Click += btnUsuario_Click;
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
            btnInventario.Location = new Point(44, 178);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(321, 94);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(43, 29, 20);
            btnProveedor.FlatAppearance.BorderColor = Color.DimGray;
            btnProveedor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedor.ForeColor = Color.DarkGoldenrod;
            btnProveedor.Image = (Image)resources.GetObject("btnProveedor.Image");
            btnProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedor.Location = new Point(44, 318);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(321, 89);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "Proveedores";
            btnProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
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
            btnFactura.Location = new Point(44, 741);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(321, 95);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Factura";
            btnFactura.TextAlign = ContentAlignment.MiddleLeft;
            btnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.FromArgb(43, 29, 20);
            btnPersonal.FlatAppearance.BorderColor = Color.DimGray;
            btnPersonal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPersonal.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonal.ForeColor = Color.DarkGoldenrod;
            btnPersonal.Image = (Image)resources.GetObject("btnPersonal.Image");
            btnPersonal.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonal.Location = new Point(44, 593);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(321, 96);
            btnPersonal.TabIndex = 2;
            btnPersonal.Text = "Personal";
            btnPersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersonal.UseVisualStyleBackColor = false;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(43, 29, 20);
            btnCliente.FlatAppearance.BorderColor = Color.DimGray;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = Color.DarkGoldenrod;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(44, 446);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(321, 94);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
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
            btnInicio.Location = new Point(44, 28);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(321, 97);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
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
            panelControl.Controls.Add(button2);
            panelControl.Controls.Add(button1);
            panelControl.Controls.Add(btnRol);
            panelControl.Controls.Add(label3);
            panelControl.Controls.Add(btnCategoria);
            panelControl.Controls.Add(btnGestionU);
            panelControl.Controls.Add(btnMetodo);
            panelControl.Controls.Add(btnCatalogoProducto);
            panelControl.Location = new Point(402, 65);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1520, 69);
            panelControl.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 29, 20);
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.AppWorkspace;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1347, 10);
            button2.Name = "button2";
            button2.Size = new Size(149, 54);
            button2.TabIndex = 13;
            button2.Text = "{Ayuda}";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 29, 20);
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1144, 10);
            button1.Name = "button1";
            button1.Size = new Size(166, 54);
            button1.TabIndex = 12;
            button1.Text = "Compra";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRol
            // 
            btnRol.BackColor = Color.FromArgb(43, 29, 20);
            btnRol.FlatAppearance.BorderColor = Color.DimGray;
            btnRol.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRol.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnRol.FlatStyle = FlatStyle.Flat;
            btnRol.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRol.ForeColor = SystemColors.AppWorkspace;
            btnRol.Image = (Image)resources.GetObject("btnRol.Image");
            btnRol.ImageAlign = ContentAlignment.MiddleLeft;
            btnRol.Location = new Point(954, 8);
            btnRol.Name = "btnRol";
            btnRol.Size = new Size(153, 54);
            btnRol.TabIndex = 11;
            btnRol.Text = "Rol";
            btnRol.TextAlign = ContentAlignment.MiddleLeft;
            btnRol.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRol.UseVisualStyleBackColor = false;
            btnRol.Click += btnRol_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(793, 21);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 9;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.FromArgb(43, 29, 20);
            btnCategoria.FlatAppearance.BorderColor = Color.DimGray;
            btnCategoria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoria.ForeColor = SystemColors.AppWorkspace;
            btnCategoria.Image = (Image)resources.GetObject("btnCategoria.Image");
            btnCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoria.Location = new Point(726, 8);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(189, 54);
            btnCategoria.TabIndex = 8;
            btnCategoria.Text = "{Categoria]";
            btnCategoria.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnGestionU
            // 
            btnGestionU.BackColor = Color.FromArgb(43, 29, 20);
            btnGestionU.FlatAppearance.BorderColor = Color.DimGray;
            btnGestionU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGestionU.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnGestionU.FlatStyle = FlatStyle.Flat;
            btnGestionU.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionU.ForeColor = SystemColors.AppWorkspace;
            btnGestionU.Image = (Image)resources.GetObject("btnGestionU.Image");
            btnGestionU.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionU.Location = new Point(475, 8);
            btnGestionU.Name = "btnGestionU";
            btnGestionU.Size = new Size(222, 57);
            btnGestionU.TabIndex = 7;
            btnGestionU.Text = "{Gestion Usuario}";
            btnGestionU.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionU.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionU.UseVisualStyleBackColor = false;
            btnGestionU.Click += btnGestionU_Click;
            // 
            // btnMetodo
            // 
            btnMetodo.BackColor = Color.FromArgb(43, 29, 20);
            btnMetodo.FlatAppearance.BorderColor = Color.DimGray;
            btnMetodo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMetodo.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnMetodo.FlatStyle = FlatStyle.Flat;
            btnMetodo.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMetodo.ForeColor = SystemColors.AppWorkspace;
            btnMetodo.Image = (Image)resources.GetObject("btnMetodo.Image");
            btnMetodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnMetodo.Location = new Point(264, 7);
            btnMetodo.Name = "btnMetodo";
            btnMetodo.Size = new Size(183, 56);
            btnMetodo.TabIndex = 7;
            btnMetodo.Text = "Metodo";
            btnMetodo.TextAlign = ContentAlignment.MiddleLeft;
            btnMetodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMetodo.UseVisualStyleBackColor = false;
            btnMetodo.Click += btnMetodo_Click;
            // 
            // btnCatalogoProducto
            // 
            btnCatalogoProducto.BackColor = Color.FromArgb(43, 29, 20);
            btnCatalogoProducto.FlatAppearance.BorderColor = Color.DimGray;
            btnCatalogoProducto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCatalogoProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnCatalogoProducto.FlatStyle = FlatStyle.Flat;
            btnCatalogoProducto.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCatalogoProducto.ForeColor = SystemColors.AppWorkspace;
            btnCatalogoProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogoProducto.Location = new Point(25, 6);
            btnCatalogoProducto.Name = "btnCatalogoProducto";
            btnCatalogoProducto.Size = new Size(216, 57);
            btnCatalogoProducto.TabIndex = 6;
            btnCatalogoProducto.Text = "{Catalogo: Producto}";
            btnCatalogoProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogoProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCatalogoProducto.UseVisualStyleBackColor = false;
            btnCatalogoProducto.Click += btnCatalogoProducto_Click;
            // 
            // panelContenedorPrincipal
            // 
            panelContenedorPrincipal.BackColor = Color.FromArgb(32, 32, 32);
            panelContenedorPrincipal.Location = new Point(402, 138);
            panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            panelContenedorPrincipal.Size = new Size(1537, 909);
            panelContenedorPrincipal.TabIndex = 4;
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
        private Button btnProveedor;
        private Button btnFactura;
        private Button btnPersonal;
        private Button btnCliente;
        private Button btnCatalogoProducto;
        private Button btnGestionU;
        private Button btnMetodo;
        private Button btnCategoria;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button usuarioRl;
        private Button btnRol;
        private Button button1;
        private Button button2;
        private Button btnICerrarSesion;
    }
}