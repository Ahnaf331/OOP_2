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
    public partial class ADFoodCat : UserControl
    {
        public ADFoodCat()
        {
            InitializeComponent();
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdBDDrinks().Show();
        }

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdBDFoods().Show();
        }

        private void gunaGradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdIFoods().Show();
        }

        private void gunaGradientTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADIDrinks().Show();
        }

        private void gunaGradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdJFoods().Show();
        }

        private void gunaGradientTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdJDrinks().Show();
        }
    }
}
