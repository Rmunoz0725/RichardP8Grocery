using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RichardP8Grocery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemCost.Clear();
            txtNumofItems.Clear();
            lstOutput.Items.Clear();
            txtItemCost.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double taxRate = .0875;
            double price, totalPrice, taxAmount;

            // input
            price = double.Parse(txtItemCost.Text);


            // processing
            taxAmount = price * taxRate;
            totalPrice = taxAmount + price;

            // output
            lstOutput.Items.Add("Price is " + price.ToString("C2"));
            lstOutput.Items.Add("Tax Rate is " + taxRate.ToString("P2"));
            lstOutput.Items.Add("Tax amount is " + taxAmount.ToString("C2"));
            lstOutput.Items.Add("Total Price is " + totalPrice.ToString("C2"));

            //this changes the focus of the clear button
            btnClear.Focus();
        }

        private void txtItemCost_Enter(object sender, EventArgs e)
        {
            txtItemCost.BackColor = Color.Bisque;
        }

        private void txtItemCost_Leave(object sender, EventArgs e)
        {
            txtItemCost.BackColor = SystemColors.Window;
        }

        private void txtNumofItems_Enter(object sender, EventArgs e)
        {
            txtNumofItems.BackColor = Color.Bisque;
        }

        private void txtNumofItems_Leave(object sender, EventArgs e)
        {
            txtNumofItems.BackColor = SystemColors.Window;
        }
    }
}
