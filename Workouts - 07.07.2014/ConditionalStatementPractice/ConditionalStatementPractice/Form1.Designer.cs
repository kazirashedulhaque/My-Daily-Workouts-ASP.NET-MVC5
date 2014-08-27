namespace ConditionalStatementPractice
{
    partial class SolarSystemUI
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
            this.planetNameLabel = new System.Windows.Forms.Label();
            this.showPlanetNumberButton = new System.Windows.Forms.Button();
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // planetNameLabel
            // 
            this.planetNameLabel.AutoSize = true;
            this.planetNameLabel.Location = new System.Drawing.Point(82, 47);
            this.planetNameLabel.Name = "planetNameLabel";
            this.planetNameLabel.Size = new System.Drawing.Size(68, 13);
            this.planetNameLabel.TabIndex = 0;
            this.planetNameLabel.Text = "Planet Name";
            // 
            // showPlanetNumberButton
            // 
            this.showPlanetNumberButton.Location = new System.Drawing.Point(85, 117);
            this.showPlanetNumberButton.Name = "showPlanetNumberButton";
            this.showPlanetNumberButton.Size = new System.Drawing.Size(147, 23);
            this.showPlanetNumberButton.TabIndex = 1;
            this.showPlanetNumberButton.Text = "Show Planet Number";
            this.showPlanetNumberButton.UseVisualStyleBackColor = true;
            this.showPlanetNumberButton.Click += new System.EventHandler(this.Show_Click);
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Earth",
            "Mars",
            "Saturn",
            "Venus",
            "Pluto"});
            this.planetNameComboBox.Location = new System.Drawing.Point(203, 47);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetNameComboBox.TabIndex = 2;
            // 
            // SolarSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 236);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.showPlanetNumberButton);
            this.Controls.Add(this.planetNameLabel);
            this.Name = "SolarSystemUI";
            this.Text = "Solar System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label planetNameLabel;
        private System.Windows.Forms.Button showPlanetNumberButton;
        private System.Windows.Forms.ComboBox planetNameComboBox;
    }
}

