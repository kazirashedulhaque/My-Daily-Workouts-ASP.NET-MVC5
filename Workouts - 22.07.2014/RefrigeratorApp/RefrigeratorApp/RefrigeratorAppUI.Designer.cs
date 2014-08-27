namespace RefrigeratorApp
{
    partial class RefrigeratorAppUI
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
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.noOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weightPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingWeightTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Items:";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(131, 15);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 22);
            this.capacityTextBox.TabIndex = 0;
            // 
            // noOfItemsTextBox
            // 
            this.noOfItemsTextBox.Location = new System.Drawing.Point(131, 91);
            this.noOfItemsTextBox.Name = "noOfItemsTextBox";
            this.noOfItemsTextBox.Size = new System.Drawing.Size(100, 22);
            this.noOfItemsTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current weight:";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(131, 173);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentWeightTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight/Unit";
            // 
            // weightPerUnitTextBox
            // 
            this.weightPerUnitTextBox.Location = new System.Drawing.Point(376, 92);
            this.weightPerUnitTextBox.Name = "weightPerUnitTextBox";
            this.weightPerUnitTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightPerUnitTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remaining Weight:";
            // 
            // remainingWeightTextbox
            // 
            this.remainingWeightTextbox.Location = new System.Drawing.Point(376, 172);
            this.remainingWeightTextbox.Name = "remainingWeightTextbox";
            this.remainingWeightTextbox.Size = new System.Drawing.Size(100, 22);
            this.remainingWeightTextbox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(294, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(508, 93);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // RefrigeratorAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 239);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remainingWeightTextbox);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.weightPerUnitTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noOfItemsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorAppUI";
            this.Text = "Refrigerator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox noOfItemsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weightPerUnitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainingWeightTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button enterButton;
    }
}

