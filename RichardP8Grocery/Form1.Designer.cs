﻿namespace RichardP8Grocery
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 0;
            label1.Text = "Richard's Grocery Store";
            // 
            // lblItemCost
            // 
            lblItemCost.AutoSize = true;
            lblItemCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemCost.Location = new Point(401, 67);
            lblItemCost.Name = "lblItemCost";
            lblItemCost.Size = new Size(61, 15);
            lblItemCost.TabIndex = 3;
            lblItemCost.Text = "Item Cost";
            // 
            // txtItemCost
            // 
            txtItemCost.Location = new Point(553, 64);
            txtItemCost.Name = "txtItemCost";
            txtItemCost.Size = new Size(146, 23);
            txtItemCost.TabIndex = 4;
            txtItemCost.Enter += txtItemCost_Enter;
            txtItemCost.Leave += txtItemCost_Leave;
            // 
            // lblNumofItems
            // 
            lblNumofItems.AutoSize = true;
            lblNumofItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumofItems.Location = new Point(401, 123);
            lblNumofItems.Name = "lblNumofItems";
            lblNumofItems.Size = new Size(103, 15);
            lblNumofItems.TabIndex = 5;
            lblNumofItems.Text = "Number of Items";
            // 
            // txtNumItems
            // 
            txtNumItems.Location = new Point(553, 123);
            txtNumItems.Name = "txtNumItems";
            txtNumItems.Size = new Size(146, 23);
            txtNumItems.TabIndex = 6;
            txtNumItems.Enter += txtNumofItems_Enter;
            txtNumItems.Leave += txtNumofItems_Leave;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(53, 194);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(694, 169);
            lstOutput.TabIndex = 7;
            lstOutput.TabStop = false;
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Location = new Point(78, 393);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(122, 23);
            btnCalcPrice.TabIndex = 8;
            btnCalcPrice.Text = "Calculate Final &Price";
            btnCalcPrice.UseVisualStyleBackColor = true;
            btnCalcPrice.Click += btnCalcPrice_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(360, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(651, 393);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemName.Location = new Point(78, 96);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(82, 15);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Grocery Item";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(182, 93);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(147, 23);
            txtItemName.TabIndex = 2;
            txtItemName.Enter += txtItemName_Enter;
            txtItemName.Leave += txtItemName_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
