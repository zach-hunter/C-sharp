namespace Zach_Hunter_GUIHW4
{
    partial class History
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
            this.HistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryRichTextBox
            // 
            this.HistoryRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.HistoryRichTextBox.Name = "HistoryRichTextBox";
            this.HistoryRichTextBox.Size = new System.Drawing.Size(216, 179);
            this.HistoryRichTextBox.TabIndex = 0;
            this.HistoryRichTextBox.Text = "";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 197);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(216, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 229);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HistoryRichTextBox);
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HistoryRichTextBox;
        private System.Windows.Forms.Button CloseButton;
    }
}