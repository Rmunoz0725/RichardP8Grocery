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
            lblNumofItems = new Label();
            txtNumItems = new TextBox();
            lstOutput = new ListBox();
            btnCalcPrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lblItemName = new Label();
            txtItemName = new TextBox();
            rdoFood = new RadioButton();
            rdoPrepared = new RadioButton();
            rdoLiquor = new RadioButton();
            grpItemType = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            grpItemType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(292, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 0;
            label1.Text = "Richard's Grocery Store";
            // 
            // lblItemCost
            // 
            lblItemCost.AutoSize = true;
            lblItemCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemCost.Location = new Point(401, 120);
            lblItemCost.Name = "lblItemCost";
            lblItemCost.Size = new Size(61, 15);
            lblItemCost.TabIndex = 7;
            lblItemCost.Text = "Item Cost";
            // 
            // txtItemCost
            // 
            txtItemCost.Location = new Point(543, 112);
            txtItemCost.Name = "txtItemCost";
            txtItemCost.Size = new Size(146, 23);
            txtItemCost.TabIndex = 8;
            txtItemCost.Enter += txtItemCost_Enter;
            txtItemCost.Leave += txtItemCost_Leave;
            // 
            // lblNumofItems
            // 
            lblNumofItems.AutoSize = true;
            lblNumofItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumofItems.Location = new Point(401, 169);
            lblNumofItems.Name = "lblNumofItems";
            lblNumofItems.Size = new Size(103, 15);
            lblNumofItems.TabIndex = 9;
            lblNumofItems.Text = "Number of Items";
            // 
            // txtNumItems
            // 
            txtNumItems.Location = new Point(543, 166);
            txtNumItems.Name = "txtNumItems";
            txtNumItems.Size = new Size(146, 23);
            txtNumItems.TabIndex = 10;
            txtNumItems.Enter += txtNumofItems_Enter;
            txtNumItems.Leave += txtNumofItems_Leave;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(55, 209);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(694, 169);
            lstOutput.TabIndex = 11;
            lstOutput.TabStop = false;
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Location = new Point(78, 404);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(140, 23);
            btnCalcPrice.TabIndex = 12;
            btnCalcPrice.Text = "Calculate Final &Price";
            btnCalcPrice.UseVisualStyleBackColor = true;
            btnCalcPrice.Click += btnCalcPrice_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(355, 404);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(599, 404);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(100, 23);
            btnQuit.TabIndex = 14;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemName.Location = new Point(96, 142);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(82, 15);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "Grocery Item";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(193, 139);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(147, 23);
            txtItemName.TabIndex = 6;
            txtItemName.Enter += txtItemName_Enter;
            txtItemName.Leave += txtItemName_Leave;
            // 
            // rdoFood
            // 
            rdoFood.AutoSize = true;
            rdoFood.Location = new Point(41, 22);
            rdoFood.Name = "rdoFood";
            rdoFood.Size = new Size(52, 19);
            rdoFood.TabIndex = 2;
            rdoFood.Text = "Food";
            rdoFood.UseVisualStyleBackColor = true;
            rdoFood.CheckedChanged += rdoFood_CheckedChanged;
            // 
            // rdoPrepared
            // 
            rdoPrepared.AutoSize = true;
            rdoPrepared.Location = new Point(288, 22);
            rdoPrepared.Name = "rdoPrepared";
            rdoPrepared.Size = new Size(102, 19);
            rdoPrepared.TabIndex = 3;
            rdoPrepared.TabStop = true;
            rdoPrepared.Text = "Prepared Food";
            rdoPrepared.UseVisualStyleBackColor = true;
            rdoPrepared.CheckedChanged += rdoPrepared_CheckedChanged;
            // 
            // rdoLiquor
            // 
            rdoLiquor.AutoSize = true;
            rdoLiquor.Location = new Point(544, 22);
            rdoLiquor.Name = "rdoLiquor";
            rdoLiquor.Size = new Size(59, 19);
            rdoLiquor.TabIndex = 4;
            rdoLiquor.TabStop = true;
            rdoLiquor.Text = "Liquor";
            rdoLiquor.UseVisualStyleBackColor = true;
            rdoLiquor.CheckedChanged += rdoLiquor_CheckedChanged;
            // 
            // grpItemType
            // 
            grpItemType.Controls.Add(rdoFood);
            grpItemType.Controls.Add(rdoLiquor);
            grpItemType.Controls.Add(rdoPrepared);
            grpItemType.Location = new Point(55, 37);
            grpItemType.Name = "grpItemType";
            grpItemType.Size = new Size(694, 53);
            grpItemType.TabIndex = 1;
            grpItemType.TabStop = false;
            grpItemType.Text = "Item Type";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpItemType);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcPrice);
            Controls.Add(lstOutput);
            Controls.Add(txtNumItems);
            Controls.Add(lblNumofItems);
            Controls.Add(txtItemCost);
            Controls.Add(lblItemCost);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Richard";
            Load += Form1_Load;
            grpItemType.ResumeLayout(false);
            grpItemType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblItemCost;
        private TextBox txtItemCost;
        private Label lblNumofItems;
        private TextBox txtNumItems;
        private ListBox lstOutput;
        private Button btnCalcPrice;
        private Button btnClear;
        private Button btnQuit;
        private Label lblItemName;
        private TextBox txtItemName;
        private RadioButton rdoFood;
        private RadioButton rdoPrepared;
        private RadioButton rdoLiquor;
        private GroupBox grpItemType;
        private OpenFileDialog openFileDialog1;
    }
}
