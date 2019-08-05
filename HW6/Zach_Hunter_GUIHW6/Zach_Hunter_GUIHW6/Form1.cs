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
    public partial class Form1 : Form
    {
        public static Conversions conversions = new Conversions();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Binds listbox using the conversions
        /// </summary>
        public void BindListBox()
        {
            this.ConversionSelectionBox.DataSource = null;
            this.ConversionSelectionBox.DataSource = conversions.ConversionObjects;
            this.ConversionSelectionBox.DisplayMember = "ConversionName";
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Performs conversions based on associated values and selected radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double convertNumber = 0.0;
            if (!double.TryParse(InputTextBox.Text, out convertNumber))
            {
                InputTextBox.Clear();
                InputTextBox.Focus();
            } //else number is valid, DoNothing();

            if (this.ConvertToRadioButton.Checked)
            {
                this.OutputTextBox.Text = $"{convertNumber:F4} {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].FromUnit} = {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].ConvertTo(convertNumber):F4} {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].ToUnit}";
            }
            else if (this.ConvertFromRadioButton.Checked)
            {
                this.OutputTextBox.Text = $"{convertNumber:F4} {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].ToUnit} = {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].ConvertFrom(convertNumber):F4} {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].FromUnit}";
            }
            else
            {
                OutputTextBox.Text = "Must select Convert To or Convert From";
            }         
        }
        /// <summary>
        /// Adds 2 default conversions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConvertToRadioButton.Select();
            conversions.ConversionObjects.Add(new Conversion("Kilometers", 1.6093, "Miles", 0.6214));
            conversions.ConversionObjects.Add(new Conversion("Centimeters", 2.54, "Inches", 0.3937));
            this.BindListBox();
        }


        /// <summary>
        /// Opens the Add Form to add a new conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddConversionButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }
        /// <summary>
        /// Makes sure form is updated after adding or deleting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Enter(object sender, EventArgs e)
        {
            this.BindListBox();
        }
        /// <summary>
        /// Makes sure form is updated after adding or deleting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.BindListBox();
        }
        /// <summary>
        /// Deletes selected conversion if user accepts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteConversionButton_Click(object sender, EventArgs e)
        {
            if (conversions.ConversionObjects.Count > 0 && ConversionSelectionBox.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you wish to delete the {conversions.ConversionObjects[ConversionSelectionBox.SelectedIndex].ConversionName} conversion?", "Delete Conversion",
                    MessageBoxButtons.OKCancel);
                switch (dialogResult)
                {
                    case DialogResult.OK:
                        conversions.ConversionObjects.RemoveAt(ConversionSelectionBox.SelectedIndex);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
                
                this.BindListBox();
                ConversionSelectionBox.Refresh();
            }
        }
    }
}
