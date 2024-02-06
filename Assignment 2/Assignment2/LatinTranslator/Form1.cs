using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            latinLabel.Text = "up";
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            latinLabel.Text = "down";
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            latinLabel.Text = "center";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
