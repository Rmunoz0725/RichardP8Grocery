namespace RichardP8Grocery
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSaleTaxRate = new Label();
            txtSaleTaxRate = new TextBox();
            lblFoodFee = new Label();
            txtFoodFee = new TextBox();
            lblPreparedFoodFee = new Label();
            txtPreparedFoodFee = new TextBox();
            lblLiquorFee = new Label();
            txtLiquorFee = new TextBox();
            label5 = new Label();
            btnSetReturn = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblSaleTaxRate
            // 
            lblSaleTaxRate.AutoSize = true;
            lblSaleTaxRate.Location = new Point(54, 92);
            lblSaleTaxRate.Name = "lblSaleTaxRate";
            lblSaleTaxRate.Size = new Size(68, 15);
            lblSaleTaxRate.TabIndex = 0;
            lblSaleTaxRate.Text = "SaleTaxRate";
            // 
            // txtSaleTaxRate
            // 
            txtSaleTaxRate.Location = new Point(203, 89);
            txtSaleTaxRate.Name = "txtSaleTaxRate";
            txtSaleTaxRate.Size = new Size(100, 23);
            txtSaleTaxRate.TabIndex = 1;
            txtSaleTaxRate.Leave += txtSaleTaxRate_Leave;
            // 
            // lblFoodFee
            // 
            lblFoodFee.AutoSize = true;
            lblFoodFee.Location = new Point(54, 154);
            lblFoodFee.Name = "lblFoodFee";
            lblFoodFee.Size = new Size(52, 15);
            lblFoodFee.TabIndex = 2;
            lblFoodFee.Text = "FoodFee";
            // 
            // txtFoodFee
            // 
            txtFoodFee.Location = new Point(203, 151);
            txtFoodFee.Name = "txtFoodFee";
            txtFoodFee.Size = new Size(100, 23);
            txtFoodFee.TabIndex = 3;
            // 
            // lblPreparedFoodFee
            // 
            lblPreparedFoodFee.AutoSize = true;
            lblPreparedFoodFee.Location = new Point(54, 219);
            lblPreparedFoodFee.Name = "lblPreparedFoodFee";
            lblPreparedFoodFee.Size = new Size(99, 15);
            lblPreparedFoodFee.TabIndex = 4;
            lblPreparedFoodFee.Text = "PreparedFoodFee";
            // 
            // txtPreparedFoodFee
            // 
            txtPreparedFoodFee.Location = new Point(203, 216);
            txtPreparedFoodFee.Name = "txtPreparedFoodFee";
            txtPreparedFoodFee.Size = new Size(100, 23);
            txtPreparedFoodFee.TabIndex = 5;
            // 
            // lblLiquorFee
            // 
            lblLiquorFee.AutoSize = true;
            lblLiquorFee.Location = new Point(54, 279);
            lblLiquorFee.Name = "lblLiquorFee";
            lblLiquorFee.Size = new Size(59, 15);
            lblLiquorFee.TabIndex = 6;
            lblLiquorFee.Text = "LiquorFee";
            // 
            // txtLiquorFee
            // 
            txtLiquorFee.Location = new Point(203, 276);
            txtLiquorFee.Name = "txtLiquorFee";
            txtLiquorFee.Size = new Size(100, 23);
            txtLiquorFee.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 28);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 8;
            label5.Text = "Configuration Settings";
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(117, 345);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(126, 38);
            btnSetReturn.TabIndex = 9;
            btnSetReturn.Text = "&Set && Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += btnSetReturn_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Location = new Point(137, 402);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(81, 15);
            lblErrorMsg.TabIndex = 10;
            lblErrorMsg.Text = "Error Message";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 426);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnSetReturn);
            Controls.Add(label5);
            Controls.Add(txtLiquorFee);
            Controls.Add(lblLiquorFee);
            Controls.Add(txtPreparedFoodFee);
            Controls.Add(lblPreparedFoodFee);
            Controls.Add(txtFoodFee);
            Controls.Add(lblFoodFee);
            Controls.Add(txtSaleTaxRate);
            Controls.Add(lblSaleTaxRate);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaleTaxRate;
        private Label lblFoodFee;
        private Label lblPreparedFoodFee;
        private Label lblLiquorFee;
        private Label label5;
        private Button btnSetReturn;
        public TextBox txtFoodFee;
        public TextBox txtPreparedFoodFee;
        public TextBox txtLiquorFee;
        public TextBox txtSaleTaxRate;
        private Label lblErrorMsg;
    }
}