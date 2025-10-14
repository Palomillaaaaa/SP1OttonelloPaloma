using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1OttonelloPaloma
{
    public partial class frmBienvenidos : Form
    {
        public frmBienvenidos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void frmBienvenidos_Load(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
