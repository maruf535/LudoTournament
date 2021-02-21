using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processHelper;//this namespace cintains the process data

namespace WindowsFormsApp4
{
    public partial class tournamentNamePage : Form
    {
        public Homepage goBack;
        public Homepage home = new Homepage();
        public processData prData;// prevous page theke paboi, to new create korar kono dorkar nai, just declare korlam

        public tournamentNamePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1choice player1 = new player1choice();
            player1.Show();
            this.Hide();
        }

        private void tournamentNamePage_Load(object sender, EventArgs e)
        {
            if (prData.newTour == true)
                MessageBox.Show("it works");
            if (prData.ongTour == true)
                MessageBox.Show("it doesnt work");

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goBack.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }
    }
}
