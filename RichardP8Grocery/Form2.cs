using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichardP8Grocery
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            bool taxValid, foodValid, PreparedFoodValid, LiquorValid;
            double strTempValue, fTempValue, pfTempValue, lTempValue;

            StreamWriter sw;

            taxValid = double.TryParse(txtSaleTaxRate.Text, out strTempValue);
            if (strTempValue >= 1 || strTempValue < 0)
            {
                taxValid = false;
            }
            foodValid = double.TryParse(txtFoodFee.Text, out fTempValue);
            PreparedFoodValid = double.TryParse(txtPreparedFoodFee.Text, out pfTempValue);
            LiquorValid = double.TryParse(txtLiquorFee.Text, out lTempValue);
            // check values
            if (foodValid && PreparedFoodValid && LiquorValid)
            {
                // if values good
                //set properties
                ff.SaleTaxRate = strTempValue;
                ff.FoodFee = fTempValue;
                ff.PreparedFoodFee = pfTempValue;
                ff.LiquorFee = lTempValue;
                // save values in file
                sw = File.CreateText(ff.GroceryConfig);
                sw.WriteLine(ff.SaleTaxRate);
                sw.WriteLine(ff.FoodFee);
                sw.WriteLine(ff.PreparedFoodFee);
                sw.WriteLine(ff.LiquorFee);

                sw.Close();

                // go back to Form 1
                this.Hide();
            }
            else
            {
                // if values not good 
                // replace all text box values with current values

                ff.setValuesOnSecondForm();
            }
        }

        private void txtSaleTaxRate_Leave(object sender, EventArgs e)
        {
            bool taxValid = false;
            double strTempValue;
            taxValid = double.TryParse(txtSaleTaxRate.Text, out strTempValue);
            if (!taxValid || strTempValue>=1 || strTempValue<0)
            {
                txtSaleTaxRate.Focus();
                lblErrorMsg.Text = "Tax rate is not valid";
            }
            else
            {
                lblErrorMsg.Text = "";
            }
        }
    }
}
