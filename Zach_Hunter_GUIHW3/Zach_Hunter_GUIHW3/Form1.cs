using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUIHW3
{
    public partial class Form1 : Form
    {
        private int saleCount = 0;
        private List<string> listOfSales = new List<string>();

        void AddSale(string name, decimal amountOfSale)
        {
            string addString = $"{name} {amountOfSale}";  
                                
            for ( int i = 0; i < this.listOfSales.Count; i++)
            {
                if (name.Length <= listOfSales[i].Length && name.Equals(this.listOfSales[i].Substring(0, name.Length)))
                {
                    string temp = $"{name} {(amountOfSale + (decimal.Parse(this.listOfSales[i].Substring(name.Length+1, (this.listOfSales[i].Length - name.Length-1)))))}";
                    listOfSales.RemoveAt(i);
                    listOfSales.Add(temp);
                } else
                {
                    this.listOfSales.Add(addString);
                }
            }
            if (this.listOfSales.Count == 0)
            {
                this.listOfSales.Add(addString);
            }
            ResultsRichTextBox.Clear();
            foreach (string entry in listOfSales)
            {

                ResultsRichTextBox.Text += $"{entry}{Environment.NewLine}";
            }
        }

        //string GetHighestRepBySales(int numberOfReps)
        //{

        //}

        //string GetLowestRepBySales()
        //{

        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaleCountLabel.Text = $"Sale Count: {saleCount}";
        }

        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            var saleAmount = 0.00M;
            var isValid = decimal.TryParse(SaleAmountTextBox.Text, out saleAmount);
            if (NameTextBox.Text == String.Empty || SaleAmountTextBox.Text == String.Empty)
            {
                MessageBox.Show(
                    "Field cannot be empty!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else if (!isValid)
            {
                MessageBox.Show(
                    "Not a valid sale amount.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else
            {
                AddSale(NameTextBox.Text, saleAmount);
                //ResultsRichTextBox.Text = listOfSales[0];
            }
        }
    }
}
