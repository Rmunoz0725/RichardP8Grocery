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
            txtItemName.Clear();
            txtItemCost.Clear();
            txtNumofItems.Clear();
            lstOutput.Items.Clear();
            txtItemName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            string groceryItem;
            double saleTaxRate = .0875;
            double subTotal, price, totalPrice, totalTaxPrice;
            int numItems;

            // input
            price = double.Parse(txtItemCost.Text);
            numItems = int.Parse(txtNumofItems.Text);
            groceryItem = txtItemName.Text;


            // processing
            subTotal = price * numItems;
            totalTaxPrice = subTotal * saleTaxRate;
            totalPrice = totalTaxPrice + subTotal;


            // output
            lstOutput.Items.Add("Name of item scanned to buy is " + groceryItem);
            lstOutput.Items.Add("Total Number of Items is " + numItems.ToString("N0"));
            lstOutput.Items.Add("Item Cost is " + price.ToString("C2"));
            lstOutput.Items.Add("Tax Rate is " + saleTaxRate.ToString("P2"));
            lstOutput.Items.Add("Sub total is " + subTotal.ToString("C2")); ;
            lstOutput.Items.Add("Tax Price left to add is " + totalTaxPrice.ToString("C2"));
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

        private void txtItemName_Enter(object sender, EventArgs e)
        {
            txtItemName.BackColor = Color.Bisque;
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            txtItemName.BackColor = SystemColors.Window;
        }
    }
}
