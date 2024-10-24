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

namespace Star5
{
    public partial class AdLogin : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Enter Username");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Enter Password");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from AD_LOG where username=@user and password = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*this.Hide();
                   new AdLogin().Hide();
                    Admin ad = new Admin();
                    ad.Show();*/
                    /* Admin mainForm = new Admin();
                     mainForm.Show();
                     AdLogin ad = new AdLogin();
                     ad.Hide();*/
                    this.ParentForm.Hide();
                    Admin newForm = new Admin();
                    newForm.Show();
                    


                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
