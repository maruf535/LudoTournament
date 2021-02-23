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
    public partial class playerChoice : Form
    {
        public playerChoice()
        {
            InitializeComponent();
        }

        private void player1choice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 player1 = new Form5();
            player1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerRegister player1 = new PlayerRegister();
            player1.Show();
            this.Hide();
        }
    }
}
