﻿using Star5.Usercontrols;
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
    public partial class Food : Form
    {
        public Food()
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            BdMenuType uc = new BdMenuType();
            addUserControl(uc);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            InMenuType uc = new InMenuType();
            addUserControl(uc);
        }

       

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            JMenuType uc = new JMenuType();
            addUserControl(uc);
        }

        
    }
}
