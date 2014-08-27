using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionalStatementPractice
{
    public partial class SolarSystemUI : Form
    {
        public SolarSystemUI()
        {
            InitializeComponent();
        }

        

        string selectedPlanet;

        private void Show_Click(object sender, EventArgs e)
        {
            

            selectedPlanet = planetNameComboBox.Text;

            if (planetNameComboBox.Text == "Earth")
            {
                MessageBox.Show("This is planet number one.");
            }
            else if (planetNameComboBox.Text == "Mars")
            {
                MessageBox.Show("This is planet number two.");
            }
            else if (planetNameComboBox.Text == "Saturn")
            {
                MessageBox.Show("This is planet number three.");
            }
            else if (planetNameComboBox.Text == "Venus")
            {
                MessageBox.Show("This is planet number four.");
            }
            else if (planetNameComboBox.Text == "Pluto")
            {
                MessageBox.Show("This is planet number five.");
            }

        }
    }
}
