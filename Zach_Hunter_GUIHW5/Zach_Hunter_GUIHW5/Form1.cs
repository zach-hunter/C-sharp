using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUIHW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PigLatinRadio.PerformClick();

        }

        private void PigLatinRadio_Click(object sender, EventArgs e)
        {
            TranslateLabel.Text = "Pig Latin Translation:";
            TranslateRichTextBox.Clear();
        }

        private void PigGreekRadio_Click(object sender, EventArgs e)
        {
            TranslateLabel.Text = "Pig Greek Translation:";
            TranslateRichTextBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TranslateRichTextBox.Clear();
            EnglishRichTextBox.Clear();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            var validString = EnglishRichTextBox.Text;
            if (!validString.Equals("") && !validString.Equals(" "))
            {
                TranslateRichTextBox.Clear();
                if (PigLatinRadio.Checked)
                {
                    PigLatinTranslator pigLatin = new PigLatinTranslator();
                    var translated = pigLatin.PigLatin(validString);
                    foreach (var word in translated)
                    {
                        TranslateRichTextBox.Text += $"{word} ";
                    }

                }
                else if (PigGreekRadio.Checked)
                {
                    PigGreekTranslator pigGreek = new PigGreekTranslator();
                    var translated = pigGreek.PigGreek(validString);
                    foreach (var word in translated)
                    {
                        TranslateRichTextBox.Text += $"{word} ";
                    }
                }
            } //else text field is blank, doNothing();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
