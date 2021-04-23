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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"E:\project all\Anudip\csharp\ConsoleApp1\ConsoleApp1\image\rarrow.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"E:\project all\Anudip\csharp\ConsoleApp1\ConsoleApp1\image\darrow.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Dock = DockStyle.Top;
            b = true;
            toolStripMenuItem1.Image = Image.FromFile(@"E:\project all\Anudip\csharp\ConsoleApp1\ConsoleApp1\image\darrow.jpg");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newmember nm = new Newmember();
            nm.Show();
        }

        private void newStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newstuff ns = new Newstuff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment equip = new Equipment();
            equip.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchmember sm = new Searchmember();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletemember dm = new deletemember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure. You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
