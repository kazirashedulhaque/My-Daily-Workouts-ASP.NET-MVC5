namespace CustomerQueueManagementApp
{
    partial class CustomerQueueManagementUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.enqueueNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(160, 36);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.enqueueNameTextBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 3;
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(160, 132);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
            this.groupBox2.Controls.Add(this.dequeueNameTextBox);
            this.groupBox2.Controls.Add(this.serialNoTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(476, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serial No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complain";
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(105, 40);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(196, 20);
            this.serialNoTextBox.TabIndex = 3;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(105, 79);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.dequeueNameTextBox.TabIndex = 4;
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(105, 122);
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(196, 20);
            this.dequeueComplainTextBox.TabIndex = 5;
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(327, 40);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 6;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(19, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(833, 154);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(43, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // CustomerQueueManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueManagementUI";
            this.Text = "CustomerQueueManagementUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

