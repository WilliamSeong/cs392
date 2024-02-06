using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class bmiCalculator : Form
    {

        bool unit;

        public bmiCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float height;
            float weight;
            float bmi;
            if (englishLabel.ForeColor == Color.Blue)
            {
                height = float.Parse(inchesText.Text);
                height += float.Parse(feetText.Text) * 12;
                weight = float.Parse(poundsText.Text);
                bmi = (weight / (height * height)) * 703;
                // MessageBox.Show(string.Format("{0:N2}", bmi));
                height = 0;
                weight = 0;
            } else
            {
                height = float.Parse(feetText.Text) / 100;
                weight = float.Parse(poundsText.Text);
                bmi = (weight / (height * height));
                // MessageBox.Show(string.Format("{0:N2}", bmi));
                height = 0;
                weight = 0;
            }
            if (bmi < 18.5)
            {
                MessageBox.Show("Underweight");
            } else if ( bmi < 25){
                MessageBox.Show("Healthy Weight");
            } else if (bmi < 30)
            {
                MessageBox.Show("Overweight");
            } else
            {
                MessageBox.Show("Obesity");
            }
        }

        private void englishLabel_Click(object sender, EventArgs e)
        {
            unit = true;
            englishLabel.ForeColor = Color.Blue;
            metricLabel.ForeColor = Color.Black;
            //englishLabel.Font.
            feetLabel.Text = "Feet";
            poundsLabel.Text = "Pounds";
            feetText.Text = "";
            inchesText.Text = "";
            poundsText.Text = "";
            inchesLabel.Visible = true;
            inchesText.Visible = true;
        }

        private void metricLabel_Click(object sender, EventArgs e)
        {
            unit = false;
            metricLabel.ForeColor = Color.Blue;
            englishLabel.ForeColor = Color.Black;
            feetLabel.Text = "Centimeters";
            poundsLabel.Text = "Kilograms";
            feetText.Text = "";
            inchesText.Text = "";
            poundsText.Text = "";
            inchesLabel.Visible = false;
            inchesText.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
