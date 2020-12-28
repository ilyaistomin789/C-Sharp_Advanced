namespace OOP_LAB_4
{
    partial class TextСalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextСalculator));
            this.replaceButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.getLengthButton = new System.Windows.Forms.Button();
            this.GetVowelsButton = new System.Windows.Forms.Button();
            this.getConsonantsButton = new System.Windows.Forms.Button();
            this.getOffersButton = new System.Windows.Forms.Button();
            this.getWordsButton = new System.Windows.Forms.Button();
            this.getSymbolButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InputStringLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(11, 112);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 41);
            this.replaceButton.TabIndex = 1;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(105, 112);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 41);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // getLengthButton
            // 
            this.getLengthButton.Location = new System.Drawing.Point(197, 112);
            this.getLengthButton.Name = "getLengthButton";
            this.getLengthButton.Size = new System.Drawing.Size(75, 41);
            this.getLengthButton.TabIndex = 3;
            this.getLengthButton.Text = "Length";
            this.getLengthButton.UseVisualStyleBackColor = true;
            this.getLengthButton.Click += new System.EventHandler(this.getLengthButton_Click);
            // 
            // GetVowelsButton
            // 
            this.GetVowelsButton.Location = new System.Drawing.Point(11, 170);
            this.GetVowelsButton.Name = "GetVowelsButton";
            this.GetVowelsButton.Size = new System.Drawing.Size(75, 41);
            this.GetVowelsButton.TabIndex = 4;
            this.GetVowelsButton.Text = "Vowels count";
            this.GetVowelsButton.UseVisualStyleBackColor = true;
            this.GetVowelsButton.Click += new System.EventHandler(this.GetVowelsButton_Click);
            // 
            // getConsonantsButton
            // 
            this.getConsonantsButton.Location = new System.Drawing.Point(105, 170);
            this.getConsonantsButton.Name = "getConsonantsButton";
            this.getConsonantsButton.Size = new System.Drawing.Size(75, 41);
            this.getConsonantsButton.TabIndex = 5;
            this.getConsonantsButton.Text = "Consonants count";
            this.getConsonantsButton.UseVisualStyleBackColor = true;
            this.getConsonantsButton.Click += new System.EventHandler(this.getConsonantsButton_Click);
            // 
            // getOffersButton
            // 
            this.getOffersButton.Location = new System.Drawing.Point(197, 170);
            this.getOffersButton.Name = "getOffersButton";
            this.getOffersButton.Size = new System.Drawing.Size(75, 41);
            this.getOffersButton.TabIndex = 6;
            this.getOffersButton.Text = "Offers count";
            this.getOffersButton.UseVisualStyleBackColor = true;
            this.getOffersButton.Click += new System.EventHandler(this.getOffersButton_Click);
            // 
            // getWordsButton
            // 
            this.getWordsButton.Location = new System.Drawing.Point(11, 231);
            this.getWordsButton.Name = "getWordsButton";
            this.getWordsButton.Size = new System.Drawing.Size(75, 41);
            this.getWordsButton.TabIndex = 7;
            this.getWordsButton.Text = "Words count";
            this.getWordsButton.UseVisualStyleBackColor = true;
            this.getWordsButton.Click += new System.EventHandler(this.getWordsButton_Click);
            // 
            // getSymbolButton
            // 
            this.getSymbolButton.Location = new System.Drawing.Point(105, 231);
            this.getSymbolButton.Name = "getSymbolButton";
            this.getSymbolButton.Size = new System.Drawing.Size(167, 41);
            this.getSymbolButton.TabIndex = 8;
            this.getSymbolButton.Text = "Get symbol by index";
            this.getSymbolButton.UseVisualStyleBackColor = true;
            this.getSymbolButton.Click += new System.EventHandler(this.getSymbolButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 22);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(261, 23);
            this.inputTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 73);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(261, 23);
            this.resultTextBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // InputStringLabel
            // 
            this.InputStringLabel.AutoSize = true;
            this.InputStringLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputStringLabel.Location = new System.Drawing.Point(102, 4);
            this.InputStringLabel.Name = "InputStringLabel";
            this.InputStringLabel.Size = new System.Drawing.Size(71, 15);
            this.InputStringLabel.TabIndex = 11;
            this.InputStringLabel.Text = "Input String";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(115, 55);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(39, 15);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "Result";
            // 
            // TextСalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 283);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.InputStringLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.getSymbolButton);
            this.Controls.Add(this.getWordsButton);
            this.Controls.Add(this.getOffersButton);
            this.Controls.Add(this.getConsonantsButton);
            this.Controls.Add(this.GetVowelsButton);
            this.Controls.Add(this.getLengthButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.inputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextСalculator";
            this.Text = "Text calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button getLengthButton;
        private System.Windows.Forms.Button GetVowelsButton;
        private System.Windows.Forms.Button getConsonantsButton;
        private System.Windows.Forms.Button getOffersButton;
        private System.Windows.Forms.Button getWordsButton;
        private System.Windows.Forms.Button getSymbolButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label InputStringLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

