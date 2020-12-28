using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_5
{
    public partial class DisciplineForm : Form
    {
        private Form form;
        readonly string _path = @"D:\Visual Studio 2019\OOP(C#)\2SEM\OOP_LAB_5\info\info.txt";
        public DisciplineForm()
        {
            InitializeComponent();
            if (File.Exists(_path))
            {
                Serializer.Deserialization(_path);
            }
            else
            {
                InfoCollection.list = new List<DisciplineInfo>();
            }

            countDisciplineToolStripLabel.Text = $"Count of disciplines {InfoCollection.list.Count.ToString()}. Start Time : {DateTime.Now}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DisciplineInfo _disciplineInfo = new DisciplineInfo();
            _disciplineInfo.Course = new List<int>();
            _disciplineInfo.DisciplineName = disciplineTextBox.Text;
            _disciplineInfo.Semester = semesterTB.Value;
            foreach (CheckBox element in courseGB.Controls)
            {
                if (element.Checked)
                {
                    _disciplineInfo.Course.Add(Int32.Parse(element.Text));
                }
            }
            _disciplineInfo.Specialization = specComboBox.Text;
            _disciplineInfo.LecturesNumber = Int32.Parse(lecturesTextBox.Text);
            _disciplineInfo.LabsNumber = Int32.Parse(labsTextBox.Text);
            if (testRB.Checked)
            {
                _disciplineInfo.TypeOfControl = testRB.Text;
            }

            if (examRB.Checked)
            {
                _disciplineInfo.TypeOfControl = examRB.Text;
            }

            _disciplineInfo.DepartmentLector = departmentComboBox.Text;
            _disciplineInfo.FioLector = fioTextBox.Text;
            _disciplineInfo.AuditoriumLector = auditoriumTextBox.Text;
            var validationList = new List<ValidationResult>();
            var context = new ValidationContext(_disciplineInfo);
            if (!Validator.TryValidateObject(_disciplineInfo, context, validationList, true))
            {
                foreach (var errors in validationList)
                {
                    MessageBox.Show(errors.ErrorMessage);
                }
            }
            else
            {
                InfoCollection.list.Add(_disciplineInfo);
            }
            

        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentComboBox.ForeColor = Color.Black;
        }

        private void departmentComboBox_Click(object sender, EventArgs e)
        {
            departmentComboBox.ForeColor = Color.Black;
        }

        private void fioTextBox_Click(object sender, EventArgs e)
        {
            if (fioTextBox.Text == "FIO")
            {
                fioTextBox.Text = String.Empty;
                fioTextBox.ForeColor = Color.Black;
            }
        }

        private void fioTextBox_LostFocus(object sender, EventArgs e)
        {
            if (fioTextBox.Text == String.Empty)
            {
                this.fioTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
                fioTextBox.Text = "FIO";
            }
        }
        private void auditoriumTextBox_Click(object sender, EventArgs e)
        {
            if (auditoriumTextBox.Text == "Auditorium")
            {
                auditoriumTextBox.Text = String.Empty;
                auditoriumTextBox.ForeColor = Color.Black;
            }
        }

        private void auditoriumTextBox_LostFocus(object sender, EventArgs e)
        {
            if (auditoriumTextBox.Text == String.Empty)
            {
                this.auditoriumTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
                auditoriumTextBox.Text = "Auditorium";
            }
        }

        private void writeFileButton_Click(object sender, EventArgs e)
        {
            if (InfoCollection.list.Count == 0)
            {
                throw new Exception("Nothing to write");
            }
            else
            {
                Serializer.Serialization(InfoCollection.list, _path);
                Thread.Sleep(500);
                Process opentxt = Process.Start(_path);
            }
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(_path);
            if (File.Exists(_path))
            {
                if (fileInfo.Length == 0)
                {
                    throw new Exception("File is empty");
                }
                else
                {
                    Serializer.Deserialization(_path);
                    foreach (var element in InfoCollection.list)
                    {
                        informationRichTextBox.Text += element.ToString();
                    }
                }
            }
            else
            {
                throw new Exception("File doesn't exists");
            }

        }

        private void aboutProductButton_Click(object sender, EventArgs e)
        {
            form = new AboutForm();
            form.Show();
        }


        private void searchToolStripLabel_Click(object sender, EventArgs e)
        {
            form = new SearchForm();
            form.Show();
        }

        private void sortToolStripLabel_Click(object sender, EventArgs e)
        {
            form = new SortForm(InfoCollection.list);
            form.Show();
        }

        private void clearToolStripLabel_Click(object sender, EventArgs e)
        {
            disciplineTextBox.Text = String.Empty;
            semesterTB.Value = 1;
            foreach (CheckBox element in courseGB.Controls)
            {
                element.Checked = false;
            }
            specComboBox.Text = String.Empty;
            lecturesTextBox.Text = String.Empty;
            labsTextBox.Text = String.Empty;
            foreach (RadioButton elementButton in typeOfControlGB.Controls)
            {
                elementButton.Checked = false;
            }

            departmentComboBox.ForeColor = System.Drawing.SystemColors.GrayText;
            departmentComboBox.Text = "Choose the department";
            fioTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            fioTextBox.Text = "FIO";
            auditoriumTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            auditoriumTextBox.Text = "Auditorium";

        }

        private void exitToolStripLabel_Click(object sender, EventArgs e)
        {
            form = new DisciplineForm();
            form.Close();
        }
    }
}
