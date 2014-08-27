namespace EmployeeInformationApp
{
    partial class EmployeeInformationUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(178, 44);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(175, 20);
            this.employeeIdTextBox.TabIndex = 3;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(178, 81);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.employeeNameTextBox.TabIndex = 4;
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(178, 116);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(175, 20);
            this.employeeSalaryTextBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(131, 189);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(240, 189);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton.TabIndex = 7;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // EmployeeInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 251);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.employeeSalaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInformationUI";
            this.Text = "EmployeeInformationUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button retrieveButton;
    }
}

