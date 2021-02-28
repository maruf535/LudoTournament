using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class gameFunctions
    {
        //properties starts
        public playersObj[] playersArray = new playersObj[5];
        public PictureBox[] playerRollBtns = new PictureBox[5];//array of roll buttins of 4 players,[1]=red,[2]=green,[3]=yellow,[4]=blue
        public PictureBox[] diceBoxes = new PictureBox[7];//array of diceBox objects
        public int[] diceBoxVals = new int[7];//contains the values of six dice boxes' values
        public int selectedDice = 1;//jei diceBox select korbe tar number
        public int diceNumber = 1;//jei dice box currently khali ache result boshanor jonno
        public int playerTurn = 1; //kon plater er turn ekhon
        public int shot=0;//joto shot ashe roll korar por
        //properties end

        public System.Drawing.Bitmap getPotrait(int g)
        {
            //potrait image set korar jonno ei function use hobe
            if (g == 1)
            {
                return global::WindowsFormsApp4.Properties.Resources.malePotrait;
            }
            else
                return global::WindowsFormsApp4.Properties.Resources.femalePotrait;
        }

        public System.Drawing.Bitmap getDiceImage(int d)
        {
            //dice box e nirdisto shot er jonno nirdishto image set korte ei function use hobe
            switch(d)
            {
                case 0:
                    return global::WindowsFormsApp4.Properties.Resources.dice0;
                case 1:
                    return global::WindowsFormsApp4.Properties.Resources.dice1;
                case 2:
                    return global::WindowsFormsApp4.Properties.Resources.dice2;
                case 3:
                    return global::WindowsFormsApp4.Properties.Resources.dice3;
                case 4:
                    return global::WindowsFormsApp4.Properties.Resources.dice4;
                case 5:
                    return global::WindowsFormsApp4.Properties.Resources.dice5;
                case 6:
                    return global::WindowsFormsApp4.Properties.Resources.dice6;
                default:
                    return global::WindowsFormsApp4.Properties.Resources.diceRoll;//dice with question mark
            }
        }

        public void showPlayerRollBtn()
        {
            for(int i = 1; i < 5; i++)//shob player er roll button hide kore dibe
            {
                playerRollBtns[i].Hide();
            }
            playerRollBtns[playerTurn].Show();//shudhu jei player er ekhon turn tar ta show korbe
        }

        public void setDice()
        {
            diceBoxVals[diceNumber] = shot;//keeping the value of the diceBox
            diceBoxes[diceNumber].Show();//joto number dice ekhon free ache, shetake show korabe
            diceBoxes[diceNumber].Image = getDiceImage(shot);//joto shot, oi shot er image set kore dicchi
            diceNumber++;//next dice k point koracchi, incase jodi oi player er aro turn thake
        }

        public void hideAllDiceBoxes()
        {
            //shob gula dice box clear korchi turn change er shomoy, but pore r eta lagbe na, tokhon jei dice er value e use hoye jabe sheta remove hoye jabe
            for(int i = 1; i <= 6; i++)
            {
                diceBoxes[i].Hide();
            }
        }

        public void changeTurn()
        {
            //player turn change korar shomoy ja ja clear or change kora lage ta ekhane hobe
            if (playerTurn < 4)
                playerTurn++;
            else
                playerTurn = 1;
            showPlayerRollBtn();
            diceNumber = 1;
            selectedDice = -1;
            hideAllDiceBoxes();
        }

        public void moveToken(int player, int tokenNum)
        {

        }
    }
}
