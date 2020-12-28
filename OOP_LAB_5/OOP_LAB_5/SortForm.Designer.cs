namespace OOP_LAB_5
{
    partial class SortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.sortLecturesButton = new System.Windows.Forms.Button();
            this.sortControlButton = new System.Windows.Forms.Button();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sortedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortLecturesButton
            // 
            this.sortLecturesButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLecturesButton.Location = new System.Drawing.Point(185, 112);
            this.sortLecturesButton.Name = "sortLecturesButton";
            this.sortLecturesButton.Size = new System.Drawing.Size(154, 45);
            this.sortLecturesButton.TabIndex = 19;
            this.sortLecturesButton.Text = "Sort by lectures count ";
            this.sortLecturesButton.UseVisualStyleBackColor = true;
            this.sortLecturesButton.Click += new System.EventHandler(this.sortLecturesButton_Click);
            // 
            // sortControlButton
            // 
            this.sortControlButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortControlButton.Location = new System.Drawing.Point(185, 220);
            this.sortControlButton.Name = "sortControlButton";
            this.sortControlButton.Size = new System.Drawing.Size(154, 43);
            this.sortControlButton.TabIndex = 20;
            this.sortControlButton.Text = "Sort by type of control";
            this.sortControlButton.UseVisualStyleBackColor = true;
            this.sortControlButton.Click += new System.EventHandler(this.sortControlButton_Click);
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 45);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.ReadOnly = true;
            this.inputRichTextBox.Size = new System.Drawing.Size(154, 388);
            this.inputRichTextBox.TabIndex = 21;
            this.inputRichTextBox.Text = "";
            // 
            // sortedRichTextBox
            // 
            this.sortedRichTextBox.Location = new System.Drawing.Point(362, 45);
            this.sortedRichTextBox.Name = "sortedRichTextBox";
            this.sortedRichTextBox.ReadOnly = true;
            this.sortedRichTextBox.Size = new System.Drawing.Size(154, 388);
            this.sortedRichTextBox.TabIndex = 22;
            this.sortedRichTextBox.Text = "";
            // 
            // lectorLabel
            // 
            this.lectorLabel.AutoSize = true;
            this.lectorLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectorLabel.Location = new System.Drawing.Point(42, 18);
            this.lectorLabel.Name = "lectorLabel";
            this.lectorLabel.Size = new System.Drawing.Size(93, 15);
            this.lectorLabel.TabIndex = 23;
            this.lectorLabel.Text = "Input Collection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sorted Collection";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lectorLabel);
            this.Controls.Add(this.sortedRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.sortControlButton);
            this.Controls.Add(this.sortLecturesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortForm";
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortLecturesButton;
        private System.Windows.Forms.Button sortControlButton;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox sortedRichTextBox;
        private System.Windows.Forms.Label lectorLabel;
        private System.Windows.Forms.Label label1;
    }
}