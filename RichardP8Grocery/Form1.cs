using System.Security;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Richard Munoz
namespace RichardP8Grocery
{
    public partial class Form1 : Form
    {
        private string ItemType;
        const string FOOD = "Food";
        const string PREPARED_FOOD = "Prepared Food";
        const string LIQUOR = "Liquor";

        private string ItemTransactionLog = "ItemTransLog.txt";

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
            double subAmount, itemPrice, totalPrice, taxAmount;
            int totalItems;
            bool ItemPriceValid, NumItemValid;

            // declare the object sw which is an instance of the class SteamWrite
            StreamWriter sw;

            ItemPriceValid = double.TryParse(txtItemCost.Text, out itemPrice);
            NumItemValid = int.TryParse(txtNumItems.Text, out totalItems);

            //if statement here
            if (ItemPriceValid && NumItemValid)
            {
                switch (ItemType)
                {
                    case FOOD:
                        saleTaxRate = 0;
                        break;
                    case PREPARED_FOOD:
                        saleTaxRate = .08;
                        break;
                    case LIQUOR:
                        saleTaxRate = .10;
                        break;
                    default:
                        lstOutput.Items.Add("This should never happen");
                        break;
                }
                // it is a good idea to save string input to a variable
                GroceryItem = txtItemName.Text;
                // input
                itemPrice = double.Parse(txtItemCost.Text);
                totalItems = int.Parse(txtNumItems.Text);

                // processing
                subAmount = itemPrice * totalItems;
                taxAmount = subAmount * saleTaxRate;
                totalPrice = subAmount + taxAmount;

                // output
                lstOutput.Items.Add("Item scanned to buy is " + GroceryItem);
                lstOutput.Items.Add("Total Number of Items is " + totalItems.ToString("N0"));
                lstOutput.Items.Add("Item is a " + ItemType);
                lstOutput.Items.Add("Tax Rate is " + saleTaxRate.ToString("P2"));
                lstOutput.Items.Add("Item Cost is " + itemPrice.ToString("C2"));
                lstOutput.Items.Add("Sub amount is " + subAmount.ToString("C2"));
                lstOutput.Items.Add("Total tax amount is " + taxAmount.ToString("C2"));
                lstOutput.Items.Add("Total Price is " + totalPrice.ToString("C2"));
                sw = File.AppendText("ItemTransactionLog");
                sw.WriteLine("******* Beginning of Transaction at " + DateTime.Now.ToString("G") + " *******");
                sw.WriteLine("Item scanned to buy is " + GroceryItem);
                sw.WriteLine("Total Number of Items is " + totalItems.ToString("N0"));
                sw.WriteLine("Item is a " + ItemType);
                sw.WriteLine("Tax Rate is " + saleTaxRate.ToString("P2"));
                sw.WriteLine("Item Cost is " + itemPrice.ToString("C2"));
                sw.WriteLine("Sub amount is " + subAmount.ToString("C2"));
                sw.WriteLine("Total tax amount is " + taxAmount.ToString("C2"));
                sw.WriteLine("Total Price is " + totalPrice.ToString("C2"));

                sw.Close();

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
                ItemType = FOOD;


            }
        }

        private void rdoPrepared_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrepared.Checked)
            {
                ItemType = PREPARED_FOOD;
            }
        }

        private void rdoLiquor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLiquor.Checked)
            {
                ItemType = LIQUOR;
            }
        }
    }
}
