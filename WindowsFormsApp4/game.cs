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
        Random rnd = new Random();
        gameFunctions gmf = new gameFunctions();

        public game()
        {
            InitializeComponent();
        }


        private void game_Load(object sender, EventArgs e)
        {
            setPlayerRollBtns();
            setDiceBoxes();
            gmf.showPlayerRollBtn();
        }

        private void redPlayerRollBtn_Click(object sender, EventArgs e)
        {
            hitRollBtn();
        }

        private void bluePlayerRollBtn_Click(object sender, EventArgs e)
        {

            hitRollBtn();
        }

        private void greenPlayerRollBtn_Click(object sender, EventArgs e)
        {
            hitRollBtn();
        }

        private void yellowPlayerRollBtn_Click(object sender, EventArgs e)
        {
            hitRollBtn();
        }

        private void diceBox3_Click(object sender, EventArgs e)
        {

        }

        public async void hitRollBtn()
        {
            gmf.shot = rnd.Next(1, 7);
            gmf.setDice();
            if (gmf.shot < 6)
            {
                await System.Threading.Tasks.Task.Delay(500);
                gmf.changeTurn();
            }
        }

        public void setPlayerRollBtns()
        {
            gmf.playerRollBtns[1] = redPlayerRollBtn;
            gmf.playerRollBtns[2] = greenPlayerRollBtn;
            gmf.playerRollBtns[3] = bluePlayerRollBtn;
            gmf.playerRollBtns[4] = yellowPlayerRollBtn;
        }
        public void setDiceBoxes()
        {
            gmf.diceBoxes[1] = diceBox1;
            gmf.diceBoxes[2] = diceBox2;
            gmf.diceBoxes[3] = diceBox3;
            gmf.diceBoxes[4] = diceBox4;
            gmf.diceBoxes[5] = diceBox5;
            gmf.diceBoxes[6] = diceBox6;
            gmf.hideAllDiceBoxes();
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
