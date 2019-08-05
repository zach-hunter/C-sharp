using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUIHW2
{
    public partial class ISBNChecker : Form
    {
        public ISBNChecker()
        {
            InitializeComponent();
        }

        private void ISBNTextBox_Enter(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text.Equals("ISBN")) {
                ISBNTextBox.Clear();
            }
        }

        private void ISBNTextBox_Leave(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text.Equals(""))
            {
                ISBNTextBox.Text = "ISBN";
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            var ISBN = ISBNTextBox.Text;
            var ISBNFormat = int.Parse(ISBNSelector.Text);
            if (ISBN.Length.Equals(ISBNFormat))
            {
                bool isValid = false;
                var ISBNint = 0;
                if ((ISBN[9].Equals('X') || ISBN[9].Equals('x')) && ISBNFormat == 10)
                {
                    ISBN = ISBN.Substring(0, 9);
                } //else string is ready for conversion doNothing();
                isValid = int.TryParse(ISBN, out ISBNint);
                if (isValid)
                {
                    string correctISBN;
                    bool isISBNValid = false;
                    switch (ISBNFormat)
                    {
                        case 10:
                            isISBNValid = ISBN10Check(ISBNint, out correctISBN);
                            if (isISBNValid)
                            {
                                ResultTextBox.Text = "Valid ISBN";
                            } else
                            {
                                ResultTextBox.Text = $"Invalid ISBN{Environment.NewLine}Corrected: {correctISBN}";
                            }
                            break;
                        case 13:
                            //isISBNValid = ISBN13Check(ISBNint, out correctISBN);
                            break;
                        default:
                            //doNothing();
                            break;
                    }
                } else
                {
                    this.ISBNTextBox.Focus();
                    MessageBox.Show(
                        $"Invalid Entry for ISBN-{ISBNFormat}",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } else
            {
                this.ISBNTextBox.Focus();
                MessageBox.Show(
                    "Invalid ISBN Length!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ISBN10Check(int ISBN, out string correctISBN)
        {
            if (ISBN.ToString().Length.Equals(10))
            {
                int temp = 0;
                int multNum = 10;
                int numLength = 1000000000;
                for (int i = 0; i <= ISBN.ToString().Length; i++, multNum--)
                {
                    temp += (ISBN / numLength) * multNum;
                    numLength = numLength / 10;
                }
                int checkSum = 11 - numLength % 11;
                correctISBN = $"{ISBN.ToString().Substring(0, 9)}{checkSum}";
                return int.Parse(correctISBN).Equals(ISBN) ? true : false;
            } else //9 length ibsn, checksum is 10
            {
                int temp = 0;
                int multNum = 10;
                int numLength = 1000000000;
                for (int i = 0; i < ISBN.ToString().Length; i++, multNum--)
                {
                    temp += (ISBN / numLength) * multNum;
                    numLength = numLength / 10;
                }
                int checkSum = 11 - numLength % 11;
                if (checkSum == 10)
                {
                    correctISBN = $"{ISBN.ToString()}X";
                    return true;
                } else
                {
                    correctISBN = $"{ISBN.ToString()}{checkSum}";
                    return false;
                }
            }
        }

        private void ISBNChecker_Load(object sender, EventArgs e)
        {
            ISBNSelector.SelectedIndex = 0;
        }
    }
}
