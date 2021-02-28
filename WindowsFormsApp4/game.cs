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
        Random rnd = new Random();//random number generate korar object
        gameFunctions gmf = new gameFunctions();//ei class er bhitore shob method and properties ache

        public game()
        {
            InitializeComponent();
        }


        private void game_Load(object sender, EventArgs e)
        {
            setPlayerRollBtns();//sets the player roll buttons to an array which is contained in gameFunctions class
            setDiceBoxes();//sets the 6 dice roll result boxes to an array which is contained in gameFunctions class
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

        
        public async void hitRollBtn_Click(object sender, EventArgs e)
        {
            gmf.shot = rnd.Next(1, 7);//generates a number between [1,7), that is 1 is included but 7 is not
            gmf.playerRollBtns[gmf.playerTurn].Image = gmf.getDiceImage(7);
            await System.Threading.Tasks.Task.Delay(2000);
            gmf.playerRollBtns[gmf.playerTurn].Image = gmf.getDiceImage(gmf.shot);
            gmf.setDice();//sets the result to current dice box 
            if (gmf.shot < 6)//checking if the shot is less then 6, then the turn is passed to the next player
            {
                await System.Threading.Tasks.Task.Delay(800);//eta just testing perpose e inlcude kora,j turn passing thikmoto hocche kina
                gmf.changeTurn();//turn change korbe, dicebox clear korbe, next player er roll button show korabe
            }
            else
                gmf.playerRollBtns[gmf.playerTurn].Image = gmf.getDiceImage(0);
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

        private void diceBox1_Click(object sender, EventArgs e)
        {
            gmf.selectedDice = 1;
        }

        private void diceBox2_Click(object sender, EventArgs e)
        {

            gmf.selectedDice = 2;
        }

        private void diceBox3_Click(object sender, EventArgs e)
        {
            gmf.selectedDice = 3;

        }

        private void diceBox4_Click(object sender, EventArgs e)
        {
            gmf.selectedDice = 4;

        }

        private void diceBox5_Click(object sender, EventArgs e)
        {
            gmf.selectedDice = 5;

        }

        private void diceBox6_Click(object sender, EventArgs e)
        {
            gmf.selectedDice = 6;

        }

        private void redToken1_Click(object sender, EventArgs e)
        {
            if(gmf.playerTurn==1 && gmf.selectedDice != -1)
            {
                //gmf.moveToken(1, 1);
            }
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
