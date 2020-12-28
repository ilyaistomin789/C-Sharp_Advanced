using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_4
{
    public partial class Operation_Replace : Form
    {
        public Operation_Replace()
        {
            InitializeComponent();
        }

        public Operation_Replace(string extractTextBox)
        {
            InitializeComponent();
            replaceInputTextBox.Text = extractTextBox;
        }

        private void goReplaceButton_Click(object sender, EventArgs e)
        {
            replaceResultTextBox.Text = replaceInputTextBox.Text.Replace(FirstSubstringRTB.Text, SecondSubstringRTB.Text);
        }
    }
}
