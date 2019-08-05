using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zach_Hunter_GUIHW6
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds the entered conversion equality if it is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber = 0.0;
            if (double.TryParse(AddNumber1TextBox.Text, out firstNumber) && (double.TryParse(AddNumber2TextBox.Text, out secondNumber)))
            {
                Form1.conversions.ConversionObjects.Add(new Conversion(AddUnit1TextBox.Text, (firstNumber/secondNumber), AddUnit2TextBox.Text, (secondNumber/firstNumber)));
            } else
            {
                //Error Message Box Here
            }
            this.Close();
        }
    }
}
