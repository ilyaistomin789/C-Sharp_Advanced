using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OOP_LAB_5
{
    public partial class SearchForm : Form
    {
        private string path = @"D:\Visual Studio 2019\OOP(C#)\2SEM\OOP_LAB_5\info\searchResult.txt";
        string serializationResult = String.Empty;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string pattern = String.Empty;
            informationRichTextBox.Text = String.Empty;
            if (lectorTextBox.Text != String.Empty)
            {
                pattern = @"\w*\s{1}\w*\s{1}\w*";
                if (Regex.IsMatch(lectorTextBox.Text, pattern, RegexOptions.IgnoreCase))
                {
                    var request = (from t in InfoCollection.list where lectorTextBox.Text == t.FioLector select t).ToList();
                    foreach (var element in request)
                    {
                        informationRichTextBox.Text += element.ToString();
                    }

                    serializationResult = JsonConvert.SerializeObject(request);
                }
                else
                {
                    MessageBox.Show("Lector name is incorrect!");
                }

            }

            if (semesterTextBox.Text != String.Empty)
            {
                pattern = @"[1-2]";
                if (Regex.IsMatch(semesterTextBox.Text, pattern))
                {
                    var semesterRequest = (from t in InfoCollection.list
                        where Int32.Parse(semesterTextBox.Text) == t.Semester
                        select t).ToList();
                    foreach (var element in semesterRequest)
                    {
                        informationRichTextBox.Text += element.ToString();
                    }

                    serializationResult = JsonConvert.SerializeObject(semesterRequest);
                }
                else
                {
                    MessageBox.Show("Semester is incorrect");
                }
            }

            if (courseTextBox.Text != String.Empty)
            {
                pattern = @"[1-4]";
                if (Regex.IsMatch(courseTextBox.Text, pattern))
                {
                    List<DisciplineInfo> courseRequest = new List<DisciplineInfo>();
                    foreach (var element in InfoCollection.list)
                    {
                        foreach (var course in element.Course)
                        {
                            if (Int32.Parse(courseTextBox.Text) == course)
                            {
                                courseRequest.Add(element);
                            }
                        }
                    }

                    serializationResult = JsonConvert.SerializeObject(courseRequest);
                    foreach (var element in courseRequest)
                    {
                        informationRichTextBox.Text += element.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Course is incorrect");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(serializationResult);
            }
        }
    }
}
