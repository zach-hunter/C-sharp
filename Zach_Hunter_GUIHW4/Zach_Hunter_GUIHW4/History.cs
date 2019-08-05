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
    public partial class History : Form
    {
        public string HistoryString { get; set; }

        public History()
        {
            InitializeComponent();
        }

        public History(string history)
        {
            this.HistoryString = history;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            HistoryRichTextBox.Text = this.HistoryString;
        }
    }
}
