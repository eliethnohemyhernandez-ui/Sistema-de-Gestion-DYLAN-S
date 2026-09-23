using CRUD.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmPantallaInicio : Form
    {
        private int UsuarioRol;

        public frmPantallaInicio(int idRol)
        {
            InitializeComponent();

            this.UsuarioRol = idRol;
        }

        private void frmPantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioHijo(Form formHijo)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        { }
        


           

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            if (UsuarioRol == 4)
            {
                MessageBox.Show("No tiene permisos  para acceder a Usuario.");

                return;
            }



            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);


            frmUsuario fh = new frmUsuario();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;


            this.panelContenedorPrincipal.Controls.Add(fh);
            this.panelContenedorPrincipal.Tag = fh;
            fh.Show();

        }


        private void btnInventario_Click(object sender, EventArgs e)
        {


            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);


            frmInventario fh = new frmInventario();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelContenedorPrincipal.Controls.Add(fh);
            this.panelContenedorPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        { }

            
        private void btnCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);


            frmFactura fh = new frmFactura();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelContenedorPrincipal.Controls.Add(fh);
            this.panelContenedorPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnCatalogoProducto_Click(object sender, EventArgs e)
        { }


        private void btnMetodo_Click(object sender, EventArgs e)
        {

            
        }

        private void btnGestionU_Click(object sender, EventArgs e)
        {

        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPantallaInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);


            frmInicio fh = new frmInicio();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;


            this.panelContenedorPrincipal.Controls.Add(fh);
            this.panelContenedorPrincipal.Tag = fh;
            fh.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorPrincipal.Controls.Count > 0)
                this.panelContenedorPrincipal.Controls.RemoveAt(0);


            frmCompra fh = new frmCompra();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;


            this.panelContenedorPrincipal.Controls.Add(fh);
            this.panelContenedorPrincipal.Tag = fh;
            fh.Show();

        }

        private void btnICerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form login = Application.OpenForms["frmLogin"];

                if (login != null)
                {
                    // Buscamos los TextBox por su nombre 
                    var txtUsuario = login.Controls.Find("txtUsuario", true).FirstOrDefault() as TextBox;
                    var txtContraseña = login.Controls.Find("txtContraseña", true).FirstOrDefault() as TextBox;

                    // Si los encuentra, los limpia
                    if (txtUsuario != null) txtUsuario.Text = string.Empty;
                    if (txtContraseña != null) txtContraseña.Text = string.Empty;

                    login.Show(); // Mostramos el login limpio
                }
                else
                {
                    // Si por alguna razón no existía, creamos uno nuevo (este ya viene limpio)
                    FrmInicioSesion nuevoLogin = new FrmInicioSesion();
                    nuevoLogin.Show();
                }


            }
        }

        private void panelContenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmAyuda fh = new frmAyuda();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnMasOpciones_Click(object sender, EventArgs e)
        {

            Mas_Opciones fh = new Mas_Opciones();
            fh.WindowState = FormWindowState.Maximized;
            fh.Show();

        }
    }


}

