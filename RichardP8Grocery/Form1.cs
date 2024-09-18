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

            //this changes the focus of the clear button
            // btnClear.Focus();
            txtItemCost.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            // input



            // processing



            // output

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
