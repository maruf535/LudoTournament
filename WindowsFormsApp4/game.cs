using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp4
{
    public partial class game : Form
    {
        public gameFunctions gmf = new gameFunctions();//ei class er bhitore shob method and properties ache
        public MainPage backPage;
        public game()
        {
            InitializeComponent();
        }


        private void game_Load(object sender, EventArgs e)
        {
            gmf.initPlayers();
            setPlayerRollBtns();//sets the player roll buttons to an array which is contained in gameFunctions class
            setDiceBoxes();//sets the 6 dice roll result boxes to an array which is contained in gameFunctions class
            setRankBoxes();
            setTokens();
            setPotraits();
            setNames();
            hidePlayerNotInGame();
            gmf.gameRankPage = GameResultPanel;
            gmf.gameRankPage.Hide();
            gmf.theBoard = ludoBoard;
            gmf.showPlayerRollBtn();//shows the roll button for the player who has its turn now
        }

        //private void redPlayerRollBtn_Click(object sender, EventArgs e)
        //{
        //    hitRollBtn();//the actions after hitting the roll button
        //}

        //private void bluePlayerRollBtn_Click(object sender, EventArgs e)
        //{

        //    hitRollBtn();//the actions after hitting the roll button
        //}

        //private void greenPlayerRollBtn_Click(object sender, EventArgs e)
        //{
        //    hitRollBtn();//the actions after hitting the roll button
        //}

        //private void yellowPlayerRollBtn_Click(object sender, EventArgs e)
        //{
        //    hitRollBtn();//the actions after hitting the roll button
        //}
        //ei 4 tar khetre eki kaaj hocche, tai shob gular click event e same function die diechi

        
        public void hitRollBtn_Click(object sender, EventArgs e)
        {

            gmf.rollDice();
        }

        public void setPlayerRollBtns()
        {
            //gameFunctios er roll button er array te object initialized hocche
            gmf.playerRollBtns[1] = redPlayerRollBtn;
            gmf.playerRollBtns[2] = greenPlayerRollBtn;
            gmf.playerRollBtns[3] = yellowPlayerRollBtn;
            gmf.playerRollBtns[4] = bluePlayerRollBtn;
        }
        public void setDiceBoxes()
        {
            //gameFunctions er dice box er array te object initialize hocche
            gmf.diceBoxes[1] = diceBox1;
            gmf.diceBoxes[2] = diceBox2;
            gmf.diceBoxes[3] = diceBox3;
            gmf.diceBoxes[4] = diceBox4;
            gmf.diceBoxes[5] = diceBox5;
            gmf.diceBoxes[6] = diceBox6;
            gmf.hideAllDiceBoxes();
        }

        public void setRankBoxes()
        {
            gmf.playersArray[1].playerRankBox = playerRankBox1;
            gmf.playersArray[2].playerRankBox = playerRankBox2;
            gmf.playersArray[3].playerRankBox = playerRankBox3;
            gmf.playersArray[4].playerRankBox = playerRankBox4;

            for (int i = 1; i <= 4; i++)
                gmf.playersArray[i].playerRankBox.Hide();
        }

        public void setTokens()
        {
            gmf.playersArray[1].PlayerTokens[1].setAll(redToken1,1);
            gmf.playersArray[1].PlayerTokens[2].setAll(redToken2,1);
            gmf.playersArray[1].PlayerTokens[3].setAll(redToken3,1);
            gmf.playersArray[1].PlayerTokens[4].setAll(redToken4,1);
            gmf.playersArray[2].PlayerTokens[1].setAll(greenToken1,2);
            gmf.playersArray[2].PlayerTokens[2].setAll(greenToken2,2);
            gmf.playersArray[2].PlayerTokens[3].setAll(greenToken3,2);
            gmf.playersArray[2].PlayerTokens[4].setAll(greenToken4,2);
            gmf.playersArray[3].PlayerTokens[1].setAll(yellowToken1,3);
            gmf.playersArray[3].PlayerTokens[2].setAll(yellowToken2,3);
            gmf.playersArray[3].PlayerTokens[3].setAll(yellowToken3,3);
            gmf.playersArray[3].PlayerTokens[4].setAll(yellowToken4,3);
            gmf.playersArray[4].PlayerTokens[1].setAll(blueToken1,4);
            gmf.playersArray[4].PlayerTokens[2].setAll(blueToken2,4);
            gmf.playersArray[4].PlayerTokens[3].setAll(blueToken3,4);
            gmf.playersArray[4].PlayerTokens[4].setAll(blueToken4,4);
        }

        public void setPotraits()
        {
            redPlayerPotrait.Image = gmf.getPotrait(gmf.playersArray[1].playerGender);
            greenPlayerPotrait.Image = gmf.getPotrait(gmf.playersArray[2].playerGender);
            yellowPlayerPotrait.Image = gmf.getPotrait(gmf.playersArray[3].playerGender);
            bluePlayerPotrait.Image = gmf.getPotrait(gmf.playersArray[4].playerGender);
        }

        public void setNames()
        {
            redPlayerName.Text = gmf.playersArray[1].playerName;
            greenPlayerName.Text = gmf.playersArray[2].playerName;
            yellowPlayerName.Text = gmf.playersArray[3].playerName;
            bluePlayerName.Text = gmf.playersArray[4].playerName;
        }
        public void hidePlayerNotInGame()
        {
            for(int i = 1; i <= 4; i++)
            {
                if (gmf.playersArray[i].playerRank != 0)
                {
                    hidePlayer(i);
                }
            }
        }

        public void hidePlayer(int ind)
        {
            for(int i = 1; i <= 4; i++)
            {
                gmf.playersArray[ind].PlayerTokens[i].tokenPicture.Hide();
            }

            if (ind == 1)
            {
                redPlayerName.Hide();
                redPlayerPotrait.Hide();
            }
            else if (ind == 2)
            {
                greenPlayerName.Hide();
                greenPlayerPotrait.Hide();
            }
            else if (ind == 3)
            {
                yellowPlayerName.Hide();
                yellowPlayerPotrait.Hide();
            }
            else if (ind == 4)
            {
                bluePlayerName.Hide();
                bluePlayerPotrait.Hide();
            }
        }


        private void diceBox1_Click(object sender, EventArgs e)
        {
            gmf.selectDiceBox(1);
        }

        private void diceBox2_Click(object sender, EventArgs e)
        {

            gmf.selectDiceBox(2);
        }

        private void diceBox3_Click(object sender, EventArgs e)
        {
            gmf.selectDiceBox(3);

        }

        private void diceBox4_Click(object sender, EventArgs e)
        {
            gmf.selectDiceBox(4);

        }

        private void diceBox5_Click(object sender, EventArgs e)
        {
            gmf.selectDiceBox(5);

        }

        private void diceBox6_Click(object sender, EventArgs e)
        {
            gmf.selectDiceBox(6);

        }

        private void redToken1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gmf.playerTurn.ToString() + ", " + gmf.selectedDice.ToString());
            if (gmf.playerTurn == 1 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(1);
            }

        }

        private void redToken2_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 1 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(2);
            }
        }

        private void redToken3_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 1 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(3);
            }
        }

        private void redToken4_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 1 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(4);
            }
        }

        private void greenToken1_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 2 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(1);
            }
        }

        private void greenToken2_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 2 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(2);
            }
        }

        private void greenToken3_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 2 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(3);
            }
        }

        private void greenToken4_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 2 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(4);
            }
        }

        private void yellowToken1_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 3 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(1);
            }
        }

        private void yellowToken2_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 3 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(2);
            }
        }

        private void yellowToken3_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 3 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(3);
            }
        }

        private void yellowToken4_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 3 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(4);
            }
        }

        private void blueToken1_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 4 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(1);
            }
        }

        private void blueToken2_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 4 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(2);
            }
        }

        private void blueToken3_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 4 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(3);
            }
        }

        private void blueToken4_Click(object sender, EventArgs e)
        {
            if (gmf.playerTurn == 4 && gmf.selectedDice != -1 && gmf.playerMove==true)
            {
                gmf.moveToken(4);
            }
        }

        private void game_SizeChanged(object sender, EventArgs e)
        {
            this.gamePanel.Left = this.Width / 4;
            this.gamePanel.Top = this.Height / 8;
            this.GameResultPanel.Left = this.Width / 4;
            this.GameResultPanel.Top = this.Height / 8;
        }

        private void goHomeBtn_Click(object sender, EventArgs e)
        {
            backPage.Show();
            backPage.loadFixture(gmf.prData.tourID);
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("None of the Data will be saved\nAre your sure ?","Quit Game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                backPage.Show();
                backPage.loadFixture(gmf.prData.tourID);
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are your sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                backPage.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void redPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void bluePlayerName_Click(object sender, EventArgs e)
        {

        }

        private void yellowPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void greenPlayerName_Click(object sender, EventArgs e)
        {

        }


        //private static void delay(int Time_delay)
        //{
        //    int i = 0;
        //    //  ameTir = new System.Timers.Timer();
        //    _delayTimer = new System.Timers.Timer();
        //    _delayTimer.Interval = Time_delay;
        //    _delayTimer.AutoReset = false; //so that it only calls the method once
        //    _delayTimer.Elapsed += (s, args) => i = 1;
        //    _delayTimer.Start();
        //    while (i == 0) { };
        //}
    }
}
