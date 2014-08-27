namespace PersonalInformation
{
    partial class PersonalInformation
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Father\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mother\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(311, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(311, 83);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.fathersNameTextBox.TabIndex = 5;
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(311, 117);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.mothersNameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(311, 160);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(192, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(157, 241);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(385, 241);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 9;
            this.View.Text = "VIEW";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 366);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalInformation";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button View;
    }
}

