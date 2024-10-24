using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Star5
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loading Successful");
                Welcome wlc = new Welcome();
                wlc.Show();
                this.Hide();
            }
        }*/

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Loading Successful");
                Welcome wlc = new Welcome();
                wlc.Show();
                this.Hide();
            }
        }
    }
}
