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
    public partial class AdBDDrinks : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdBDDrinks()
        {
            InitializeComponent();
            BindGridView();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADFoodCat().Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[3].Value);
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
            string query = "select * from BD_Drinks";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 80;
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
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();           
            textBox3.Clear();           
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into BD_Drinks values (@id,@name,@price,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Food Inserted Successfully","Success",MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Food Did Not Inserted","Failed",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update BD_Drinks set id=@id,name=@name,price=@price,image=@image where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Food Updated Successfully","Success", MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Food Did Not Updated","Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from BD_Drinks where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully","Success",MessageBoxButtons.OK);
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Deleted","Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
