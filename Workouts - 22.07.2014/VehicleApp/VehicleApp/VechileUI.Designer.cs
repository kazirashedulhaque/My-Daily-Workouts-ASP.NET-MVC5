namespace VehicleApp
{
    partial class VechileUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regnoTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.minSpeedTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Average Speed:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // regnoTextBox
            // 
            this.regnoTextBox.Location = new System.Drawing.Point(125, 77);
            this.regnoTextBox.Name = "regnoTextBox";
            this.regnoTextBox.Size = new System.Drawing.Size(170, 20);
            this.regnoTextBox.TabIndex = 1;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(125, 188);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(170, 20);
            this.speedTextBox.TabIndex = 3;
            // 
            // minSpeedTextBox
            // 
            this.minSpeedTextBox.Location = new System.Drawing.Point(125, 244);
            this.minSpeedTextBox.Name = "minSpeedTextBox";
            this.minSpeedTextBox.Size = new System.Drawing.Size(170, 20);
            this.minSpeedTextBox.TabIndex = 5;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(125, 288);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(170, 20);
            this.maxSpeedTextBox.TabIndex = 6;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(125, 332);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(170, 20);
            this.averageTextBox.TabIndex = 8;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(368, 80);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(368, 280);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(368, 186);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "account";
            // 
            // VechileUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.minSpeedTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.regnoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VechileUI";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regnoTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox minSpeedTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label7;
    }
}

