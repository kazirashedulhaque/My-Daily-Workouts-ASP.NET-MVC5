namespace StudentListApp
{
    partial class StudentListUI
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
            this.showAllButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stuedntListView = new System.Windows.Forms.ListView();
            this.regNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(179, 187);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 15;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(52, 187);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(118, 125);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(118, 88);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(118, 51);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(162, 20);
            this.regNoTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reg No.";
            // 
            // stuedntListView
            // 
            this.stuedntListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regNoColumnHeader,
            this.firstNameColumnHeader,
            this.lastNameColumnHeader});
            this.stuedntListView.Location = new System.Drawing.Point(52, 258);
            this.stuedntListView.Name = "stuedntListView";
            this.stuedntListView.Size = new System.Drawing.Size(228, 97);
            this.stuedntListView.TabIndex = 16;
            this.stuedntListView.UseCompatibleStateImageBehavior = false;
            this.stuedntListView.View = System.Windows.Forms.View.Details;
            // 
            // regNoColumnHeader
            // 
            this.regNoColumnHeader.Text = "Reg No.";
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "First Name";
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Last Name";
            // 
            // StudentListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 383);
            this.Controls.Add(this.stuedntListView);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentListUI";
            this.Text = "StudentListUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView stuedntListView;
        private System.Windows.Forms.ColumnHeader regNoColumnHeader;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
    }
}

