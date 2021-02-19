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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tournamentNamePage login = new tournamentNamePage();
            login.goBack = this;
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ongoingTournamentHomepage login = new ongoingTournamentHomepage();
            login.Show();
            this.Hide();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
