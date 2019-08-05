namespace Zach_Hunter_GUIHW6
{
    partial class AddForm
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
            this.AddNumber1Label = new System.Windows.Forms.Label();
            this.AddUnit1Label = new System.Windows.Forms.Label();
            this.AddNumber2Label = new System.Windows.Forms.Label();
            this.AddUnit2Label = new System.Windows.Forms.Label();
            this.AddNumber1TextBox = new System.Windows.Forms.TextBox();
            this.AddUnit1TextBox = new System.Windows.Forms.TextBox();
            this.AddNumber2TextBox = new System.Windows.Forms.TextBox();
            this.AddUnit2TextBox = new System.Windows.Forms.TextBox();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNumber1Label
            // 
            this.AddNumber1Label.AutoSize = true;
            this.AddNumber1Label.Location = new System.Drawing.Point(21, 9);
            this.AddNumber1Label.Name = "AddNumber1Label";
            this.AddNumber1Label.Size = new System.Drawing.Size(53, 13);
            this.AddNumber1Label.TabIndex = 0;
            this.AddNumber1Label.Text = "Number 1";
            // 
            // AddUnit1Label
            // 
            this.AddUnit1Label.AutoSize = true;
            this.AddUnit1Label.Location = new System.Drawing.Point(129, 9);
            this.AddUnit1Label.Name = "AddUnit1Label";
            this.AddUnit1Label.Size = new System.Drawing.Size(35, 13);
            this.AddUnit1Label.TabIndex = 1;
            this.AddUnit1Label.Text = "Unit 1";
            // 
            // AddNumber2Label
            // 
            this.AddNumber2Label.AutoSize = true;
            this.AddNumber2Label.Location = new System.Drawing.Point(235, 9);
            this.AddNumber2Label.Name = "AddNumber2Label";
            this.AddNumber2Label.Size = new System.Drawing.Size(53, 13);
            this.AddNumber2Label.TabIndex = 2;
            this.AddNumber2Label.Text = "Number 2";
            // 
            // AddUnit2Label
            // 
            this.AddUnit2Label.AutoSize = true;
            this.AddUnit2Label.Location = new System.Drawing.Point(342, 9);
            this.AddUnit2Label.Name = "AddUnit2Label";
            this.AddUnit2Label.Size = new System.Drawing.Size(35, 13);
            this.AddUnit2Label.TabIndex = 3;
            this.AddUnit2Label.Text = "Unit 2";
            // 
            // AddNumber1TextBox
            // 
            this.AddNumber1TextBox.Location = new System.Drawing.Point(12, 25);
            this.AddNumber1TextBox.Name = "AddNumber1TextBox";
            this.AddNumber1TextBox.Size = new System.Drawing.Size(77, 20);
            this.AddNumber1TextBox.TabIndex = 4;
            // 
            // AddUnit1TextBox
            // 
            this.AddUnit1TextBox.Location = new System.Drawing.Point(95, 25);
            this.AddUnit1TextBox.Name = "AddUnit1TextBox";
            this.AddUnit1TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUnit1TextBox.TabIndex = 5;
            // 
            // AddNumber2TextBox
            // 
            this.AddNumber2TextBox.Location = new System.Drawing.Point(225, 25);
            this.AddNumber2TextBox.Name = "AddNumber2TextBox";
            this.AddNumber2TextBox.Size = new System.Drawing.Size(77, 20);
            this.AddNumber2TextBox.TabIndex = 6;
            // 
            // AddUnit2TextBox
            // 
            this.AddUnit2TextBox.Location = new System.Drawing.Point(308, 25);
            this.AddUnit2TextBox.Name = "AddUnit2TextBox";
            this.AddUnit2TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUnit2TextBox.TabIndex = 7;
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsLabel.Location = new System.Drawing.Point(201, 25);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(18, 20);
            this.EqualsLabel.TabIndex = 8;
            this.EqualsLabel.Text = "=";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(132, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 78);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.AddUnit2TextBox);
            this.Controls.Add(this.AddNumber2TextBox);
            this.Controls.Add(this.AddUnit1TextBox);
            this.Controls.Add(this.AddNumber1TextBox);
            this.Controls.Add(this.AddUnit2Label);
            this.Controls.Add(this.AddNumber2Label);
            this.Controls.Add(this.AddUnit1Label);
            this.Controls.Add(this.AddNumber1Label);
            this.Name = "AddForm";
            this.Text = "Add Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNumber1Label;
        private System.Windows.Forms.Label AddUnit1Label;
        private System.Windows.Forms.Label AddNumber2Label;
        private System.Windows.Forms.Label AddUnit2Label;
        private System.Windows.Forms.TextBox AddNumber1TextBox;
        private System.Windows.Forms.TextBox AddUnit1TextBox;
        private System.Windows.Forms.TextBox AddNumber2TextBox;
        private System.Windows.Forms.TextBox AddUnit2TextBox;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.Button AddButton;
    }
}