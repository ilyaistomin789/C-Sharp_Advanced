namespace OOP_LAB_4_TASK_1
{
    partial class CollectionGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionGeneration));
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.generateCollection = new System.Windows.Forms.Button();
            this.orderByButton = new System.Windows.Forms.Button();
            this.orderByDescButton = new System.Windows.Forms.Button();
            this.firstRequestButton = new System.Windows.Forms.Button();
            this.secondRequestButton = new System.Windows.Forms.Button();
            this.thirdRequestButton = new System.Windows.Forms.Button();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(256, 22);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(115, 15);
            this.lengthLabel.TabIndex = 0;
            this.lengthLabel.Text = "Lenght of collection";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTextBox.Location = new System.Drawing.Point(259, 40);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(112, 23);
            this.lengthTextBox.TabIndex = 1;
            // 
            // generateCollection
            // 
            this.generateCollection.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCollection.Location = new System.Drawing.Point(211, 90);
            this.generateCollection.Name = "generateCollection";
            this.generateCollection.Size = new System.Drawing.Size(210, 67);
            this.generateCollection.TabIndex = 2;
            this.generateCollection.Text = "Generate collection";
            this.generateCollection.UseVisualStyleBackColor = true;
            this.generateCollection.Click += new System.EventHandler(this.generateCollection_Click);
            // 
            // orderByButton
            // 
            this.orderByButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByButton.Location = new System.Drawing.Point(12, 101);
            this.orderByButton.Name = "orderByButton";
            this.orderByButton.Size = new System.Drawing.Size(152, 45);
            this.orderByButton.TabIndex = 3;
            this.orderByButton.Text = "Order by ascending";
            this.orderByButton.UseVisualStyleBackColor = true;
            this.orderByButton.Click += new System.EventHandler(this.orderByButton_Click);
            // 
            // orderByDescButton
            // 
            this.orderByDescButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByDescButton.Location = new System.Drawing.Point(457, 101);
            this.orderByDescButton.Name = "orderByDescButton";
            this.orderByDescButton.Size = new System.Drawing.Size(152, 45);
            this.orderByDescButton.TabIndex = 4;
            this.orderByDescButton.Text = "Order by descending";
            this.orderByDescButton.UseVisualStyleBackColor = true;
            this.orderByDescButton.Click += new System.EventHandler(this.orderByDescButton_Click);
            // 
            // firstRequestButton
            // 
            this.firstRequestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRequestButton.Location = new System.Drawing.Point(54, 187);
            this.firstRequestButton.Name = "firstRequestButton";
            this.firstRequestButton.Size = new System.Drawing.Size(152, 45);
            this.firstRequestButton.TabIndex = 5;
            this.firstRequestButton.Text = "First request";
            this.firstRequestButton.UseVisualStyleBackColor = true;
            this.firstRequestButton.Click += new System.EventHandler(this.firstRequestButton_Click);
            // 
            // secondRequestButton
            // 
            this.secondRequestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRequestButton.Location = new System.Drawing.Point(245, 187);
            this.secondRequestButton.Name = "secondRequestButton";
            this.secondRequestButton.Size = new System.Drawing.Size(152, 45);
            this.secondRequestButton.TabIndex = 6;
            this.secondRequestButton.Text = "Second request";
            this.secondRequestButton.UseVisualStyleBackColor = true;
            this.secondRequestButton.Click += new System.EventHandler(this.secondRequestButton_Click);
            // 
            // thirdRequestButton
            // 
            this.thirdRequestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdRequestButton.Location = new System.Drawing.Point(443, 187);
            this.thirdRequestButton.Name = "thirdRequestButton";
            this.thirdRequestButton.Size = new System.Drawing.Size(152, 45);
            this.thirdRequestButton.TabIndex = 7;
            this.thirdRequestButton.Text = "Third request";
            this.thirdRequestButton.UseVisualStyleBackColor = true;
            this.thirdRequestButton.Click += new System.EventHandler(this.thirdRequestButton_Click);
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 259);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.ReadOnly = true;
            this.inputRichTextBox.Size = new System.Drawing.Size(290, 143);
            this.inputRichTextBox.TabIndex = 8;
            this.inputRichTextBox.Text = "";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(328, 259);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(281, 143);
            this.resultRichTextBox.TabIndex = 9;
            this.resultRichTextBox.Text = "";
            // 
            // CollectionGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 416);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.thirdRequestButton);
            this.Controls.Add(this.secondRequestButton);
            this.Controls.Add(this.firstRequestButton);
            this.Controls.Add(this.orderByDescButton);
            this.Controls.Add(this.orderByButton);
            this.Controls.Add(this.generateCollection);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectionGeneration";
            this.Text = "Collection Generation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Button generateCollection;
        private System.Windows.Forms.Button orderByButton;
        private System.Windows.Forms.Button orderByDescButton;
        private System.Windows.Forms.Button firstRequestButton;
        private System.Windows.Forms.Button secondRequestButton;
        private System.Windows.Forms.Button thirdRequestButton;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}

