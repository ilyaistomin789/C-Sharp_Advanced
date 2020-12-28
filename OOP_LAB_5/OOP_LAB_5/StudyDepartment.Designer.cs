using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace OOP_LAB_5
{
    partial class DisciplineForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplineForm));
            this.disciplineLabel = new System.Windows.Forms.Label();
            this.specializationLabel = new System.Windows.Forms.Label();
            this.numOfLecturesLabel = new System.Windows.Forms.Label();
            this.numOfLabsLabel = new System.Windows.Forms.Label();
            this.disciplineTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.courseGB = new System.Windows.Forms.GroupBox();
            this.firstCourseCB = new System.Windows.Forms.CheckBox();
            this.secondCourseCB = new System.Windows.Forms.CheckBox();
            this.thirdCourseCB = new System.Windows.Forms.CheckBox();
            this.fourthCourseCB = new System.Windows.Forms.CheckBox();
            this.specComboBox = new System.Windows.Forms.ComboBox();
            this.lecturesTextBox = new System.Windows.Forms.TextBox();
            this.labsTextBox = new System.Windows.Forms.TextBox();
            this.typeOfControlGB = new System.Windows.Forms.GroupBox();
            this.examRB = new System.Windows.Forms.RadioButton();
            this.testRB = new System.Windows.Forms.RadioButton();
            this.lectorGroupBox = new System.Windows.Forms.GroupBox();
            this.auditoriumTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.writeFileButton = new System.Windows.Forms.Button();
            this.semesterTB = new System.Windows.Forms.TrackBar();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.informationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.aboutProductButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.countDisciplineToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.courseGB.SuspendLayout();
            this.typeOfControlGB.SuspendLayout();
            this.lectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterTB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disciplineLabel
            // 
            this.disciplineLabel.AutoSize = true;
            this.disciplineLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplineLabel.Location = new System.Drawing.Point(8, 39);
            this.disciplineLabel.Name = "disciplineLabel";
            this.disciplineLabel.Size = new System.Drawing.Size(95, 15);
            this.disciplineLabel.TabIndex = 0;
            this.disciplineLabel.Text = "Discipline Name";
            // 
            // specializationLabel
            // 
            this.specializationLabel.AutoSize = true;
            this.specializationLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specializationLabel.Location = new System.Drawing.Point(8, 295);
            this.specializationLabel.Name = "specializationLabel";
            this.specializationLabel.Size = new System.Drawing.Size(81, 15);
            this.specializationLabel.TabIndex = 3;
            this.specializationLabel.Text = "Specialization";
            // 
            // numOfLecturesLabel
            // 
            this.numOfLecturesLabel.AutoSize = true;
            this.numOfLecturesLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfLecturesLabel.Location = new System.Drawing.Point(8, 353);
            this.numOfLecturesLabel.Name = "numOfLecturesLabel";
            this.numOfLecturesLabel.Size = new System.Drawing.Size(111, 15);
            this.numOfLecturesLabel.TabIndex = 4;
            this.numOfLecturesLabel.Text = "Number of lectures";
            // 
            // numOfLabsLabel
            // 
            this.numOfLabsLabel.AutoSize = true;
            this.numOfLabsLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfLabsLabel.Location = new System.Drawing.Point(8, 407);
            this.numOfLabsLabel.Name = "numOfLabsLabel";
            this.numOfLabsLabel.Size = new System.Drawing.Size(91, 15);
            this.numOfLabsLabel.TabIndex = 5;
            this.numOfLabsLabel.Text = "Number of labs";
            // 
            // disciplineTextBox
            // 
            this.disciplineTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplineTextBox.Location = new System.Drawing.Point(8, 60);
            this.disciplineTextBox.Name = "disciplineTextBox";
            this.disciplineTextBox.Size = new System.Drawing.Size(122, 23);
            this.disciplineTextBox.TabIndex = 11;
            // 
            // courseGB
            // 
            this.courseGB.Controls.Add(this.firstCourseCB);
            this.courseGB.Controls.Add(this.secondCourseCB);
            this.courseGB.Controls.Add(this.thirdCourseCB);
            this.courseGB.Controls.Add(this.fourthCourseCB);
            this.courseGB.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGB.Location = new System.Drawing.Point(8, 171);
            this.courseGB.Name = "courseGB";
            this.courseGB.Size = new System.Drawing.Size(122, 111);
            this.courseGB.TabIndex = 13;
            this.courseGB.TabStop = false;
            this.courseGB.Text = "Course";
            // 
            // firstCourseCB
            // 
            this.firstCourseCB.AutoSize = true;
            this.firstCourseCB.Location = new System.Drawing.Point(3, 19);
            this.firstCourseCB.Name = "firstCourseCB";
            this.firstCourseCB.Size = new System.Drawing.Size(33, 19);
            this.firstCourseCB.TabIndex = 0;
            this.firstCourseCB.Text = "1";
            this.firstCourseCB.UseVisualStyleBackColor = true;
            // 
            // secondCourseCB
            // 
            this.secondCourseCB.AutoSize = true;
            this.secondCourseCB.Location = new System.Drawing.Point(3, 42);
            this.secondCourseCB.Name = "secondCourseCB";
            this.secondCourseCB.Size = new System.Drawing.Size(33, 19);
            this.secondCourseCB.TabIndex = 1;
            this.secondCourseCB.Text = "2";
            this.secondCourseCB.UseVisualStyleBackColor = true;
            // 
            // thirdCourseCB
            // 
            this.thirdCourseCB.AutoSize = true;
            this.thirdCourseCB.Location = new System.Drawing.Point(3, 65);
            this.thirdCourseCB.Name = "thirdCourseCB";
            this.thirdCourseCB.Size = new System.Drawing.Size(33, 19);
            this.thirdCourseCB.TabIndex = 2;
            this.thirdCourseCB.Text = "3";
            this.thirdCourseCB.UseVisualStyleBackColor = true;
            // 
            // fourthCourseCB
            // 
            this.fourthCourseCB.AutoSize = true;
            this.fourthCourseCB.Location = new System.Drawing.Point(3, 89);
            this.fourthCourseCB.Name = "fourthCourseCB";
            this.fourthCourseCB.Size = new System.Drawing.Size(33, 19);
            this.fourthCourseCB.TabIndex = 3;
            this.fourthCourseCB.Text = "4";
            this.fourthCourseCB.UseVisualStyleBackColor = true;
            // 
            // specComboBox
            // 
            this.specComboBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specComboBox.FormattingEnabled = true;
            this.specComboBox.Items.AddRange(new object[] {
            "POIT",
            "ISIT",
            "DEiVI",
            "POIBMS"});
            this.specComboBox.Location = new System.Drawing.Point(8, 316);
            this.specComboBox.Name = "specComboBox";
            this.specComboBox.Size = new System.Drawing.Size(121, 23);
            this.specComboBox.TabIndex = 14;
            // 
            // lecturesTextBox
            // 
            this.lecturesTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturesTextBox.Location = new System.Drawing.Point(8, 372);
            this.lecturesTextBox.Name = "lecturesTextBox";
            this.lecturesTextBox.Size = new System.Drawing.Size(122, 23);
            this.lecturesTextBox.TabIndex = 15;
            // 
            // labsTextBox
            // 
            this.labsTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsTextBox.Location = new System.Drawing.Point(8, 425);
            this.labsTextBox.Name = "labsTextBox";
            this.labsTextBox.Size = new System.Drawing.Size(122, 23);
            this.labsTextBox.TabIndex = 16;
            // 
            // typeOfControlGB
            // 
            this.typeOfControlGB.Controls.Add(this.examRB);
            this.typeOfControlGB.Controls.Add(this.testRB);
            this.typeOfControlGB.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfControlGB.Location = new System.Drawing.Point(162, 39);
            this.typeOfControlGB.Name = "typeOfControlGB";
            this.typeOfControlGB.Size = new System.Drawing.Size(139, 78);
            this.typeOfControlGB.TabIndex = 15;
            this.typeOfControlGB.TabStop = false;
            this.typeOfControlGB.Text = "Type of control";
            // 
            // examRB
            // 
            this.examRB.AutoSize = true;
            this.examRB.Location = new System.Drawing.Point(7, 47);
            this.examRB.Name = "examRB";
            this.examRB.Size = new System.Drawing.Size(54, 19);
            this.examRB.TabIndex = 14;
            this.examRB.TabStop = true;
            this.examRB.Text = "Exam";
            this.examRB.UseVisualStyleBackColor = true;
            // 
            // testRB
            // 
            this.testRB.AutoSize = true;
            this.testRB.Location = new System.Drawing.Point(7, 22);
            this.testRB.Name = "testRB";
            this.testRB.Size = new System.Drawing.Size(46, 19);
            this.testRB.TabIndex = 13;
            this.testRB.TabStop = true;
            this.testRB.Text = "Test";
            this.testRB.UseVisualStyleBackColor = true;
            // 
            // lectorGroupBox
            // 
            this.lectorGroupBox.Controls.Add(this.auditoriumTextBox);
            this.lectorGroupBox.Controls.Add(this.fioTextBox);
            this.lectorGroupBox.Controls.Add(this.departmentComboBox);
            this.lectorGroupBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectorGroupBox.Location = new System.Drawing.Point(162, 138);
            this.lectorGroupBox.Name = "lectorGroupBox";
            this.lectorGroupBox.Size = new System.Drawing.Size(167, 115);
            this.lectorGroupBox.TabIndex = 15;
            this.lectorGroupBox.TabStop = false;
            this.lectorGroupBox.Text = "Lector";
            // 
            // auditoriumTextBox
            // 
            this.auditoriumTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditoriumTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.auditoriumTextBox.Location = new System.Drawing.Point(6, 82);
            this.auditoriumTextBox.Name = "auditoriumTextBox";
            this.auditoriumTextBox.Size = new System.Drawing.Size(154, 23);
            this.auditoriumTextBox.TabIndex = 17;
            this.auditoriumTextBox.Text = "Auditorium";
            this.auditoriumTextBox.Click += new System.EventHandler(this.auditoriumTextBox_Click);
            this.auditoriumTextBox.LostFocus += new System.EventHandler(this.auditoriumTextBox_LostFocus);
            // 
            // fioTextBox
            // 
            this.fioTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fioTextBox.Location = new System.Drawing.Point(6, 51);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(154, 23);
            this.fioTextBox.TabIndex = 17;
            this.fioTextBox.Text = "FIO";
            this.fioTextBox.Click += new System.EventHandler(this.fioTextBox_Click);
            this.fioTextBox.LostFocus += new System.EventHandler(this.fioTextBox_LostFocus);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Information systems and technologies",
            "Computer science and web design",
            "Software engineering",
            "Physics",
            "Engineering graphics",
            "Higher mathematics"});
            this.departmentComboBox.Location = new System.Drawing.Point(6, 22);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(154, 23);
            this.departmentComboBox.TabIndex = 17;
            this.departmentComboBox.Text = "Choose the department";
            this.departmentComboBox.Click += new System.EventHandler(this.departmentComboBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(168, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 36);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFileButton.Location = new System.Drawing.Point(168, 365);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(154, 36);
            this.readFileButton.TabIndex = 18;
            this.readFileButton.Text = "Read information";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // writeFileButton
            // 
            this.writeFileButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeFileButton.Location = new System.Drawing.Point(168, 415);
            this.writeFileButton.Name = "writeFileButton";
            this.writeFileButton.Size = new System.Drawing.Size(154, 36);
            this.writeFileButton.TabIndex = 19;
            this.writeFileButton.Text = "Write information";
            this.writeFileButton.UseVisualStyleBackColor = true;
            this.writeFileButton.Click += new System.EventHandler(this.writeFileButton_Click);
            // 
            // semesterTB
            // 
            this.semesterTB.Location = new System.Drawing.Point(8, 123);
            this.semesterTB.Maximum = 2;
            this.semesterTB.Minimum = 1;
            this.semesterTB.Name = "semesterTB";
            this.semesterTB.Size = new System.Drawing.Size(122, 45);
            this.semesterTB.TabIndex = 20;
            this.semesterTB.Value = 1;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.Location = new System.Drawing.Point(8, 97);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(56, 15);
            this.semesterLabel.TabIndex = 21;
            this.semesterLabel.Text = "Semester";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(349, 39);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(81, 15);
            this.informationLabel.TabIndex = 22;
            this.informationLabel.Text = "Information : ";
            this.informationLabel.UseMnemonic = false;
            // 
            // informationRichTextBox
            // 
            this.informationRichTextBox.Location = new System.Drawing.Point(349, 61);
            this.informationRichTextBox.Name = "informationRichTextBox";
            this.informationRichTextBox.ReadOnly = true;
            this.informationRichTextBox.Size = new System.Drawing.Size(157, 387);
            this.informationRichTextBox.TabIndex = 23;
            this.informationRichTextBox.Text = "";
            // 
            // aboutProductButton
            // 
            this.aboutProductButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutProductButton.Location = new System.Drawing.Point(168, 320);
            this.aboutProductButton.Name = "aboutProductButton";
            this.aboutProductButton.Size = new System.Drawing.Size(154, 36);
            this.aboutProductButton.TabIndex = 24;
            this.aboutProductButton.Text = "About";
            this.aboutProductButton.UseVisualStyleBackColor = true;
            this.aboutProductButton.Click += new System.EventHandler(this.aboutProductButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripLabel,
            this.toolStripSeparator1,
            this.sortToolStripLabel,
            this.toolStripSeparator2,
            this.clearToolStripLabel,
            this.toolStripSeparator3,
            this.exitToolStripLabel,
            this.toolStripSeparator4,
            this.statusToolStripLabel,
            this.countDisciplineToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "programToolStrip";
            // 
            // searchToolStripLabel
            // 
            this.searchToolStripLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchToolStripLabel.Name = "searchToolStripLabel";
            this.searchToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.searchToolStripLabel.Text = "Search";
            this.searchToolStripLabel.Click += new System.EventHandler(this.searchToolStripLabel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sortToolStripLabel
            // 
            this.sortToolStripLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortToolStripLabel.Name = "sortToolStripLabel";
            this.sortToolStripLabel.Size = new System.Drawing.Size(28, 22);
            this.sortToolStripLabel.Text = "Sort";
            this.sortToolStripLabel.Click += new System.EventHandler(this.sortToolStripLabel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clearToolStripLabel
            // 
            this.clearToolStripLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearToolStripLabel.Name = "clearToolStripLabel";
            this.clearToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.clearToolStripLabel.Text = "Clear";
            this.clearToolStripLabel.Click += new System.EventHandler(this.clearToolStripLabel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // exitToolStripLabel
            // 
            this.exitToolStripLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripLabel.Name = "exitToolStripLabel";
            this.exitToolStripLabel.Size = new System.Drawing.Size(25, 22);
            this.exitToolStripLabel.Text = "Exit";
            this.exitToolStripLabel.Click += new System.EventHandler(this.exitToolStripLabel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusToolStripLabel
            // 
            this.statusToolStripLabel.Name = "statusToolStripLabel";
            this.statusToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.statusToolStripLabel.Text = "Status : ";
            // 
            // countDisciplineToolStripLabel
            // 
            this.countDisciplineToolStripLabel.Name = "countDisciplineToolStripLabel";
            this.countDisciplineToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.aboutProductButton);
            this.Controls.Add(this.informationRichTextBox);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.semesterTB);
            this.Controls.Add(this.writeFileButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lectorGroupBox);
            this.Controls.Add(this.typeOfControlGB);
            this.Controls.Add(this.labsTextBox);
            this.Controls.Add(this.lecturesTextBox);
            this.Controls.Add(this.specComboBox);
            this.Controls.Add(this.courseGB);
            this.Controls.Add(this.disciplineTextBox);
            this.Controls.Add(this.numOfLabsLabel);
            this.Controls.Add(this.numOfLecturesLabel);
            this.Controls.Add(this.specializationLabel);
            this.Controls.Add(this.disciplineLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisciplineForm";
            this.Text = "Discipline";
            this.courseGB.ResumeLayout(false);
            this.courseGB.PerformLayout();
            this.typeOfControlGB.ResumeLayout(false);
            this.typeOfControlGB.PerformLayout();
            this.lectorGroupBox.ResumeLayout(false);
            this.lectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterTB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label disciplineLabel;
        private System.Windows.Forms.Label specializationLabel;
        private System.Windows.Forms.Label numOfLecturesLabel;
        private System.Windows.Forms.Label numOfLabsLabel;
        private System.Windows.Forms.TextBox disciplineTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox courseGB;
        private System.Windows.Forms.CheckBox fourthCourseCB;
        private System.Windows.Forms.CheckBox thirdCourseCB;
        private System.Windows.Forms.CheckBox secondCourseCB;
        private System.Windows.Forms.CheckBox firstCourseCB;
        private System.Windows.Forms.ComboBox specComboBox;
        private System.Windows.Forms.TextBox lecturesTextBox;
        private System.Windows.Forms.TextBox labsTextBox;
        private System.Windows.Forms.GroupBox typeOfControlGB;
        private System.Windows.Forms.RadioButton examRB;
        private System.Windows.Forms.RadioButton testRB;
        private System.Windows.Forms.GroupBox lectorGroupBox;
        private System.Windows.Forms.TextBox auditoriumTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button writeFileButton;
        private System.Windows.Forms.TrackBar semesterTB;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.RichTextBox informationRichTextBox;
        private System.Windows.Forms.Button aboutProductButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel sortToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel clearToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel exitToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel statusToolStripLabel;
        private System.Windows.Forms.ToolStripLabel countDisciplineToolStripLabel;
    }
}

