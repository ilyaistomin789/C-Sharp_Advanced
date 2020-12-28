using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_5
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        public SortForm(List<DisciplineInfo> list)
        {
            InitializeComponent();
            foreach (var element in list)
            {
                inputRichTextBox.Text += element.ToString();
            }
        }

        private void sortLecturesButton_Click(object sender, EventArgs e)
        {
            sortedRichTextBox.Text = String.Empty;
            var sortByLectures = from t in InfoCollection.list orderby t.LecturesNumber select t;
            foreach (var sortElements in sortByLectures)
            {
                sortedRichTextBox.Text += sortElements;
            }
        }

        private void sortControlButton_Click(object sender, EventArgs e)
        {
            sortedRichTextBox.Text = String.Empty;
            var sortByControl = from t in InfoCollection.list orderby t.TypeOfControl select t;
            foreach (var sortElements in sortByControl)
            {
                sortedRichTextBox.Text += sortElements;
            }
        }
    }
}
