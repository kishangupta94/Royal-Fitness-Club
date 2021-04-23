using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Newstuff : Form
    {
        public Newstuff()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String Fname = fname.Text;
            String Mname = mname.Text;
            String Lname = lname.Text;
            //Int64 Mno = Convert.ToInt64(mno.Text);
            bool success = Int64.TryParse(mno.Text, out Int64 Mno);
            String Address = address.Text;
            String Email = email.Text;
            String gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePicker1.Text;
            String doj = dateTimePicker2.Text;
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DRAGEN94; database=gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Newstuff(fname,mname,lname,mno,address,email,gender,dob,doj) values ('" + Fname + "','" + Mname + "','" + Lname + "'," + Mno + ",'" + Address + "','" + Email + "','" + gender + "','" + dob + "','" + doj + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");

        }


    
        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            fname.Clear();
            mname.Clear();
            lname.Clear();
            mno.Clear();
            address.Clear();
            email.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
