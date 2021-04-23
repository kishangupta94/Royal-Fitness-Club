using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (btnusername.Text == "admin" && btnpassword.Text == "admin")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
