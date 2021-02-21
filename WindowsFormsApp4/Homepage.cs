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

        private void newTourBtn_Click(object sender, EventArgs e)
        {
            tournamentNamePage login = new tournamentNamePage();
            login.goBack = this;
            login.Show();
            this.Hide();
        }
        //kono function er naam change korle sheta jodi event handler hoy, 
        //aage copy kore, real ta rekhe notun tar naam change kore,
        //design theke event e function er naam select kore aste hobe
        //direct naam change kore dile error ashbe 
        //R error ashle "ignore and continue" deoa jabe na, problem koi hoyeche sheta dekhate bollei tjik kora jabe
        private void ongTourBtn_Click(object sender, EventArgs e)
        {
            ongoingTournamentHomepage ongTour = new ongoingTournamentHomepage();
            ongTour.Show();
            this.Hide();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
