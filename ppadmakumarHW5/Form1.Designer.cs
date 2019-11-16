namespace ppadmakumarHW5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblYearPurchased = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblDepriciationYears = new System.Windows.Forms.Label();
            this.lblDepreciationRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtYearPurchased = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDepreciationYears = new System.Windows.Forms.TextBox();
            this.txtDepreciationRate = new System.Windows.Forms.TextBox();
            this.btnStraightLine = new System.Windows.Forms.Button();
            this.btnDecliningBalance = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.erpPurchasePrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDepriciationYears = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDepriciationRate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDepriciationYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDepriciationRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(42, 42);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description of item :";
            // 
            // lblYearPurchased
            // 
            this.lblYearPurchased.AutoSize = true;
            this.lblYearPurchased.Location = new System.Drawing.Point(42, 78);
            this.lblYearPurchased.Name = "lblYearPurchased";
            this.lblYearPurchased.Size = new System.Drawing.Size(117, 17);
            this.lblYearPurchased.TabIndex = 1;
            this.lblYearPurchased.Text = "Year purchased :";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(42, 118);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(112, 17);
            this.lblPurchasePrice.TabIndex = 2;
            this.lblPurchasePrice.Text = "Purchase Price :";
            // 
            // lblDepriciationYears
            // 
            this.lblDepriciationYears.AutoSize = true;
            this.lblDepriciationYears.Location = new System.Drawing.Point(42, 164);
            this.lblDepriciationYears.Name = "lblDepriciationYears";
            this.lblDepriciationYears.Size = new System.Drawing.Size(208, 17);
            this.lblDepriciationYears.TabIndex = 3;
            this.lblDepriciationYears.Text = "No. of years to be depreciated :";
            // 
            // lblDepreciationRate
            // 
            this.lblDepreciationRate.AutoSize = true;
            this.lblDepreciationRate.Location = new System.Drawing.Point(42, 232);
            this.lblDepreciationRate.Name = "lblDepreciationRate";
            this.lblDepreciationRate.Size = new System.Drawing.Size(171, 17);
            this.lblDepreciationRate.TabIndex = 4;
            this.lblDepreciationRate.Text = "Depreciation Rate (in %) :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(265, 37);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(225, 22);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtYearPurchased
            // 
            this.txtYearPurchased.Location = new System.Drawing.Point(265, 75);
            this.txtYearPurchased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYearPurchased.Name = "txtYearPurchased";
            this.txtYearPurchased.Size = new System.Drawing.Size(125, 22);
            this.txtYearPurchased.TabIndex = 6;
            this.txtYearPurchased.Validating += new System.ComponentModel.CancelEventHandler(this.txtYearPurchased_Validating);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(265, 118);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(125, 22);
            this.txtPurchasePrice.TabIndex = 7;
            this.txtPurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPurchasePrice_Validating);
            // 
            // txtDepreciationYears
            // 
            this.txtDepreciationYears.Location = new System.Drawing.Point(45, 198);
            this.txtDepreciationYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepreciationYears.Name = "txtDepreciationYears";
            this.txtDepreciationYears.Size = new System.Drawing.Size(168, 22);
            this.txtDepreciationYears.TabIndex = 8;
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(45, 264);
            this.txtDepreciationRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(168, 22);
            this.txtDepreciationRate.TabIndex = 9;
            // 
            // btnStraightLine
            // 
            this.btnStraightLine.Location = new System.Drawing.Point(265, 170);
            this.btnStraightLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStraightLine.Name = "btnStraightLine";
            this.btnStraightLine.Size = new System.Drawing.Size(202, 50);
            this.btnStraightLine.TabIndex = 10;
            this.btnStraightLine.Text = "Calculate straight line depreciation";
            this.btnStraightLine.UseVisualStyleBackColor = true;
            this.btnStraightLine.Click += new System.EventHandler(this.btnStraightLine_Click);
            // 
            // btnDecliningBalance
            // 
            this.btnDecliningBalance.Location = new System.Drawing.Point(265, 235);
            this.btnDecliningBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecliningBalance.Name = "btnDecliningBalance";
            this.btnDecliningBalance.Size = new System.Drawing.Size(198, 51);
            this.btnDecliningBalance.TabIndex = 11;
            this.btnDecliningBalance.Text = "Calculate declining balance depreciation";
            this.btnDecliningBalance.UseVisualStyleBackColor = true;
            this.btnDecliningBalance.Click += new System.EventHandler(this.btnDecliningBalance_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(556, 37);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(576, 340);
            this.lstOutput.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(912, 392);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 27);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1031, 392);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // erpPurchasePrice
            // 
            this.erpPurchasePrice.ContainerControl = this;
            // 
            // erpDepriciationYears
            // 
            this.erpDepriciationYears.ContainerControl = this;
            // 
            // erpDepriciationRate
            // 
            this.erpDepriciationRate.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnDecliningBalance);
            this.Controls.Add(this.btnStraightLine);
            this.Controls.Add(this.txtDepreciationRate);
            this.Controls.Add(this.txtDepreciationYears);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtYearPurchased);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDepreciationRate);
            this.Controls.Add(this.lblDepriciationYears);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblYearPurchased);
            this.Controls.Add(this.lblDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Depriciation Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.erpPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDepriciationYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDepriciationRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblYearPurchased;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblDepriciationYears;
        private System.Windows.Forms.Label lblDepreciationRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtYearPurchased;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDepreciationYears;
        private System.Windows.Forms.TextBox txtDepreciationRate;
        private System.Windows.Forms.Button btnStraightLine;
        private System.Windows.Forms.Button btnDecliningBalance;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider erpPurchasePrice;
        private System.Windows.Forms.ErrorProvider erpDepriciationYears;
        private System.Windows.Forms.ErrorProvider erpDepriciationRate;
    }
}

