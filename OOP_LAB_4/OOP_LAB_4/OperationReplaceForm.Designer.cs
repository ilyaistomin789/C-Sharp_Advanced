namespace OOP_LAB_4
{
    partial class Operation_Replace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation_Replace));
            this.replaceInputTextBox = new System.Windows.Forms.TextBox();
            this.InputStringLabel = new System.Windows.Forms.Label();
            this.firstSubstringLabel = new System.Windows.Forms.Label();
            this.FirstSubstringRTB = new System.Windows.Forms.RichTextBox();
            this.SecondSubstringRTB = new System.Windows.Forms.RichTextBox();
            this.secondSubstringLabel = new System.Windows.Forms.Label();
            this.goReplaceButton = new System.Windows.Forms.Button();
            this.replaceResultLabel = new System.Windows.Forms.Label();
            this.replaceResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // replaceInputTextBox
            // 
            this.replaceInputTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceInputTextBox.Location = new System.Drawing.Point(11, 31);
            this.replaceInputTextBox.Name = "replaceInputTextBox";
            this.replaceInputTextBox.ReadOnly = true;
            this.replaceInputTextBox.Size = new System.Drawing.Size(213, 23);
            this.replaceInputTextBox.TabIndex = 1;
            // 
            // InputStringLabel
            // 
            this.InputStringLabel.AutoSize = true;
            this.InputStringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStringLabel.Location = new System.Drawing.Point(81, 9);
            this.InputStringLabel.Name = "InputStringLabel";
            this.InputStringLabel.Size = new System.Drawing.Size(71, 15);
            this.InputStringLabel.TabIndex = 12;
            this.InputStringLabel.Text = "Input String";
            // 
            // firstSubstringLabel
            // 
            this.firstSubstringLabel.AutoSize = true;
            this.firstSubstringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSubstringLabel.Location = new System.Drawing.Point(18, 116);
            this.firstSubstringLabel.Name = "firstSubstringLabel";
            this.firstSubstringLabel.Size = new System.Drawing.Size(84, 15);
            this.firstSubstringLabel.TabIndex = 13;
            this.firstSubstringLabel.Text = "First Substring";
            // 
            // FirstSubstringRTB
            // 
            this.FirstSubstringRTB.Location = new System.Drawing.Point(11, 136);
            this.FirstSubstringRTB.Name = "FirstSubstringRTB";
            this.FirstSubstringRTB.Size = new System.Drawing.Size(102, 32);
            this.FirstSubstringRTB.TabIndex = 14;
            this.FirstSubstringRTB.Text = "";
            // 
            // SecondSubstringRTB
            // 
            this.SecondSubstringRTB.Location = new System.Drawing.Point(119, 136);
            this.SecondSubstringRTB.Name = "SecondSubstringRTB";
            this.SecondSubstringRTB.Size = new System.Drawing.Size(107, 32);
            this.SecondSubstringRTB.TabIndex = 16;
            this.SecondSubstringRTB.Text = "";
            // 
            // secondSubstringLabel
            // 
            this.secondSubstringLabel.AutoSize = true;
            this.secondSubstringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSubstringLabel.Location = new System.Drawing.Point(124, 116);
            this.secondSubstringLabel.Name = "secondSubstringLabel";
            this.secondSubstringLabel.Size = new System.Drawing.Size(100, 15);
            this.secondSubstringLabel.TabIndex = 15;
            this.secondSubstringLabel.Text = "Second substring";
            // 
            // goReplaceButton
            // 
            this.goReplaceButton.Location = new System.Drawing.Point(82, 176);
            this.goReplaceButton.Name = "goReplaceButton";
            this.goReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.goReplaceButton.TabIndex = 17;
            this.goReplaceButton.Text = "Go";
            this.goReplaceButton.UseVisualStyleBackColor = true;
            this.goReplaceButton.Click += new System.EventHandler(this.goReplaceButton_Click);
            // 
            // replaceResultLabel
            // 
            this.replaceResultLabel.AutoSize = true;
            this.replaceResultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceResultLabel.Location = new System.Drawing.Point(99, 59);
            this.replaceResultLabel.Name = "replaceResultLabel";
            this.replaceResultLabel.Size = new System.Drawing.Size(39, 15);
            this.replaceResultLabel.TabIndex = 19;
            this.replaceResultLabel.Text = "Result";
            // 
            // replaceResultTextBox
            // 
            this.replaceResultTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceResultTextBox.Location = new System.Drawing.Point(12, 81);
            this.replaceResultTextBox.Name = "replaceResultTextBox";
            this.replaceResultTextBox.ReadOnly = true;
            this.replaceResultTextBox.Size = new System.Drawing.Size(213, 23);
            this.replaceResultTextBox.TabIndex = 18;
            // 
            // Operation_Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 209);
            this.Controls.Add(this.replaceResultLabel);
            this.Controls.Add(this.replaceResultTextBox);
            this.Controls.Add(this.goReplaceButton);
            this.Controls.Add(this.SecondSubstringRTB);
            this.Controls.Add(this.secondSubstringLabel);
            this.Controls.Add(this.FirstSubstringRTB);
            this.Controls.Add(this.firstSubstringLabel);
            this.Controls.Add(this.InputStringLabel);
            this.Controls.Add(this.replaceInputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operation_Replace";
            this.Text = "Operation Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InputStringLabel;
        private System.Windows.Forms.Label firstSubstringLabel;
        private System.Windows.Forms.RichTextBox FirstSubstringRTB;
        private System.Windows.Forms.RichTextBox SecondSubstringRTB;
        private System.Windows.Forms.Label secondSubstringLabel;
        private System.Windows.Forms.Button goReplaceButton;
        private System.Windows.Forms.TextBox replaceInputTextBox;
        private System.Windows.Forms.Label replaceResultLabel;
        private System.Windows.Forms.TextBox replaceResultTextBox;
    }
}