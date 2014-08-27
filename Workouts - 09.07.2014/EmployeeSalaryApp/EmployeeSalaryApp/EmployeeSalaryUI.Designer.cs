namespace EmployeeSalaryApp
{
    partial class EmployeeSalaryUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.salaryAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(228, 29);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.employeeNameTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(228, 70);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(175, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // salaryAmountTextBox
            // 
            this.salaryAmountTextBox.Location = new System.Drawing.Point(228, 108);
            this.salaryAmountTextBox.Name = "salaryAmountTextBox";
            this.salaryAmountTextBox.Size = new System.Drawing.Size(175, 20);
            this.salaryAmountTextBox.TabIndex = 6;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(228, 412);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(175, 20);
            this.totalAmountTextBox.TabIndex = 7;
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(45, 229);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(297, 160);
            this.employeeListBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(328, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(328, 179);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // EmployeeSalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 461);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.salaryAmountTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalaryUI";
            this.Text = "EmployeeSalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox salaryAmountTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
    }
}

