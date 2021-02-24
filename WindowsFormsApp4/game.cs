using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class game : Form
    {
        Random rnd = new Random();
        public game()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void redPlayerRollBtn_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 7);
            randomTest.Text = num.ToString();
        }

        private void greenPlayerRollBtn_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 7);
            randomTest.Text = num.ToString();
        }

        private void bluePlayerRollButton_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 7);
            randomTest.Text = num.ToString();
        }

        private void yellowPlayerRollButton_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 7);
            randomTest.Text = num.ToString();
        }
    }
}
