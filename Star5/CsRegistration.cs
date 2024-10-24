using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Star5.Usercontrols;

namespace Star5
{
    public partial class CsRegistration : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public CsRegistration()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();

        }

        private string GetRadioValue()
        {
            if (radioButton1.Checked) return "Male";
            else return "Female";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into CS_LOG1 values (@f_name,@l_name,@email,@contact,@DOB,@nationality,@gender,@u_name,@password,@c_password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@f_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@l_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@contact", textBox4.Text);
            cmd.Parameters.AddWithValue("@DOB", textBox5.Text);
            cmd.Parameters.AddWithValue("@nationality", textBox6.Text);
            cmd.Parameters.AddWithValue("@gender", GetRadioValue());
            cmd.Parameters.AddWithValue("@u_name", textBox7.Text);
            cmd.Parameters.AddWithValue("@password", textBox8.Text);
            cmd.Parameters.AddWithValue("@c_password", textBox9.Text);

           
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Sign Up Successful");
               
            }
            else
            {
                MessageBox.Show("Sign Up Failed");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CsLogin uc = new CsLogin();
            addUserControl(uc);
        }
    }
}
