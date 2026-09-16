using CRUB.BLL.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD.UI
{
    public partial class frmInventario : Form
    {
        ServicioInventario _ServicioInventario = new ServicioInventario();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _ServicioInventario.ObtenerInventario();


            dataGridView1.Columns["idInventario"].Visible =false;




        }
    }
}
