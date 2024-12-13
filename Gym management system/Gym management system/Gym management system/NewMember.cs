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

namespace Gym_management_system
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string fname = textBox_firstName.Text;
            string lname = textBox_lastName.Text;

            string gender = "";

            bool isChacked = radioButton_male.Checked;
            if (isChacked)
            {
                gender = radioButton_male.Text;
            }
            else
            {
                gender = radioButton_female.Text;
            }
            string dob = dateTimePicker_DOB.Text;
            Int64 mobile =Int64.Parse(textBox_mobile.Text);
            string email = textBox_email.Text;
            string joindate = dateTimePicker_joindate.Text;
            string gymTime = comboBox_gymTime.Text;
            string address = richTextBox_address.Text;
            string membership = comboBox_membershipTime.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-AA86648; database = gym;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Gymtime, Maddress, MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymTime + "','" + address + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox_firstName.Clear(); 
            textBox_lastName.Clear();

            
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;

            textBox_mobile.Clear();
            textBox_email.Clear();

            comboBox_gymTime.ResetText();
            comboBox_membershipTime.ResetText();
            richTextBox_address.Clear();

            dateTimePicker_DOB.Value= DateTime.Now; 
            dateTimePicker_joindate.Value= DateTime.Now;
        }
    }
}
