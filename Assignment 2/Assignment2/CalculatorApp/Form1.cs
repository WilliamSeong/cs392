using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        double currentValue;
        string currentOperator;
        bool newNumber = false;
        bool decimalPresent = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void zroButton_Click(object sender, EventArgs e)
        {
            numberClick((System.Windows.Forms.Button)sender);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operatorClick((System.Windows.Forms.Button)sender);
        }

        private void minusBButton_Click(object sender, EventArgs e)
        {
            operatorClick((System.Windows.Forms.Button)sender);
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            operatorClick((System.Windows.Forms.Button)sender);

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operatorClick((System.Windows.Forms.Button)sender);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!decimalPresent)
            {
                inputLabel.Text = inputLabel.Text + ".";
                decimalPresent = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputLabel.Text = "0.0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            double secondValue;
            double Result;

            secondValue = Convert.ToDouble(inputLabel.Text);

            if (currentOperator == "+")
            {
                Result = (currentValue + secondValue);
                inputLabel.Text = Convert.ToString(Result);
                currentValue = Result;
            }
            if (currentOperator == "-")
            {
                Result = (currentValue - secondValue);
                inputLabel.Text = Convert.ToString(Result);
                currentValue = Result;
            }
            if (currentOperator == "*")
            {
                Result = (currentValue * secondValue);
                inputLabel.Text = Convert.ToString(Result);
                currentValue = Result;
            }
            if (currentOperator == "/")
            {
                if (secondValue == 0)
                {
                    inputLabel.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (currentValue / secondValue);
                    inputLabel.Text = Convert.ToString(Result);
                    currentValue = Result;
                }
            }
        }

        private void numberClick(System.Windows.Forms.Button button)
        {
            if ((inputLabel.Text == "0.0" || inputLabel.Text == "0") && inputLabel.Text != null || newNumber == true)
            {
                inputLabel.Text = button.Text;
                newNumber = false;
            }
            else
            {
                inputLabel.Text = inputLabel.Text + button.Text;
            }
        }

        private void operatorClick(System.Windows.Forms.Button button)
        {
            currentValue = Double.Parse(inputLabel.Text);
            newNumber = true;
            decimalPresent = false;
            currentOperator = button.Text;
        }

    }
}
