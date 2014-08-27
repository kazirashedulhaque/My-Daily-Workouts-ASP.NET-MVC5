using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    
    public partial class VechileUI : Form
    {
        Vehicle aVehicle = new Vehicle();
        private double totalSpeed = 0;
        //private double maxSpeed = 0;
        //private double minSpeed = 999999999999;
        private int counter = 0;
        public VechileUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.name = nameTextBox.Text;
            aVehicle.regNo = regnoTextBox.Text;
            label7.Text = "Name :"+aVehicle.name+" Reg No: "+ aVehicle.regNo;
            MessageBox.Show("Account created");

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (aVehicle.name == null || aVehicle.regNo == null)
            {
                MessageBox.Show("plz create account to calculate speed");
            }
            else
            {
                aVehicle.speed = Convert.ToDouble(speedTextBox.Text);
                totalSpeed = totalSpeed + aVehicle.speed;
                aVehicle.maxSpeed = aVehicle.MaxSpeed(aVehicle.speed, aVehicle.maxSpeed);
                aVehicle.minSpeed = aVehicle.MinSpeed(aVehicle.speed, aVehicle.minSpeed);
                counter++;
                speedTextBox.Text = string.Empty;

            }
         
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.minSpeed.ToString();
            maxSpeedTextBox.Text = aVehicle.maxSpeed.ToString();
            averageTextBox.Text = aVehicle.AverageSpeed(totalSpeed, counter);


        }

        
    }
}
