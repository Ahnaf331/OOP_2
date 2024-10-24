using Star5.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star5
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            ADFoodCat uc = new ADFoodCat();
            addUserControl(uc);


        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdEmployee uc = new AdEmployee();
            addUserControl(uc);

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
