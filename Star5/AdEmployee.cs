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
using System.IO;

namespace Star5
{
    public partial class AdEmployee : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdEmployee()
        {
            InitializeComponent();
            BindGridView();
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Emp";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 80;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.PNG) | *.PNG";
            ofd.Filter = "ALL IMAGE FILE (*.*) | *.*";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Emp values (@id,@name,@age,@role,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@role", textBox4.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Did Not Inserted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update Emp set id=@id,name=@name,age=@age,role=@role,image=@image where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@role", textBox4.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Did Not Updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from Emp where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
