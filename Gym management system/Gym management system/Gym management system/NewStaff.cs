using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_system
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;

            string gender = "";
            bool isChecked = radioButton_male.Checked;

            if(isChecked)
            {
                gender = radioButton_male.Text;
            }
            else
            {
                gender = radioButton_female.Text;
            }

            string dob = dateTimePicker_DOB.Text;
            Int64 mobile = Int64.Parse(textBox_mobile.Text);
            string email = textBox_email.Text;
            string joindate = dateTimePicker_joindate.Text;
            string state = textBox_state.Text;
            string city = textBox_city.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-AA86648; database = gym;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + state + "','" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            textBox_mobile.Clear();
            textBox_city.Clear();
            textBox_state.Clear();
            textBox_email.Clear();

            dateTimePicker_DOB.Value = DateTime.Now;
            dateTimePicker_joindate.Value = DateTime.Now;
        }
    }
}
