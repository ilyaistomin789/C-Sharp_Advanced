using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_4_TASK_1
{
    public partial class CollectionGeneration : Form
    {
        private List<int> list;
        public int Radius { get; set; }
        private static Random _randomRadius = new Random();
        public CollectionGeneration()
        {
            InitializeComponent();
        }

        public string GetInfo(int inputInt)
        {
            return $"Radius of circle : {inputInt}\n";
        }

        private void generateCollection_Click(object sender, EventArgs e)
        {
            
            int capacity = Int32.Parse(lengthTextBox.Text);
            list = new List<int>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                Radius = _randomRadius.Next(0, 100);
                list.Add(Radius);
                inputRichTextBox.Text += GetInfo(Radius);
            }
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = String.Empty;
            var orderbyResult = from t in list orderby Int32.Parse(t.ToString()) select t;
            foreach (var element in orderbyResult)
            {
                resultRichTextBox.Text += GetInfo(element);
            }
        }

        private void orderByDescButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = String.Empty;
            var orderbyDescResult = from t in list orderby Int32.Parse(t.ToString()) descending select t;
            foreach (var element in orderbyDescResult)
            {
                resultRichTextBox.Text += GetInfo(element);
            }
        }

        private void firstRequestButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = String.Empty;
            int minValue = list.Min();
            int maxValue = list.Max();
            resultRichTextBox.Text = $"Min value is : {minValue} \nMax value is : {maxValue}";
        }

        private void secondRequestButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = String.Empty;
            var diapasonResult = from t in list where (t > 0) && (t < 50) select t;
            foreach (var element in diapasonResult)
            {
                resultRichTextBox.Text += $"Element of diapason (0,50) is : {element.ToString()}\n";
            }
        }

        private void thirdRequestButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = String.Empty;
            double averageResult = list.Average();
            resultRichTextBox.Text = $"Average value is : {averageResult}";
        }
    }
}
