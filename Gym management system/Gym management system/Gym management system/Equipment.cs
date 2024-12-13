using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Gym_management_system
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void button_viewEqupments_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string EquipName = textBoxEqupmentName.Text;
            string description = richTextBox_description.Text;
            string MUsed = textBox_muscleUsed.Text;
            string DDate = dateTimePicker_deliveryDate.Text;
            Int64 cost = Int64.Parse(textBox_cost.Text);


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-AA86648; database = gym;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "insert into Equipment ( (EquipName,EDescription,MUsed,DDate ,cost) values ('" + EquipName + "','" + description + "','" + MUsed + "','" + DDate + "','" + cost + "')";
            cmd.CommandText = "insert into Equipment (EquipName, EDescription, MUsed, DDate, Cost) values ('" + EquipName + "', '" + description + "', '" + MUsed + "', '" + DDate + "', " + cost + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved.","Inserted",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBoxEqupmentName.Clear();
            richTextBox_description.Clear();
            textBox_muscleUsed.Clear();
            textBox_cost.Clear();
            dateTimePicker_deliveryDate.Value = DateTime.Now;
        }
    }
}
