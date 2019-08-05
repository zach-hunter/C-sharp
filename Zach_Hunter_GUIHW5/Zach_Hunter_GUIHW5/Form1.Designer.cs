namespace Zach_Hunter_GUIHW5
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
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.EnglishRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PigLatinRadio = new System.Windows.Forms.RadioButton();
            this.PigGreekRadio = new System.Windows.Forms.RadioButton();
            this.TranslateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishLabel.Location = new System.Drawing.Point(13, 13);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(155, 17);
            this.EnglishLabel.TabIndex = 0;
            this.EnglishLabel.Text = "Enter English text here:";
            // 
            // EnglishRichTextBox
            // 
            this.EnglishRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishRichTextBox.Location = new System.Drawing.Point(13, 34);
            this.EnglishRichTextBox.Name = "EnglishRichTextBox";
            this.EnglishRichTextBox.Size = new System.Drawing.Size(436, 150);
            this.EnglishRichTextBox.TabIndex = 1;
            this.EnglishRichTextBox.Text = "";
            // 
            // PigLatinRadio
            // 
            this.PigLatinRadio.AutoSize = true;
            this.PigLatinRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PigLatinRadio.Location = new System.Drawing.Point(16, 206);
            this.PigLatinRadio.Name = "PigLatinRadio";
            this.PigLatinRadio.Size = new System.Drawing.Size(81, 21);
            this.PigLatinRadio.TabIndex = 2;
            this.PigLatinRadio.TabStop = true;
            this.PigLatinRadio.Text = "Pig Latin";
            this.PigLatinRadio.UseVisualStyleBackColor = true;
            this.PigLatinRadio.Click += new System.EventHandler(this.PigLatinRadio_Click);
            // 
            // PigGreekRadio
            // 
            this.PigGreekRadio.AutoSize = true;
            this.PigGreekRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PigGreekRadio.Location = new System.Drawing.Point(130, 206);
            this.PigGreekRadio.Name = "PigGreekRadio";
            this.PigGreekRadio.Size = new System.Drawing.Size(89, 21);
            this.PigGreekRadio.TabIndex = 3;
            this.PigGreekRadio.TabStop = true;
            this.PigGreekRadio.Text = "Pig Greek";
            this.PigGreekRadio.UseVisualStyleBackColor = true;
            this.PigGreekRadio.Click += new System.EventHandler(this.PigGreekRadio_Click);
            // 
            // TranslateRichTextBox
            // 
            this.TranslateRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateRichTextBox.Location = new System.Drawing.Point(12, 275);
            this.TranslateRichTextBox.Name = "TranslateRichTextBox";
            this.TranslateRichTextBox.ReadOnly = true;
            this.TranslateRichTextBox.Size = new System.Drawing.Size(436, 150);
            this.TranslateRichTextBox.TabIndex = 4;
            this.TranslateRichTextBox.Text = "";
            // 
            // TranslateButton
            // 
            this.TranslateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateButton.Location = new System.Drawing.Point(13, 443);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(94, 26);
            this.TranslateButton.TabIndex = 5;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(125, 443);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 26);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateLabel.Location = new System.Drawing.Point(16, 243);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(0, 17);
            this.TranslateLabel.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(355, 443);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 26);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.TranslateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(461, 481);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TranslateLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TranslateButton);
            this.Controls.Add(this.TranslateRichTextBox);
            this.Controls.Add(this.PigGreekRadio);
            this.Controls.Add(this.PigLatinRadio);
            this.Controls.Add(this.EnglishRichTextBox);
            this.Controls.Add(this.EnglishLabel);
            this.Name = "Form1";
            this.Text = "Pig Latin & Greek Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.RichTextBox EnglishRichTextBox;
        private System.Windows.Forms.RadioButton PigLatinRadio;
        private System.Windows.Forms.RadioButton PigGreekRadio;
        private System.Windows.Forms.RichTextBox TranslateRichTextBox;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label TranslateLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

