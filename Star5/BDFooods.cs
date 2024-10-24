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
    public partial class BDFooods : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public static string SetValueForText = "";
        public BDFooods()
        {
            InitializeComponent();
            BindGridView();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Proceed To Pay", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Payment pay = new Payment();
                SetValueForText = textBox3.Text;
                pay.Show();
            }
            else
            {
                MessageBox.Show("fill the field", "fail to payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM BD_Food";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            numericUpDown1.Value = 0;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textBox2.Text);
            int input2 = int.Parse(numericUpDown1.Text);
            int result = input1 * input2;


            textBox3.Text = "" + result;
            textBox3.Visible = true;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Food().Show();
        }
    }
}
