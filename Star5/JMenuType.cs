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
    public partial class JMenuType : UserControl
    {
        public JMenuType()
        {
            InitializeComponent();
        }
        
        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            JFooods Panel5 = new JFooods();

            Form parentForm = this.FindForm();

            Panel panel5 = parentForm.Controls.Find("panel5", true).FirstOrDefault() as Panel;

            panel5.Controls.Clear();

            panel5.Controls.Add(Panel5);
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            JDrinks Panel5 = new JDrinks();

            Form parentForm = this.FindForm();

            Panel panel5 = parentForm.Controls.Find("panel5", true).FirstOrDefault() as Panel;

            panel5.Controls.Clear();

            panel5.Controls.Add(Panel5);
        }
    }
}
