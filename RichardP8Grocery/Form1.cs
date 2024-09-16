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

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
