namespace CircleApp
{
    partial class CircleUI
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
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.diameterButton = new System.Windows.Forms.Button();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(283, 34);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 1;
            // 
            // diameterButton
            // 
            this.diameterButton.Location = new System.Drawing.Point(144, 111);
            this.diameterButton.Name = "diameterButton";
            this.diameterButton.Size = new System.Drawing.Size(75, 23);
            this.diameterButton.TabIndex = 2;
            this.diameterButton.Text = "Diameter";
            this.diameterButton.UseVisualStyleBackColor = true;
            this.diameterButton.Click += new System.EventHandler(this.diameterButton_Click);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Location = new System.Drawing.Point(283, 111);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(75, 23);
            this.perimeterButton.TabIndex = 3;
            this.perimeterButton.Text = "perimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(453, 111);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 4;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // CircleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.diameterButton);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CircleUI";
            this.Text = "CircleUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button diameterButton;
        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Button areaButton;
    }
}

