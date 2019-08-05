using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUIHW4
{
    public partial class CalculatorApp : Form
    {
        Calculator calculator = new Calculator();
        bool isOpActive = false;
        bool hasBeenPressed = false;
        bool triedDiv0 = false;
        bool isChaining = false;
        double originalValue = 0.0;
        string history = string.Empty;

        public CalculatorApp()
        {
            InitializeComponent();
        }
        

        private void Digit_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = true;
            if (sender is Button)
            {
                if (ResultTextBox.Text.Equals("0") || isOpActive || triedDiv0 || hasBeenPressed)
                {
                    ResultTextBox.Clear();
                } //else do not clear
                isOpActive = false;
                hasBeenPressed = false;
                Button button = (Button)sender;
                if (button.Text.Equals("."))
                {
                    if (!ResultTextBox.Text.Contains("."))
                    {
                        ResultTextBox.Text += button.Text;
                    }//else ignore the "."

                } else
                {
                    ResultTextBox.Text += button.Text;
                }

                triedDiv0 = false;

            } //else digit was not clicked, doNothing();
        }

        /// Gets the number value from the button pressed and adds to textbox
        


        private void SubtractButton_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = false;
            if (triedDiv0)
            {
                ResultTextBox.Text = "0";
            }
            if (isChaining)
            {          
                ChainEquals();

            } else
            {
                isChaining = true;
            }
            calculator.CurrentValue = Double.Parse(ResultTextBox.Text);
            calculator.Op = "-";
            isOpActive = true;
            hasBeenPressed = false;
            triedDiv0 = false;


        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = false;
            if (triedDiv0)
            {
                ResultTextBox.Text = "0";
            }
            if (isChaining)
            {
                ChainEquals();

            }
            else
            {
                isChaining = true;
            }
            calculator.CurrentValue = Double.Parse(ResultTextBox.Text);
            calculator.Op = "/";
            isOpActive = true;
            hasBeenPressed = false;
            triedDiv0 = false;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = false;
            if (triedDiv0)
            {
                ResultTextBox.Text = "0";
            }
            if (isChaining)
            {
                ChainEquals();

            }
            else
            {
                isChaining = true;
            }
            calculator.CurrentValue = Double.Parse(ResultTextBox.Text);
            calculator.Op = "+";
            isOpActive = true;
            hasBeenPressed = false;
            triedDiv0 = false;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            BackButton.Enabled = false;
            if (triedDiv0)
            {
                ResultTextBox.Text = "0";
            }
            if (isChaining)
            {
                ChainEquals();

            }
            else
            {
                isChaining = true;
            }
            calculator.CurrentValue = Double.Parse(ResultTextBox.Text);
            calculator.Op = "*";
            isOpActive = true;
            hasBeenPressed = false;
            triedDiv0 = false;
        }
        /// These functions can be compressed into one like the digit_pressed function
        /// but I left them seperate in the case of later adding functionality

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            calculator.CurrentValue = 0.0;
            calculator.Op = string.Empty;
            isChaining = false;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text.Length > 0)
            {
                ResultTextBox.Text = ResultTextBox.Text.Substring(0, ResultTextBox.Text.Length - 1);
                if (ResultTextBox.Text.Length == 0)
                {
                    ResultTextBox.Text = "0";
                }
            } //else nothing to delete doNothing();
        }

        private void CalculatorApp_Load(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            
            isChaining = false;
            if (!isOpActive)
            {
                if (!hasBeenPressed)
                {
                    if (Double.IsInfinity(calculator.DoMath(Double.Parse(ResultTextBox.Text))))
                    {
                        ResultTextBox.Text = "Error! Div by 0!";
                        triedDiv0 = true;
                        hasBeenPressed = true;
                    }
                    else
                    {
                        hasBeenPressed = true;
                        originalValue = Double.Parse(ResultTextBox.Text);
                        history += $"{calculator.CurrentValue} {calculator.Op} {ResultTextBox.Text} = {calculator.DoMath(Double.Parse(ResultTextBox.Text))}{Environment.NewLine}";
                        ResultTextBox.Text = $"{calculator.DoMath(Double.Parse(ResultTextBox.Text))}";
                        if (ResultTextBox.Text.Equals("NaN"))
                        {
                            ResultTextBox.Text = "Error! Div by 0!";
                        }

                    }
                }
                else
                {
                    if (triedDiv0)
                    {
                        ResultTextBox.Text = "0";
                    }
                    calculator.CurrentValue = Double.Parse(ResultTextBox.Text);
                    history += $"{calculator.CurrentValue} {calculator.Op} {ResultTextBox.Text} = {calculator.DoMath(Double.Parse(ResultTextBox.Text))}{Environment.NewLine}";
                    ResultTextBox.Text = $"{calculator.DoMath(originalValue)}";
                    if (ResultTextBox.Text.Equals("NaN"))
                    {
                        ResultTextBox.Text = "Error! Div by 0!";
                    }

                }
            } //else, equal was pressed after a operator, doNothing();

        }

        private void ChainEquals() //seperate equals function for chaining bonus
        {
            if (!isOpActive)
            {

                if (Double.IsInfinity(calculator.DoMath(Double.Parse(ResultTextBox.Text))))
                {
                    ResultTextBox.Text = "Error! Div by 0!";
                    triedDiv0 = true;
                    hasBeenPressed = true;
                }
                else
                {
                    history += $"{calculator.CurrentValue} {calculator.Op} {ResultTextBox.Text} = {calculator.DoMath(Double.Parse(ResultTextBox.Text))}{Environment.NewLine}";
                    ResultTextBox.Text = $"{calculator.DoMath(Double.Parse(ResultTextBox.Text))}";
                    if (ResultTextBox.Text.Equals("NaN"))
                    {
                        ResultTextBox.Text = "Error! Div by 0!";
                    }
                }

            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            var historyForm = new History(history);
            var dialogResult = historyForm.ShowDialog();
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = $"{Math.Sqrt(Double.Parse(ResultTextBox.Text))}";
            isOpActive = true;
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = $"{1/(Double.Parse(ResultTextBox.Text))}";
            isOpActive = true;
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = $"{-1 * (Double.Parse(ResultTextBox.Text))}";
            isOpActive = true;
        }
    }
}
