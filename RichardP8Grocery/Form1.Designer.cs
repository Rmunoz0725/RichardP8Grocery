namespace RichardP8Grocery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblItemCost = new Label();
            txtItemCost = new TextBox();
            lvlNumofItems = new Label();
            txtNumofItems = new TextBox();
            lstOutput = new ListBox();
            lblTaxRate = new Label();
            txtTaxRate = new TextBox();
            btnCalcPrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(448, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 0;
            label1.Text = "Richard's Grocery Store";
            // 
            // lblItemCost
            // 
            lblItemCost.AutoSize = true;
            lblItemCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemCost.Location = new Point(53, 72);
            lblItemCost.Name = "lblItemCost";
            lblItemCost.Size = new Size(61, 15);
            lblItemCost.TabIndex = 1;
            lblItemCost.Text = "Item Cost";
            // 
            // txtItemCost
            // 
            txtItemCost.Location = new Point(182, 69);
            txtItemCost.Name = "txtItemCost";
            txtItemCost.Size = new Size(146, 23);
            txtItemCost.TabIndex = 2;
            // 
            // lvlNumofItems
            // 
            lvlNumofItems.AutoSize = true;
            lvlNumofItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lvlNumofItems.Location = new Point(53, 123);
            lvlNumofItems.Name = "lvlNumofItems";
            lvlNumofItems.Size = new Size(103, 15);
            lvlNumofItems.TabIndex = 3;
            lvlNumofItems.Text = "Number of Items";
            // 
            // txtNumofItems
            // 
            txtNumofItems.Location = new Point(182, 120);
            txtNumofItems.Name = "txtNumofItems";
            txtNumofItems.Size = new Size(146, 23);
            txtNumofItems.TabIndex = 4;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(53, 232);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(694, 154);
            lstOutput.TabIndex = 7;
            lstOutput.TabStop = false;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTaxRate.Location = new Point(53, 181);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(55, 15);
            lblTaxRate.TabIndex = 5;
            lblTaxRate.Text = "Tax Rate";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(182, 178);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(146, 23);
            txtTaxRate.TabIndex = 6;
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Location = new Point(75, 415);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(122, 23);
            btnCalcPrice.TabIndex = 8;
            btnCalcPrice.Text = "Calculate Final &Price";
            btnCalcPrice.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(359, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnPrepareFood_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(653, 415);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcPrice);
            Controls.Add(txtTaxRate);
            Controls.Add(lblTaxRate);
            Controls.Add(lstOutput);
            Controls.Add(txtNumofItems);
            Controls.Add(lvlNumofItems);
            Controls.Add(txtItemCost);
            Controls.Add(lblItemCost);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Richard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblItemCost;
        private TextBox txtItemCost;
        private Label lvlNumofItems;
        private TextBox txtNumofItems;
        private ListBox lstOutput;
        private Label lblTaxRate;
        private TextBox txtTaxRate;
        private Button btnCalcPrice;
        private Button btnClear;
        private Button btnQuit;
    }
}
