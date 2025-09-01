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
           if (txtNombre.Text=="Adm")
            {
                if (cbmModulo.Text=="ADM"|| cbmModulo.Text=="COM"|| cbmModulo.Text=="VTA")
                {
                    if (txtContraseña.Text=="1@a")
                    {
                        frmBienvenidos frmBienvenidos = new frmBienvenidos();
                        frmBienvenidos.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Inválida");
                    }
                }
                else
                {
                    MessageBox.Show("Módulo Inválido");

                }
            }
           if (txtNombre.Text== "John")
            {
                if (cbmModulo.Text =="SIST")
                {
                    if (txtContraseña.Text == "*2b")
                    {
                        frmBienvenidos frmBienvenidos = new frmBienvenidos();
                        frmBienvenidos.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Inválida");
                    }
                }
                else
                {
                    MessageBox.Show("Módulo Inválido");
                }
                   
            }
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


