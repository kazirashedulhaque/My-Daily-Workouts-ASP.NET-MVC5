using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    public partial class CircleUI : Form
    {
        Circle aCircle = new Circle();

        public CircleUI()
        {
            InitializeComponent();
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            GetRadius();
            MessageBox.Show(aCircle.ShowDiameter().ToString());
        }

        private void GetRadius()
        {
            aCircle.radius = Convert.ToDouble(radiusTextBox.Text);
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {

            GetRadius();
            MessageBox.Show(aCircle.ShowPerimeter().ToString());

        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            GetRadius();
            MessageBox.Show(aCircle.ShowArea().ToString());

        }
    }
}
