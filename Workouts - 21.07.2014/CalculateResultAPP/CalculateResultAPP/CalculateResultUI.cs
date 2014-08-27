using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateResultAPP
{
    public partial class CalculateResultUI : Form
    {
        Result aResult = new Result();
        public CalculateResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            GetAverage();
            averageTextBox.Text = aResult.AverageCalculator().ToString();

            if (Convert.ToDouble(physicsTextBox.Text) >= 80 && Convert.ToDouble(chemistryTextBox.Text) >= 80 && Convert.ToDouble(mathTextBox.Text) >= 80)
            {
                gradeLetterTextBox.Text = "A+";
            }

            else if (Convert.ToDouble(physicsTextBox.Text) >= 70 && Convert.ToDouble(chemistryTextBox.Text) >= 70 && Convert.ToDouble(mathTextBox.Text) >= 70)
            {
                gradeLetterTextBox.Text = "B+";
            }

            else if (Convert.ToDouble(physicsTextBox.Text) >= 60 && Convert.ToDouble(chemistryTextBox.Text) >= 60 && Convert.ToDouble(mathTextBox.Text) >= 60)
            {
                gradeLetterTextBox.Text = "C+";
            }
            else if (Convert.ToDouble(physicsTextBox.Text) >= 50 && Convert.ToDouble(chemistryTextBox.Text) >= 50 && Convert.ToDouble(mathTextBox.Text) >= 50)
            {
                gradeLetterTextBox.Text = "D+";
            }
            else if (Convert.ToDouble(physicsTextBox.Text) < 50 && Convert.ToDouble(chemistryTextBox.Text) < 50 && Convert.ToDouble(mathTextBox.Text) < 50)
            {
                gradeLetterTextBox.Text = "F";
            }

            else if (Convert.ToDouble(physicsTextBox.Text) <= 40 || Convert.ToDouble(chemistryTextBox.Text) <= 40 || Convert.ToDouble(mathTextBox.Text) <= 40)
            {
                gradeLetterTextBox.Text = "F";
            }
        }

        private void GetAverage()
        {
            aResult.physicsNumber = Convert.ToDouble(physicsTextBox.Text);
            aResult.chemistryNumber = Convert.ToDouble(chemistryTextBox.Text);
            aResult.mathNumber = Convert.ToDouble(mathTextBox.Text);
        }
    }
}
