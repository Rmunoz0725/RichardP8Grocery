using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Richard Munoz
namespace RichardP8Grocery
{
    public partial class Form1 : Form
    {
        private string ItemType;
        const string Food = "Food";
        const string Prepared_Food = "Prepared Food";
        const string Liquor = "Liquor";

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
            rdoFood.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show
                ("Do you really want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }
      
        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            string GroceryItem;
            double saleTaxRate = .08875;
            double subAmount, subTotal, itemPrice, totalPrice, totalTaxPrice, totalSetTaxPrice;
            int totalItems;
            bool ItemPriceValid, NumItemValid;

            double ItemTypeFee = 0;

            ItemPriceValid = double.TryParse(txtItemCost.Text, out itemPrice);
            NumItemValid = int.TryParse(txtNumItems.Text, out totalItems);

            //if statement here
            if (ItemPriceValid && NumItemValid)
            {
                switch (ItemType)
                {
                    case Food:
                        ItemTypeFee = 0;
                        break;
                    case Prepared_Food:
                        ItemTypeFee = .07;
                        break;
                    case Liquor:
                        ItemTypeFee = .1;
                        break;
                    default:
                        lstOutput.Items.Add("This should never happen");
                        break;
                }
                // it is a good idea to dave string input to a variable
                GroceryItem = txtItemName.Text;
                // input
                itemPrice = double.Parse(txtItemCost.Text);
                totalItems = int.Parse(txtNumItems.Text);

                // processing
                subAmount = itemPrice * totalItems;
                totalSetTaxPrice = subAmount * ItemTypeFee;
                subTotal = totalSetTaxPrice + subAmount;
                totalTaxPrice = subTotal * saleTaxRate;
                totalPrice = totalTaxPrice + subTotal;

                // output
                lstOutput.Items.Add("Item scanned to buy is " + GroceryItem);
                lstOutput.Items.Add("Item is a " + ItemType);
                lstOutput.Items.Add("Item Type Fee is " + ItemTypeFee.ToString("P2"));
                lstOutput.Items.Add("Total Number of Items is " + totalItems.ToString("N0"));
                lstOutput.Items.Add("Item Cost is " + itemPrice.ToString("C2"));
                lstOutput.Items.Add("Tax Rate is " + saleTaxRate.ToString("P2"));
                lstOutput.Items.Add("Sub amount is " + subAmount.ToString("C2"));
                lstOutput.Items.Add("Tax amount is " + totalTaxPrice.ToString("C2"));
                lstOutput.Items.Add("Set Tax Amount is " + totalSetTaxPrice.ToString("C2"));
                lstOutput.Items.Add("Total Price is " + totalPrice.ToString("C2"));

                //this changes the focus of the clear button
                btnClear.Focus();
            }
            else
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // this makes the checked changed procedure run ( it doesn't run if set in designer)
            rdoFood.Checked = true;
        }

        private void rdoFood_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFood.Checked)
            {
                ItemType = Food;
            }
        }

        private void rdoPrepared_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrepared.Checked)
            {
                ItemType = Prepared_Food;
            }
        }

        private void rdoLiquor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLiquor.Checked)
            {
                ItemType = Liquor;
            }
        }
    }
}
