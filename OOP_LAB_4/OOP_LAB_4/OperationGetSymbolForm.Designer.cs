namespace OOP_LAB_4
{
    partial class Operation_SymbolOf
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
            this.symbolInputStringLabel = new System.Windows.Forms.Label();
            this.symbolInputTextBox = new System.Windows.Forms.TextBox();
            this.symbolIndexLabel = new System.Windows.Forms.Label();
            this.symbolIndexTextBox = new System.Windows.Forms.TextBox();
            this.symbolResultLabel = new System.Windows.Forms.Label();
            this.symbolResultTextBox = new System.Windows.Forms.TextBox();
            this.goGetSymbolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbolInputStringLabel
            // 
            this.symbolInputStringLabel.AutoSize = true;
            this.symbolInputStringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolInputStringLabel.Location = new System.Drawing.Point(84, 9);
            this.symbolInputStringLabel.Name = "symbolInputStringLabel";
            this.symbolInputStringLabel.Size = new System.Drawing.Size(71, 15);
            this.symbolInputStringLabel.TabIndex = 16;
            this.symbolInputStringLabel.Text = "Input String";
            // 
            // symbolInputTextBox
            // 
            this.symbolInputTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolInputTextBox.Location = new System.Drawing.Point(12, 31);
            this.symbolInputTextBox.Name = "symbolInputTextBox";
            this.symbolInputTextBox.ReadOnly = true;
            this.symbolInputTextBox.Size = new System.Drawing.Size(213, 23);
            this.symbolInputTextBox.TabIndex = 15;
            // 
            // symbolIndexLabel
            // 
            this.symbolIndexLabel.AutoSize = true;
            this.symbolIndexLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolIndexLabel.Location = new System.Drawing.Point(102, 66);
            this.symbolIndexLabel.Name = "symbolIndexLabel";
            this.symbolIndexLabel.Size = new System.Drawing.Size(36, 15);
            this.symbolIndexLabel.TabIndex = 18;
            this.symbolIndexLabel.Text = "Index";
            // 
            // symbolIndexTextBox
            // 
            this.symbolIndexTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolIndexTextBox.Location = new System.Drawing.Point(12, 88);
            this.symbolIndexTextBox.Name = "symbolIndexTextBox";
            this.symbolIndexTextBox.Size = new System.Drawing.Size(213, 23);
            this.symbolIndexTextBox.TabIndex = 17;
            // 
            // symbolResultLabel
            // 
            this.symbolResultLabel.AutoSize = true;
            this.symbolResultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolResultLabel.Location = new System.Drawing.Point(82, 120);
            this.symbolResultLabel.Name = "symbolResultLabel";
            this.symbolResultLabel.Size = new System.Drawing.Size(68, 15);
            this.symbolResultLabel.TabIndex = 20;
            this.symbolResultLabel.Text = "Result Char";
            // 
            // symbolResultTextBox
            // 
            this.symbolResultTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolResultTextBox.Location = new System.Drawing.Point(12, 142);
            this.symbolResultTextBox.Name = "symbolResultTextBox";
            this.symbolResultTextBox.ReadOnly = true;
            this.symbolResultTextBox.Size = new System.Drawing.Size(213, 23);
            this.symbolResultTextBox.TabIndex = 19;
            // 
            // goGetSymbolButton
            // 
            this.goGetSymbolButton.Location = new System.Drawing.Point(81, 179);
            this.goGetSymbolButton.Name = "goGetSymbolButton";
            this.goGetSymbolButton.Size = new System.Drawing.Size(75, 23);
            this.goGetSymbolButton.TabIndex = 21;
            this.goGetSymbolButton.Text = "Go";
            this.goGetSymbolButton.UseVisualStyleBackColor = true;
            this.goGetSymbolButton.Click += new System.EventHandler(this.goGetSymbolButton_Click);
            // 
            // Operation_SymbolOf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 209);
            this.Controls.Add(this.goGetSymbolButton);
            this.Controls.Add(this.symbolResultLabel);
            this.Controls.Add(this.symbolResultTextBox);
            this.Controls.Add(this.symbolIndexLabel);
            this.Controls.Add(this.symbolIndexTextBox);
            this.Controls.Add(this.symbolInputStringLabel);
            this.Controls.Add(this.symbolInputTextBox);
            this.Name = "Operation_SymbolOf";
            this.Text = "Operation Get Symbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label symbolInputStringLabel;
        private System.Windows.Forms.TextBox symbolInputTextBox;
        private System.Windows.Forms.Label symbolIndexLabel;
        private System.Windows.Forms.TextBox symbolIndexTextBox;
        private System.Windows.Forms.Label symbolResultLabel;
        private System.Windows.Forms.TextBox symbolResultTextBox;
        private System.Windows.Forms.Button goGetSymbolButton;
    }
}