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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String Equipname = ename.Text;
            String EDescription = edescription.Text;
            String Mused = muscleused.Text;
            //Int64 Cost = Convert.ToInt64(cost.Text);
            bool success = Int64.TryParse(cost.Text, out Int64 Cost);
            String dod = dateTimePicker1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DRAGEN94; database=gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment(Equipname,EDescription,Mused,cost,dod) values ('" + Equipname + "','" + EDescription + "','" + Mused + "'," + Cost + ",'" + dod + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DSS = new DataSet();
            DA.Fill(DSS);
            MessageBox.Show("Data Saved");
            
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            ename.Clear();
            edescription.Clear();
            muscleused.Clear();
            cost.Clear();
            dateTimePicker1.ResetText();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();

        }
    }
}
