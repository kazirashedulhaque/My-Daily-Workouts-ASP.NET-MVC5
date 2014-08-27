namespace SimpleInterestCalculatorUI
{
    partial class SimpleInterestCalculatorUI
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
            this.principalAmountTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.timePeriodTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Period";
            // 
            // principalAmountTextBox
            // 
            this.principalAmountTextBox.Location = new System.Drawing.Point(185, 43);
            this.principalAmountTextBox.Name = "principalAmountTextBox";
            this.principalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.principalAmountTextBox.TabIndex = 3;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(185, 76);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestRateTextBox.TabIndex = 4;
            // 
            // timePeriodTextBox
            // 
            this.timePeriodTextBox.Location = new System.Drawing.Point(185, 111);
            this.timePeriodTextBox.Name = "timePeriodTextBox";
            this.timePeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.timePeriodTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(185, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(185, 198);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Year)";
            // 
            // SimpleInterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.timePeriodTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.principalAmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterestCalculatorUI";
            this.Text = "SimpleInterestCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principalAmountTextBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox timePeriodTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

