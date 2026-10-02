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
            btnICerrarSesion = new Button();
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
            btnVenta = new Button();
            panelMenuIzquierdo.SuspendLayout();
            panelBarraSuperior.SuspendLayout();
<<<<<<< HEAD
=======
            panelControl.SuspendLayout();
            panelContenedorPrincipal.SuspendLayout();
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5
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
<<<<<<< HEAD
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 29, 20);
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-5, 748);
            button2.Name = "button2";
            button2.Size = new Size(404, 77);
            button2.TabIndex = 29;
            button2.Text = "Reportes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 29, 20);
            button3.FlatAppearance.BorderColor = Color.Goldenrod;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 370);
            button3.Name = "button3";
            button3.Size = new Size(403, 73);
            button3.TabIndex = 28;
            button3.Text = "Ayuda";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(39, 156);
            label4.Name = "label4";
            label4.Size = new Size(305, 25);
            label4.TabIndex = 27;
            label4.Text = "Buenas bebidas, mejores momentos ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(83, 93);
            label3.Name = "label3";
            label3.Size = new Size(213, 53);
            label3.TabIndex = 26;
            label3.Text = "LICORERIA";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(43, 29, 20);
            btnFactura.FlatAppearance.BorderColor = Color.DimGray;
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFactura.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.ForeColor = Color.White;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(4, 658);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(399, 72);
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
            btnInicio.FlatAppearance.BorderColor = Color.Goldenrod;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 266);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(403, 64);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(43, 29, 20);
            btnInventario.FlatAppearance.BorderColor = Color.Goldenrod;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(-1, 555);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(403, 74);
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
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 462);
            button1.Name = "button1";
            button1.Size = new Size(399, 73);
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
            panelBarraSuperior.Controls.Add(btnMasOpciones);
            panelBarraSuperior.Controls.Add(label2);
            panelBarraSuperior.Controls.Add(label1);
            panelBarraSuperior.Location = new Point(405, 3);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(1520, 87);
            panelBarraSuperior.TabIndex = 2;
            // 
=======
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5
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
<<<<<<< HEAD
            panelContenedorPrincipal.BackColor = Color.FromArgb(43, 29, 20);
            panelContenedorPrincipal.Location = new Point(405, 92);
=======
            panelContenedorPrincipal.BackColor = Color.FromArgb(32, 32, 32);
            panelContenedorPrincipal.Controls.Add(btnVenta);
            panelContenedorPrincipal.Location = new Point(402, 138);
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5
            panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            panelContenedorPrincipal.Size = new Size(1537, 909);
            panelContenedorPrincipal.TabIndex = 4;
            // 
            // btnVenta
            // 
<<<<<<< HEAD
            btnMasOpciones.BackColor = Color.FromArgb(43, 29, 20);
            btnMasOpciones.FlatAppearance.BorderColor = Color.DimGray;
            btnMasOpciones.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMasOpciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnMasOpciones.FlatStyle = FlatStyle.Flat;
            btnMasOpciones.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasOpciones.ForeColor = Color.DarkGoldenrod;
            btnMasOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasOpciones.Location = new Point(1297, 23);
            btnMasOpciones.Name = "btnMasOpciones";
            btnMasOpciones.Size = new Size(167, 44);
            btnMasOpciones.TabIndex = 15;
            btnMasOpciones.Text = "Mas Opiones";
            btnMasOpciones.TextAlign = ContentAlignment.MiddleLeft;
            btnMasOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMasOpciones.UseVisualStyleBackColor = false;
            btnMasOpciones.Click += btnMasOpciones_Click;
=======
            btnVenta.BackColor = Color.FromArgb(43, 29, 20);
            btnVenta.FlatAppearance.BorderColor = Color.DimGray;
            btnVenta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 24, 24);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVenta.ForeColor = SystemColors.AppWorkspace;
            btnVenta.Image = (Image)resources.GetObject("btnVenta.Image");
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(206, 180);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(183, 56);
            btnVenta.TabIndex = 8;
            btnVenta.Text = "Venta";
            btnVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5
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
<<<<<<< HEAD
=======
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            panelContenedorPrincipal.ResumeLayout(false);
>>>>>>> e07d9ed5d1d710b9db9e693ae12a9fcd6d32e1c5
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
        private Button btnVenta;
    }
}