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
    public partial class Operation_Delete : Form
    {
        public Operation_Delete()
        {
            InitializeComponent();
        }

        public Operation_Delete(string inputText)
        {
            InitializeComponent();
            deleteInputTextBox.Text = inputText;
        }

        private void goDeleteButton_Click(object sender, EventArgs e)
        {
            deleteResultTextBox.Text = deleteInputTextBox.Text.Replace(deleteActionTextBox.Text, null);
        }
    }
}
