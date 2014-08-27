using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedCalculatorApp
{
    public partial class SpeedCalculatorUI : Form
    {
        Speed sampleSpeed = new Speed();
        public SpeedCalculatorUI()
        {
            InitializeComponent();
        }

        
        private void enterButton_Click(object sender, EventArgs e)
        {
            sampleSpeed.speed = Convert.ToDouble(speedTextBox.Text);
            
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            sampleSpeed.minimumSpeed = Convert.ToDouble(speedTextBox.Text);
            minimumSpeedTextBox.Text = sampleSpeed.minimumSpeed.ToString();
            

            //if (sampleSpeed.speed < sampleSpeed.minimumSpeed)
            //{
            //    sampleSpeed.minimumSpeed = Convert.ToDouble(speedTextBox.Text);
            //    minimumSpeedTextBox.Text = sampleSpeed.minimumSpeed.ToString();
            //}
            //else 
            if (sampleSpeed.speed > sampleSpeed.minimumSpeed)
            {
                sampleSpeed.maximumSpeed = Convert.ToDouble(speedTextBox.Text);
                maximumSpeedTextBox.Text = sampleSpeed.maximumSpeed.ToString();
            }
            else if (sampleSpeed.speed < sampleSpeed.minimumSpeed)
            {
                sampleSpeed.minimumSpeed = Convert.ToDouble(speedTextBox.Text);
                minimumSpeedTextBox.Text = sampleSpeed.minimumSpeed.ToString();
            }

            //else if (sampleSpeed.speed > sampleSpeed.minimumSpeed && sampleSpeed.speed < sampleSpeed.maximumSpeed)
            //{
                
            //}
        }
    }
}
