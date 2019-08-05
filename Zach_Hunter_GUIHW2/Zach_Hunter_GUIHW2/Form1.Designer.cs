namespace Zach_Hunter_GUIHW2
{
    partial class ISBNChecker
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
            this.ISBNSelector = new System.Windows.Forms.ComboBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ISBNSelector
            // 
            this.ISBNSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISBNSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNSelector.FormattingEnabled = true;
            this.ISBNSelector.Items.AddRange(new object[] {
            "10",
            "13"});
            this.ISBNSelector.Location = new System.Drawing.Point(70, 6);
            this.ISBNSelector.Name = "ISBNSelector";
            this.ISBNSelector.Size = new System.Drawing.Size(43, 28);
            this.ISBNSelector.TabIndex = 0;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(12, 9);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(56, 20);
            this.ISBNLabel.TabIndex = 2;
            this.ISBNLabel.Text = "ISBN -";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(13, 44);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(160, 26);
            this.ISBNTextBox.TabIndex = 3;
            this.ISBNTextBox.Text = "ISBN";
            this.ISBNTextBox.Enter += new System.EventHandler(this.ISBNTextBox_Enter);
            this.ISBNTextBox.Leave += new System.EventHandler(this.ISBNTextBox_Leave);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(13, 77);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(160, 23);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(16, 107);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(157, 96);
            this.ResultTextBox.TabIndex = 5;
            this.ResultTextBox.Text = "";
            // 
            // ISBNChecker
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 228);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.ISBNSelector);
            this.Name = "ISBNChecker";
            this.Text = "ISBN Checker";
            this.Load += new System.EventHandler(this.ISBNChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ISBNSelector;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RichTextBox ResultTextBox;
    }
}

