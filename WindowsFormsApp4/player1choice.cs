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
    public partial class player1choice : Form
    {
        public player1choice()
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
            Player1register player1 = new Player1register();
            player1.Show();
            this.Hide();
        }
    }
}
