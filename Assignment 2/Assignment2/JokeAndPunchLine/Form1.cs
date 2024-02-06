using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            setupLabel.Text = "What do computer science students and culinary students have in common?";
        }

        private void punchLineButton_Click(object sender, EventArgs e)
        {
            if (setupLabel.Text != "")
            {
                punchLineLabel.Text = "They both submit spaghetti for their assignments";
            }
        }

        private void punchLineLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
