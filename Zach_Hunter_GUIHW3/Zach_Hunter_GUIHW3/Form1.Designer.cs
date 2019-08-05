namespace Zach_Hunter_GUIHW3
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
            this.RepLabel = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.SaleLabel = new System.Windows.Forms.Label();
            this.SaleCountLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaleAmountTextBox = new System.Windows.Forms.TextBox();
            this.AddSaleButton = new System.Windows.Forms.Button();
            this.HighestButton = new System.Windows.Forms.Button();
            this.LowestButton = new System.Windows.Forms.Button();
            this.HighLowTextBox = new System.Windows.Forms.TextBox();
            this.TopNButton = new System.Windows.Forms.Button();
            this.ClearSalesButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepLabel
            // 
            this.RepLabel.AutoSize = true;
            this.RepLabel.Location = new System.Drawing.Point(6, 33);
            this.RepLabel.Name = "RepLabel";
            this.RepLabel.Size = new System.Drawing.Size(61, 13);
            this.RepLabel.TabIndex = 0;
            this.RepLabel.Text = "Rep Name:";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.AddSaleButton);
            this.GroupBox.Controls.Add(this.SaleAmountTextBox);
            this.GroupBox.Controls.Add(this.NameTextBox);
            this.GroupBox.Controls.Add(this.SaleCountLabel);
            this.GroupBox.Controls.Add(this.SaleLabel);
            this.GroupBox.Controls.Add(this.RepLabel);
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(200, 117);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Sales Data";
            // 
            // SaleLabel
            // 
            this.SaleLabel.AutoSize = true;
            this.SaleLabel.Location = new System.Drawing.Point(6, 61);
            this.SaleLabel.Name = "SaleLabel";
            this.SaleLabel.Size = new System.Drawing.Size(70, 13);
            this.SaleLabel.TabIndex = 1;
            this.SaleLabel.Text = "Sale Amount:";
            // 
            // SaleCountLabel
            // 
            this.SaleCountLabel.AutoSize = true;
            this.SaleCountLabel.Location = new System.Drawing.Point(6, 90);
            this.SaleCountLabel.Name = "SaleCountLabel";
            this.SaleCountLabel.Size = new System.Drawing.Size(65, 13);
            this.SaleCountLabel.TabIndex = 2;
            this.SaleCountLabel.Text = "Sale Count: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // SaleAmountTextBox
            // 
            this.SaleAmountTextBox.Location = new System.Drawing.Point(84, 58);
            this.SaleAmountTextBox.Name = "SaleAmountTextBox";
            this.SaleAmountTextBox.Size = new System.Drawing.Size(110, 20);
            this.SaleAmountTextBox.TabIndex = 4;
            // 
            // AddSaleButton
            // 
            this.AddSaleButton.Location = new System.Drawing.Point(119, 85);
            this.AddSaleButton.Name = "AddSaleButton";
            this.AddSaleButton.Size = new System.Drawing.Size(75, 23);
            this.AddSaleButton.TabIndex = 5;
            this.AddSaleButton.Text = "Add Sale";
            this.AddSaleButton.UseVisualStyleBackColor = true;
            this.AddSaleButton.Click += new System.EventHandler(this.AddSaleButton_Click);
            // 
            // HighestButton
            // 
            this.HighestButton.Location = new System.Drawing.Point(13, 136);
            this.HighestButton.Name = "HighestButton";
            this.HighestButton.Size = new System.Drawing.Size(75, 23);
            this.HighestButton.TabIndex = 2;
            this.HighestButton.Text = "Highest";
            this.HighestButton.UseVisualStyleBackColor = true;
            // 
            // LowestButton
            // 
            this.LowestButton.Location = new System.Drawing.Point(13, 166);
            this.LowestButton.Name = "LowestButton";
            this.LowestButton.Size = new System.Drawing.Size(75, 23);
            this.LowestButton.TabIndex = 3;
            this.LowestButton.Text = "Lowest";
            this.LowestButton.UseVisualStyleBackColor = true;
            // 
            // HighLowTextBox
            // 
            this.HighLowTextBox.Enabled = false;
            this.HighLowTextBox.Location = new System.Drawing.Point(96, 138);
            this.HighLowTextBox.Name = "HighLowTextBox";
            this.HighLowTextBox.Size = new System.Drawing.Size(110, 20);
            this.HighLowTextBox.TabIndex = 4;
            // 
            // TopNButton
            // 
            this.TopNButton.Location = new System.Drawing.Point(131, 164);
            this.TopNButton.Name = "TopNButton";
            this.TopNButton.Size = new System.Drawing.Size(75, 23);
            this.TopNButton.TabIndex = 5;
            this.TopNButton.Text = "Find Top N";
            this.TopNButton.UseVisualStyleBackColor = true;
            // 
            // ClearSalesButton
            // 
            this.ClearSalesButton.Location = new System.Drawing.Point(13, 233);
            this.ClearSalesButton.Name = "ClearSalesButton";
            this.ClearSalesButton.Size = new System.Drawing.Size(75, 23);
            this.ClearSalesButton.TabIndex = 6;
            this.ClearSalesButton.Text = "Clear Sales Data";
            this.ClearSalesButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(131, 233);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ResultsRichTextBox
            // 
            this.ResultsRichTextBox.Enabled = false;
            this.ResultsRichTextBox.Location = new System.Drawing.Point(219, 12);
            this.ResultsRichTextBox.Name = "ResultsRichTextBox";
            this.ResultsRichTextBox.Size = new System.Drawing.Size(241, 244);
            this.ResultsRichTextBox.TabIndex = 8;
            this.ResultsRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 272);
            this.Controls.Add(this.ResultsRichTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ClearSalesButton);
            this.Controls.Add(this.TopNButton);
            this.Controls.Add(this.HighLowTextBox);
            this.Controls.Add(this.LowestButton);
            this.Controls.Add(this.HighestButton);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "Sales Data Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RepLabel;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button AddSaleButton;
        private System.Windows.Forms.TextBox SaleAmountTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SaleCountLabel;
        private System.Windows.Forms.Label SaleLabel;
        private System.Windows.Forms.Button HighestButton;
        private System.Windows.Forms.Button LowestButton;
        private System.Windows.Forms.TextBox HighLowTextBox;
        private System.Windows.Forms.Button TopNButton;
        private System.Windows.Forms.Button ClearSalesButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RichTextBox ResultsRichTextBox;
    }
}

