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
    public partial class TextСalculator : Form
    {
        private int _counter;
        string _vowels = "AaEeIiOoYyUuАаЯяОоЁёУуЮюЕеЭэЫыИи";

        private Form _formObject;
        public TextСalculator()
        {
            InitializeComponent();
        }

        private void CheckInputText()
        {
            if (inputTextBox.Text.Length == 0)
            {
                throw new Exception("Please, enter the input string");
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            CheckInputText();
            _formObject = new Operation_Replace(inputTextBox.Text);
            _formObject.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CheckInputText();
            _formObject = new Operation_Delete(inputTextBox.Text);
            _formObject.Show();
        }

        private void getLengthButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = inputTextBox.Text.Length.ToString();
        }

        private void getSymbolButton_Click(object sender, EventArgs e)
        {
            CheckInputText();
            _formObject = new Operation_SymbolOf(inputTextBox.Text);
            _formObject.Show();

        }

        private void GetVowelsButton_Click(object sender, EventArgs e)
        {
            _counter = 0;
            for (int i = 0; i < inputTextBox.Text.Length; i++)
            {
                for (int j = 0; j < _vowels.Length; j++)
                {
                    if (inputTextBox.Text[i] == _vowels[j])
                    {
                        _counter++;
                    }
                }
            }

            resultTextBox.Text = _counter.ToString();

        }

        private void getConsonantsButton_Click(object sender, EventArgs e)
        {
            int consonants = 0;
            _counter = 0;
            for (int i = 0; i < inputTextBox.Text.Length; i++)
            {
                for (int j = 0; j < _vowels.Length; j++)
                {
                    if (inputTextBox.Text[i] != _vowels[j]) continue;
                    _counter++;
                    consonants = inputTextBox.Text.Length - _counter;
                }
            }

            resultTextBox.Text = consonants.ToString();

        }

        private void getWordsButton_Click(object sender, EventArgs e)
        {
            string[] tmpString = inputTextBox.Text.Trim(' ').Split(' ');
            resultTextBox.Text = tmpString.Length.ToString();
        }

        private void getOffersButton_Click(object sender, EventArgs e)
        {
            _counter = 0;
            bool tmp = true;
            foreach (var symbol in inputTextBox.Text)
            {
                bool current = symbol == '!' || symbol == '.' || symbol == '?';
                if (!tmp && current)
                {
                    _counter++;
                }

                tmp = current;
            }

            resultTextBox.Text = _counter.ToString();
        }
    }
}
