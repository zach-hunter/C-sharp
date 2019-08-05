namespace Zach_Hunter_GUI_HW1
{
    partial class ScoreCalculator
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTotalLabel = new System.Windows.Forms.Label();
            this.ScoreCountLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(42, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreTotalLabel
            // 
            this.ScoreTotalLabel.AutoSize = true;
            this.ScoreTotalLabel.Location = new System.Drawing.Point(19, 35);
            this.ScoreTotalLabel.Name = "ScoreTotalLabel";
            this.ScoreTotalLabel.Size = new System.Drawing.Size(61, 13);
            this.ScoreTotalLabel.TabIndex = 1;
            this.ScoreTotalLabel.Text = "Score total:";
            // 
            // ScoreCountLabel
            // 
            this.ScoreCountLabel.AutoSize = true;
            this.ScoreCountLabel.Location = new System.Drawing.Point(12, 60);
            this.ScoreCountLabel.Name = "ScoreCountLabel";
            this.ScoreCountLabel.Size = new System.Drawing.Size(68, 13);
            this.ScoreCountLabel.TabIndex = 2;
            this.ScoreCountLabel.Text = "Score count:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(30, 85);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(50, 13);
            this.AverageLabel.TabIndex = 3;
            this.AverageLabel.Text = "Average:";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(86, 6);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScoreTextBox.TabIndex = 4;
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Enabled = false;
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(86, 32);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScoreTotalTextBox.TabIndex = 5;
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Enabled = false;
            this.ScoreCountTextBox.Location = new System.Drawing.Point(86, 57);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.Size = new System.Drawing.Size(43, 20);
            this.ScoreCountTextBox.TabIndex = 6;
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Enabled = false;
            this.AverageTextBox.Location = new System.Drawing.Point(86, 82);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.Size = new System.Drawing.Size(43, 20);
            this.AverageTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(152, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(152, 111);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearScoresButton
            // 
            this.ClearScoresButton.Location = new System.Drawing.Point(54, 111);
            this.ClearScoresButton.Name = "ClearScoresButton";
            this.ClearScoresButton.Size = new System.Drawing.Size(75, 23);
            this.ClearScoresButton.TabIndex = 10;
            this.ClearScoresButton.Text = "Clear Scores";
            this.ClearScoresButton.UseVisualStyleBackColor = true;
            this.ClearScoresButton.Click += new System.EventHandler(this.ClearScoresButton_Click);
            // 
            // ScoreCalculator
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(234, 144);
            this.Controls.Add(this.ClearScoresButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.ScoreCountLabel);
            this.Controls.Add(this.ScoreTotalLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "ScoreCalculator";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreTotalLabel;
        private System.Windows.Forms.Label ScoreCountLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearScoresButton;
    }
}

