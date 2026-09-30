using CRUB.BLL.Servicios;
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
    public partial class FrmInicioSesion : Form
    {
        private int UsuarioRol;
        public FrmInicioSesion()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;

        }


        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {


        }



        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            ServicioUsuario service = new ServicioUsuario();

            Usuario usuario = service.Login(
                txtUsuario.Text,
                txtContraseña.Text);

            if (usuario != null)
            {

                frmPantallaInicio pantallaInicio = new frmPantallaInicio(usuario.id_Rol);


                pantallaInicio.Show();


                this.Hide();




            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}

    

