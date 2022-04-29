namespace Webinar1b_StackOfObjects
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SpecialismLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SpecialismTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.JobIdLabel = new System.Windows.Forms.Label();
            this.JobDesc = new System.Windows.Forms.Label();
            this.JobIdTextBox = new System.Windows.Forms.TextBox();
            this.JobDescTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 49);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 26);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // SpecialismLabel
            // 
            this.SpecialismLabel.AutoSize = true;
            this.SpecialismLabel.Location = new System.Drawing.Point(24, 112);
            this.SpecialismLabel.Name = "SpecialismLabel";
            this.SpecialismLabel.Size = new System.Drawing.Size(85, 20);
            this.SpecialismLabel.TabIndex = 2;
            this.SpecialismLabel.Text = "Specialism";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(24, 156);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(53, 20);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Salary";
            // 
            // SpecialismTextBox
            // 
            this.SpecialismTextBox.Location = new System.Drawing.Point(133, 106);
            this.SpecialismTextBox.Name = "SpecialismTextBox";
            this.SpecialismTextBox.Size = new System.Drawing.Size(100, 26);
            this.SpecialismTextBox.TabIndex = 4;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(133, 150);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 26);
            this.SalaryTextBox.TabIndex = 5;
            // 
            // JobIdLabel
            // 
            this.JobIdLabel.AutoSize = true;
            this.JobIdLabel.Location = new System.Drawing.Point(24, 278);
            this.JobIdLabel.Name = "JobIdLabel";
            this.JobIdLabel.Size = new System.Drawing.Size(26, 20);
            this.JobIdLabel.TabIndex = 6;
            this.JobIdLabel.Text = "ID";
            // 
            // JobDesc
            // 
            this.JobDesc.AutoSize = true;
            this.JobDesc.Location = new System.Drawing.Point(24, 331);
            this.JobDesc.Name = "JobDesc";
            this.JobDesc.Size = new System.Drawing.Size(46, 20);
            this.JobDesc.TabIndex = 7;
            this.JobDesc.Text = "Desc";
            // 
            // JobIdTextBox
            // 
            this.JobIdTextBox.Location = new System.Drawing.Point(133, 272);
            this.JobIdTextBox.Name = "JobIdTextBox";
            this.JobIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.JobIdTextBox.TabIndex = 8;
            // 
            // JobDescTextBox
            // 
            this.JobDescTextBox.Location = new System.Drawing.Point(133, 325);
            this.JobDescTextBox.Name = "JobDescTextBox";
            this.JobDescTextBox.Size = new System.Drawing.Size(100, 26);
            this.JobDescTextBox.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(133, 380);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 28);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.JobDescTextBox);
            this.Controls.Add(this.JobIdTextBox);
            this.Controls.Add(this.JobDesc);
            this.Controls.Add(this.JobIdLabel);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SpecialismTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.SpecialismLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpecialismLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox SpecialismTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label JobIdLabel;
        private System.Windows.Forms.Label JobDesc;
        private System.Windows.Forms.TextBox JobIdTextBox;
        private System.Windows.Forms.TextBox JobDescTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}

