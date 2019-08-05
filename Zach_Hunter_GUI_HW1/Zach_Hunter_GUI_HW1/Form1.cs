using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUI_HW1
{
    public partial class ScoreCalculator : Form
    {
        int score, scoreTotal, scoreCount = 0;
        double scoreAverage = 0.0;
        const int MAX_SCORE = 100; //Maximum score value

        public ScoreCalculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(ScoreTextBox.Text, out score);
            if (!isValid)
            {
                this.ScoreTextBox.Clear();
                this.ScoreTextBox.Focus();
                MessageBox.Show(
                    "Invalid Entry! Not a number.", 
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else if (score < 0 || score > MAX_SCORE) {
                this.ScoreTextBox.Clear();
                this.ScoreTextBox.Focus();
                MessageBox.Show(
                    "Invalid Score Range! (1-100)",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else
            {
                scoreTotal += score;
                scoreCount++;
                scoreAverage = scoreTotal / scoreCount;
                ScoreTotalTextBox.Text = $"{scoreTotal}";
                ScoreCountTextBox.Text = $"{scoreCount}";
                AverageTextBox.Text = $"{scoreAverage}";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearScoresButton_Click(object sender, EventArgs e)
        {
            score = 0;
            scoreTotal = 0;
            scoreCount = 0;
            scoreAverage = 0;
            ScoreTextBox.Clear();
            ScoreTotalTextBox.Clear();
            ScoreCountTextBox.Clear();
            AverageTextBox.Clear();
            ScoreTextBox.Focus();
        }
    }
}
