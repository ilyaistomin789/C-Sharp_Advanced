namespace OOP_LAB_4
{
    partial class Operation_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation_Delete));
            this.InputStringLabel = new System.Windows.Forms.Label();
            this.deleteInputTextBox = new System.Windows.Forms.TextBox();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.deleteActionTextBox = new System.Windows.Forms.TextBox();
            this.deleteResultLabel = new System.Windows.Forms.Label();
            this.deleteResultTextBox = new System.Windows.Forms.TextBox();
            this.goDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputStringLabel
            // 
            this.InputStringLabel.AutoSize = true;
            this.InputStringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStringLabel.Location = new System.Drawing.Point(85, 9);
            this.InputStringLabel.Name = "InputStringLabel";
            this.InputStringLabel.Size = new System.Drawing.Size(71, 15);
            this.InputStringLabel.TabIndex = 14;
            this.InputStringLabel.Text = "Input String";
            // 
            // deleteInputTextBox
            // 
            this.deleteInputTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInputTextBox.Location = new System.Drawing.Point(15, 31);
            this.deleteInputTextBox.Name = "deleteInputTextBox";
            this.deleteInputTextBox.ReadOnly = true;
            this.deleteInputTextBox.Size = new System.Drawing.Size(213, 23);
            this.deleteInputTextBox.TabIndex = 13;
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationLabel.Location = new System.Drawing.Point(74, 62);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(98, 15);
            this.OperationLabel.TabIndex = 16;
            this.OperationLabel.Text = "Operation Delete";
            // 
            // deleteActionTextBox
            // 
            this.deleteActionTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteActionTextBox.Location = new System.Drawing.Point(15, 84);
            this.deleteActionTextBox.Name = "deleteActionTextBox";
            this.deleteActionTextBox.Size = new System.Drawing.Size(213, 23);
            this.deleteActionTextBox.TabIndex = 15;
            // 
            // deleteResultLabel
            // 
            this.deleteResultLabel.AutoSize = true;
            this.deleteResultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteResultLabel.Location = new System.Drawing.Point(85, 118);
            this.deleteResultLabel.Name = "deleteResultLabel";
            this.deleteResultLabel.Size = new System.Drawing.Size(75, 15);
            this.deleteResultLabel.TabIndex = 18;
            this.deleteResultLabel.Text = "Result String";
            // 
            // deleteResultTextBox
            // 
            this.deleteResultTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteResultTextBox.Location = new System.Drawing.Point(15, 140);
            this.deleteResultTextBox.Name = "deleteResultTextBox";
            this.deleteResultTextBox.ReadOnly = true;
            this.deleteResultTextBox.Size = new System.Drawing.Size(213, 23);
            this.deleteResultTextBox.TabIndex = 17;
            // 
            // goDeleteButton
            // 
            this.goDeleteButton.Location = new System.Drawing.Point(81, 175);
            this.goDeleteButton.Name = "goDeleteButton";
            this.goDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.goDeleteButton.TabIndex = 19;
            this.goDeleteButton.Text = "Go";
            this.goDeleteButton.UseVisualStyleBackColor = true;
            this.goDeleteButton.Click += new System.EventHandler(this.goDeleteButton_Click);
            // 
            // Operation_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 209);
            this.Controls.Add(this.goDeleteButton);
            this.Controls.Add(this.deleteResultLabel);
            this.Controls.Add(this.deleteResultTextBox);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.deleteActionTextBox);
            this.Controls.Add(this.InputStringLabel);
            this.Controls.Add(this.deleteInputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operation_Delete";
            this.Text = "Operation Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputStringLabel;
        private System.Windows.Forms.TextBox deleteInputTextBox;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.TextBox deleteActionTextBox;
        private System.Windows.Forms.Label deleteResultLabel;
        private System.Windows.Forms.TextBox deleteResultTextBox;
        private System.Windows.Forms.Button goDeleteButton;
    }
}