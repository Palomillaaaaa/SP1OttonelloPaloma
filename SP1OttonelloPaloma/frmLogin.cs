using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1OttonelloPaloma
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBienvenidos frmBienvenidos = new frmBienvenidos();
            frmBienvenidos.ShowDialog();
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtContraseña.Enabled = false;
             
    
        }
            else
            {
                txtContraseña.Enabled = true;
            }
        }
    }
}


