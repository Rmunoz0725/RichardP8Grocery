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
            txtNumItems.Clear();
            lstOutput.Items.Clear();
            txtItemName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            string GroceryItem;
            double saleTaxRate = .0875;
            double subTotal, itemPrice, totalPrice, totalTaxPrice;
            int totalItems;
            bool ItemPriceValid, NumItemValid;

            ItemPriceValid = double.TryParse(txtItemCost.Text, out itemPrice);
            NumItemValid = int.TryParse(txtNumItems.Text, out totalItems);

            //if statement here
            if (ItemPriceValid && NumItemValid)
            {
                // it is a good idea to dave string input to a variable
                GroceryItem = txtItemName.Text;
                // input
                itemPrice = double.Parse(txtItemCost.Text);
                totalItems = int.Parse(txtNumItems.Text);
                GroceryItem = txtItemName.Text;

                // processing
                subTotal = itemPrice * totalItems;
                totalTaxPrice = subTotal * saleTaxRate;
                totalPrice = totalTaxPrice + subTotal;

                // output
                lstOutput.Items.Add("Item scanned to buy is " + GroceryItem);
                lstOutput.Items.Add("Total Number of Items is " + totalItems.ToString("N0"));
                lstOutput.Items.Add("Item Cost is " + itemPrice.ToString("C2"));
                lstOutput.Items.Add("Tax Rate is " + saleTaxRate.ToString("P2"));
                lstOutput.Items.Add("Sub total is " + subTotal.ToString("C2")); ;
                lstOutput.Items.Add("Tax amount is " + totalTaxPrice.ToString("C2"));
                lstOutput.Items.Add("Total Price is " + totalPrice.ToString("C2"));

                //this changes the focus of the clear button
                btnClear.Focus();
            }else
            {
                if (!ItemPriceValid)
                {
                  lstOutput.Items.Add("Please enter a numeric entry for Item Cost");
                }
                if (!NumItemValid)
                {
                  lstOutput.Items.Add("Please enter a numeric entry Number of Items");
                }
            }
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
            txtNumItems.BackColor = Color.Bisque;
        }

        private void txtNumofItems_Leave(object sender, EventArgs e)
        {
            txtNumItems.BackColor = SystemColors.Window;
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
