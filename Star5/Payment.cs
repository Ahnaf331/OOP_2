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
    public partial class Payment : Form
    {
        Boolean flag;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {   string bdfoodValue= BDFooods.SetValueForText;
            string bddrinksvalue = BDDrinks.SetValueForText;
            string ifoodValue = IFoods.SetValueForText;
            string idrinksValue = IDrinks.SetValueForText;
            string jfoodValue = JFooods.SetValueForText;
            string jdrinksValue = JDrinks.SetValueForText;

            decimal bdfoodAmount = 0;
            decimal bddrinksAmount = 0;
            decimal ifoodAmount = 0;
            decimal idrinksAmount = 0;
            decimal jfoodAmount = 0;
                 decimal jdrinksAmount = 0;

            decimal.TryParse(bdfoodValue, out bdfoodAmount);
            decimal.TryParse(bddrinksvalue, out bddrinksAmount);
            decimal.TryParse(ifoodValue, out ifoodAmount);
            decimal.TryParse(idrinksValue, out idrinksAmount);
            decimal.TryParse(jfoodValue, out jfoodAmount);
            decimal.TryParse(jdrinksValue, out jdrinksAmount);

            decimal totalAmount = bdfoodAmount + bddrinksAmount + ifoodAmount + idrinksAmount + jfoodAmount + jdrinksAmount;
            textBox3.Text = totalAmount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                flag = false;

                label3.Text = "Cash";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                flag = true;
                label3.Text = "Mobile Banking";
            }
        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Food fd = new Food();
            fd.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text !="")
            {
                MessageBox.Show("Payment Successful", "Success", MessageBoxButtons.OK);
                ResetControl();
            }
            else
            {
                MessageBox.Show("Payment Failed","Failed", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
