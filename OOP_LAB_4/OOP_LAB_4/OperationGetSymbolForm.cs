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
    public partial class Operation_SymbolOf : Form
    {
        public Operation_SymbolOf()
        {
            InitializeComponent();
        }

        public Operation_SymbolOf(string inputText)
        {
            InitializeComponent();
            symbolInputTextBox.Text = inputText;
        }

        private void goGetSymbolButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(symbolIndexTextBox.Text);
            char resultSymbol = symbolInputTextBox.Text[index];
            symbolResultTextBox.Text = resultSymbol.ToString();
        }
    }
}
