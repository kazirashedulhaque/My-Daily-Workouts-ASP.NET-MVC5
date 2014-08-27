using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorAppUI : Form
    {
        Refrigerator aRefrigerator;
        public RefrigeratorAppUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator = new Refrigerator();
            aRefrigerator.capacity = Convert.ToDouble(capacityTextBox.Text);

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int noOfItem = Convert.ToInt16(noOfItemsTextBox.Text);
            double weightPerUnit = Convert.ToDouble(weightPerUnitTextBox.Text);
            try
            {
                aRefrigerator.AddItems(noOfItem,weightPerUnit);
                noOfItemsTextBox.Text = "";
                weightPerUnitTextBox.Text = "";
                currentWeightTextBox.Text = aRefrigerator.currentWeight.ToString();
                remainingWeightTextbox.Text = aRefrigerator.remainingWeight.ToString();
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message);
            }

        }
    }
}
