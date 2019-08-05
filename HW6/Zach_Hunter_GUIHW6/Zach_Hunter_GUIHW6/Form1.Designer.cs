namespace Zach_Hunter_GUIHW6
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
            this.ConversionSelectionBox = new System.Windows.Forms.ComboBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToRadioButton = new System.Windows.Forms.RadioButton();
            this.ConvertFromRadioButton = new System.Windows.Forms.RadioButton();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.AddConversionButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.DeleteConversionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConversionSelectionBox
            // 
            this.ConversionSelectionBox.FormattingEnabled = true;
            this.ConversionSelectionBox.Location = new System.Drawing.Point(107, 12);
            this.ConversionSelectionBox.Name = "ConversionSelectionBox";
            this.ConversionSelectionBox.Size = new System.Drawing.Size(179, 21);
            this.ConversionSelectionBox.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(13, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(77, 20);
            this.InputTextBox.TabIndex = 0;
            // 
            // ConvertToRadioButton
            // 
            this.ConvertToRadioButton.AutoSize = true;
            this.ConvertToRadioButton.Location = new System.Drawing.Point(107, 38);
            this.ConvertToRadioButton.Name = "ConvertToRadioButton";
            this.ConvertToRadioButton.Size = new System.Drawing.Size(78, 17);
            this.ConvertToRadioButton.TabIndex = 2;
            this.ConvertToRadioButton.Text = "Convert To";
            this.ConvertToRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvertFromRadioButton
            // 
            this.ConvertFromRadioButton.AutoSize = true;
            this.ConvertFromRadioButton.Location = new System.Drawing.Point(198, 38);
            this.ConvertFromRadioButton.Name = "ConvertFromRadioButton";
            this.ConvertFromRadioButton.Size = new System.Drawing.Size(88, 17);
            this.ConvertFromRadioButton.TabIndex = 3;
            this.ConvertFromRadioButton.Text = "Convert From";
            this.ConvertFromRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(292, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 72);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Location = new System.Drawing.Point(13, 64);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(273, 20);
            this.OutputTextBox.TabIndex = 5;
            // 
            // AddConversionButton
            // 
            this.AddConversionButton.Location = new System.Drawing.Point(12, 104);
            this.AddConversionButton.Name = "AddConversionButton";
            this.AddConversionButton.Size = new System.Drawing.Size(104, 23);
            this.AddConversionButton.TabIndex = 6;
            this.AddConversionButton.Text = "Add Conversion";
            this.AddConversionButton.UseVisualStyleBackColor = true;
            this.AddConversionButton.Click += new System.EventHandler(this.AddConversionButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(292, 104);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // DeleteConversionButton
            // 
            this.DeleteConversionButton.Location = new System.Drawing.Point(122, 104);
            this.DeleteConversionButton.Name = "DeleteConversionButton";
            this.DeleteConversionButton.Size = new System.Drawing.Size(104, 23);
            this.DeleteConversionButton.TabIndex = 8;
            this.DeleteConversionButton.Text = "Delete Conversion";
            this.DeleteConversionButton.UseVisualStyleBackColor = true;
            this.DeleteConversionButton.Click += new System.EventHandler(this.DeleteConversionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 130);
            this.Controls.Add(this.DeleteConversionButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.AddConversionButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertFromRadioButton);
            this.Controls.Add(this.ConvertToRadioButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ConversionSelectionBox);
            this.Name = "Form1";
            this.Text = "Conversion App";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConversionSelectionBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.RadioButton ConvertToRadioButton;
        private System.Windows.Forms.RadioButton ConvertFromRadioButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button AddConversionButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button DeleteConversionButton;
    }
}

