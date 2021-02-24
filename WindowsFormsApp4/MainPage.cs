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
        Panel goBack;
        public void hideAll()
        {
            welcPanel.Hide();
            HomePanel.Hide();
            tourNamePanel.Hide();
            PlayerChoicePanel.Hide();
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
            goBack = tourNamePanel;
            showPlayerChoice();
        }
        public void showPlayerChoice()
        {
            PlayerTitle.Text = "PLAYER " + playerCnt;
            PlayerChoicePanel.Show();

        }


        private void lgnChcBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void regChcBtn_Click(object sender, EventArgs e)
        {

        }

        private void ongTourBtn_Click(object sender, EventArgs e)
        {
            goBack = HomePanel;
            hideAll();
            showTopButtons();
        }
    }
}
