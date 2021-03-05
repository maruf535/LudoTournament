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
    public partial class MainPage : Form
    {
        int playerCnt;
        int tourState;
        int[] playerId;
        Panel goBack;
        public void hideAll()
        {
            welcPanel.Hide();
            HomePanel.Hide();
            tourNamePanel.Hide();
            PlayerChoicePanel.Hide();
            PlayerOneLoginPanel.Hide();
            PlayerOneRegisterPanel.Hide();
            ChooseColourPanel.Hide();
            OngoingTournamentPanel.Hide();
            DecisionPagePanel.Hide();
            FixurePanel.Hide();
        }
        public void hideTopButtons()
        {
            backBtn.Hide();
            homeBtn.Hide();
        }
        public void showTopButtons()
        {
            backBtn.Show();
            homeBtn.Show();
        }
        public void showHome()
        {
            hideTopButtons();
            HomePanel.Show();
        }
        public MainPage()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            hideAll();
            hideTopButtons();
            welcPanel.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            showHome();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack.Show();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Show();
            welcPanel.Hide();
        }

        private void newTourBtn_Click(object sender, EventArgs e)
        {
            goBack = HomePanel;
            hideAll();
            tourNamePanel.Show();
            playerCnt = 1;
            showTopButtons();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //take the tounament name input
            //check if this name already exists
            //if does, then promt an alert
            //and take another input
            //otherwise insert it into database
            //and move to the next panel, that is first player info
            hideAll();
            tourState = 4;
            goBack = tourNamePanel;
            showPlayerChoice();
        }
        public void showPlayerChoice()
        {
            //jemon ta ekhane korsi
            PlayerTitle.Text = "PLAYER " + playerCnt;//erokom oh accha accha ami kortesi tumi dekho
            PlayerChoicePanel.Show();

        }


        private void lgnChcBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = PlayerChoicePanel;
            //ekhon oi function ta ekhan theke  call kore dibo
            playerLoginPanelShow();
        }
        public void playerLoginPanelShow()
        {
            //ekhane theke player login panel ta show hocche
            //tai amra ekhanei oi title ta change korbo
            //kintu jehetu ei player login panel amra aro koek jayga theke show korte pari
            //tai etake playerLoginPanelShow naame ekta function e rekhe dibo
            //shudhu playerCnt disilam, sathe"Player " eta add kore dite hobe shurute
            lgnPageTitle.Text ="PLAYER " + playerCnt.ToString();//text ta jehetu string, tai etake .toString() die dite hobe
            PlayerOneLoginPanel.Show();
        }
        private void regChcBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = PlayerOneLoginPanel;
            playerRegisterPanelShow();
        }
        public void playerRegisterPanelShow()
        {
            regPageTitle.Text = "PLAYER " + playerCnt.ToString();
            PlayerOneRegisterPanel.Show();
        }
        private void ongTourBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = HomePanel;
            OngoingTournamentPanel.Show();
            showTopButtons();
        }

<<<<<<< HEAD
        private void playerLgnBtn_Click(object sender, EventArgs e)
        {


        }
        private void playerRegLgnBtn_Click(object sender, EventArgs e)
        {
            //data entry korte hbe
            if (playerCnt < tourState)
            {
                hideAll();
                playerCnt++;
                //PlayerChoicePanel.Show();
                showPlayerChoice();
            }
        }

        private void plyrLgnBtn_Click(object sender, EventArgs e)
        {
            //data entry korte hbe
            if (playerCnt < tourState)
            {
                hideAll();
                playerCnt++;
                //PlayerChoicePanel.Show();
                showPlayerChoice();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void FixurePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideAll();
            goBack = OngoingTournamentPanel;
            FixurePanel.Show();
        }

        private void ongTourNextBtn_Click(object sender, EventArgs e)
=======
        private void HomePanel_Paint(object sender, PaintEventArgs e)
>>>>>>> 6013dd14ac4849eef12e112fda7544691c58f56b
        {

        }
    }
}
