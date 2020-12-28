namespace OOP_LAB_5
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.creatorInfoLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.userNameResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(64, 44);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(73, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name : ";
            // 
            // creatorInfoLabel
            // 
            this.creatorInfoLabel.AutoSize = true;
            this.creatorInfoLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorInfoLabel.Location = new System.Drawing.Point(64, 75);
            this.creatorInfoLabel.Name = "creatorInfoLabel";
            this.creatorInfoLabel.Size = new System.Drawing.Size(115, 15);
            this.creatorInfoLabel.TabIndex = 1;
            this.creatorInfoLabel.Text = "Creator : Ilya Istomin";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(64, 105);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(91, 15);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version : 20.20.1";
            // 
            // userNameResultLabel
            // 
            this.userNameResultLabel.AutoSize = true;
            this.userNameResultLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameResultLabel.Location = new System.Drawing.Point(130, 45);
            this.userNameResultLabel.Name = "userNameResultLabel";
            this.userNameResultLabel.Size = new System.Drawing.Size(0, 15);
            this.userNameResultLabel.TabIndex = 3;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 162);
            this.Controls.Add(this.userNameResultLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.creatorInfoLabel);
            this.Controls.Add(this.userNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label creatorInfoLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label userNameResultLabel;
    }
}