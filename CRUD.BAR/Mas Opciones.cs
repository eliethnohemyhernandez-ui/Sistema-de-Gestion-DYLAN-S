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
    public partial class Mas_Opciones : Form
    {
        public Mas_Opciones()
        {
            InitializeComponent();
        }

        private void btnCatalogoProducto_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmProducto fh = new frmProducto();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmProveedore fh = new frmProveedore();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnICerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmCategoria fh = new frmCategoria();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmCliente fh = new frmCliente();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void usuarioRl_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmUsuarioRol fh = new frmUsuarioRol();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmPersonal fh = new frmPersonal();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnGestionU_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            FrmGestion_Usuario fh = new FrmGestion_Usuario();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmUsuarioRol fh = new frmUsuarioRol();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            if (this.panelControl.Controls.Count > 0)
                this.panelControl.Controls.RemoveAt(0);


            frmMetodo_Pago fh = new frmMetodo_Pago();


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; // Esto hace que se adapte al tamaño del panel


            this.panelControl.Controls.Add(fh);
            this.panelControl.Tag = fh;
            fh.Show();
        }
    }

}
