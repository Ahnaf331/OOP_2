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
    public partial class Login : Form
    {
        public Login()
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
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            CsLogin uc =new CsLogin();
            addUserControl(uc);
          
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AdLogin uc = new AdLogin();
            addUserControl(uc);
        }
    }
}
